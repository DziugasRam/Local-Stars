using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Providers;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Lazy <BuyerProvider> _buyerProvider;
        private readonly Lazy <ProductProvider> _productProvider;
        private readonly Lazy <SellerProvider> _sellerProvider;
        private readonly DataContext _context;

        public ProductController(Lazy <BuyerProvider> buyerProvider,Lazy< ProductProvider> productProvider,Lazy <SellerProvider> sellerProvider, DataContext context)
        {
            _buyerProvider = buyerProvider;
            _productProvider = productProvider;
            _sellerProvider = sellerProvider;
            _context = context;
        }

        [HttpGet]
        [Route("title")]
        public IEnumerable<Product> GetProducts([FromQuery] string searchVal, [FromQuery] bool fullMatch = false)
        {
            return _productProvider.Value.GetByTitle(searchVal, fullMatch, StringComparison.OrdinalIgnoreCase);
        }

        [HttpPost]
        [Route("ids")]
        public IEnumerable<Product> GetProducts([FromBody] Guid[] ids)
        {
            return _productProvider.Value.GetById(ids);
        }

        [HttpPost]
        [Route("sellerId")]
        public IEnumerable<ProductsForSeller> GetBySeller([FromBody] IEnumerable<Guid> ids)
        {
            var sellers = _sellerProvider.Value.GetById(ids).ToList();
            return _productProvider.Value.GetBySeller(sellers);
        }

        [HttpGet]
        [Route("{id}")]
        public Product Get([FromRoute] Guid id)
        {
            return _productProvider.Value.GetById(new[] { id }).Single();
        }

        // Needs to be replaced with location based search
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productProvider.Value
                .Get()
                .ToArray();
        }


        [HttpDelete]
        public void RemoveById([FromBody] IEnumerable<Guid> ids)
        {
            _productProvider.Value.RemoveById(ids);
        }

        [HttpPost]
        public void Insert([FromBody] IEnumerable<Product> products)
        {
            _productProvider.Value.Insert(products);
        }

        [HttpPut]
        public void Update([FromBody] Product product)
        {
            _productProvider.Value.Update(product);
        }
    }
}
