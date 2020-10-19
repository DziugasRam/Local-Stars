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
        private readonly BuyerProvider _buyerProvider;
        private readonly ProductProvider _productProvider;
        private readonly SellerProvider _sellerProvider;

        public ProductController(BuyerProvider buyerProvider, ProductProvider productProvider, SellerProvider sellerProvider)
        {
            _buyerProvider = buyerProvider;
            _productProvider = productProvider;
            _sellerProvider = sellerProvider;
        }

        [HttpGet]
        [Route("title")]
        public IEnumerable<Product> GetProducts([FromQuery] string searchVal, [FromQuery] bool fullMatch = false)
        {
            return _productProvider.GetByTitle(searchVal, fullMatch, StringComparison.OrdinalIgnoreCase);
        }

        [HttpPost]
        [Route("ids")]
        public IEnumerable<Product> GetProducts([FromBody] Guid[] ids)
        {
            return _productProvider.GetById(ids);
        }

        [HttpPost]
        [Route("sellerId")]
        public IEnumerable<ProductsForSeller> GetBySeller([FromBody] IEnumerable<Guid> ids)
        {
            return _productProvider.GetBySeller(ids);
        }

        [HttpGet]
        public Product Get([FromQuery] Guid id)
        {
            return _productProvider.GetById(new[] { id }).Single();
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productProvider.Get();
        }


        [HttpDelete]
        public void RemoveById([FromBody] IEnumerable<Guid> ids)
        {
            _productProvider.RemoveById(ids);
        }

        [HttpPost]
        public void Insert([FromBody] IEnumerable<Product> products)
        {
            _productProvider.Insert(products);
        }

        [HttpPut]
        public void Update([FromBody] Product product)
        {
            _productProvider.Update(product);
        }
    }
}
