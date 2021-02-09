using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Providers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Server.Controllers.Models;
using System.Threading;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly BuyerProvider _buyerProvider;
        private readonly ProductProvider _productProvider;
        private readonly SellerProvider _sellerProvider;
        private readonly DataContext _context;
        private readonly UserProvider _userProvider;

        public ProductController(BuyerProvider buyerProvider, ProductProvider productProvider, SellerProvider sellerProvider, DataContext context, UserProvider userProvider)
        {
            _buyerProvider = buyerProvider;
            _productProvider = productProvider;
            _sellerProvider = sellerProvider;
            _userProvider = userProvider;
            _context = context;
        }

        [HttpGet]
        [Route("title")]
        [AllowAnonymous]
        public IEnumerable<Product> GetProducts([FromQuery] string searchVal, [FromQuery] bool fullMatch = false)
        {
            return _productProvider.GetByTitle(searchVal, fullMatch, StringComparison.OrdinalIgnoreCase);
        }

        [HttpGet]
        [Route("category")]
        [AllowAnonymous]
        public IEnumerable<Product> GetProductsByCategory([FromQuery] string searchVal, [FromQuery] bool fullMatch = false)
        {
            return _productProvider.GetByType(searchVal, fullMatch, StringComparison.OrdinalIgnoreCase);
        }

        [HttpPost]
        [Route("ids")]
        [AllowAnonymous]
        public IEnumerable<Product> GetProducts([FromBody] Guid[] ids)
        {
            return _productProvider.GetById(ids);
        }

        [HttpGet]
        [Route("sellerId")]
        [AllowAnonymous]
        public ProductsForSeller GetBySeller([FromQuery] Guid id)
        {
            var sellers = _sellerProvider.GetById(new [] {id}).ToList();
            return _productProvider.GetBySeller(sellers).Single();
        }

        [HttpGet]
        [Route("{id}")]
        [AllowAnonymous]
        public Product Get([FromRoute] Guid id)
        {
            return _productProvider.GetById(new[] { id }).Single();
        }

        // Needs to be replaced with location based search
        [HttpGet]
        [Route("get")]
        [AllowAnonymous]
        public IEnumerable<ProductModel> Get()
        {
            return _productProvider
                .Get();
        }

        [HttpGet]
        [Route("count")]
        [AllowAnonymous]
        public int CountProducts()
        {
            return _productProvider
                .CountProducts();
        }

        [HttpGet]
        [Route("getPage")]
        [AllowAnonymous]
        public IEnumerable<ProductModel> GetPage([FromQuery] int page)
        {
            return _productProvider
                .GetPage(page);
        }

        [HttpGet]
        [Route("sorted")]
        [AllowAnonymous]
        public IEnumerable<Product> GetSorted([FromQuery] string variant, [FromQuery] int page)
        {
            return _productProvider.GetSorted(variant,page);
        }

        [HttpDelete]
        public void Delete([FromBody] Guid id)
        {
            _productProvider.RemoveById(id);
        }

        [HttpPost]
        [Route("insert")]
        public void Insert([FromForm] ProductData productData)
        {

            byte[] file;
            using (var stream = new MemoryStream())
            {
                productData.ImageFile.CopyTo(stream);
                file = stream.ToArray();
            }

            var sellerId = _userProvider.GetUser(Guid.Parse(Request.HttpContext.User.Claims.Single(c => c.Type == ClaimTypes.NameIdentifier).Value)).AssociatedSeller;
            var product = new Product(productData.Title, productData.Category, productData.Price, sellerId, productData.Description, Guid.NewGuid(), file);

            _productProvider.Insert(product);
        }

        [HttpPut]
        public ProductModel Update([FromQuery] Guid id, [FromBody] UpdateProductData productData)
        {
            return new ProductModel(_productProvider.Update(id, productData));
        }
    }
}