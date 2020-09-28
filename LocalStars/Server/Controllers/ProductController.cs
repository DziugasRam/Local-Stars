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
        private readonly BuyerProvider m_buyerProvider;
        private readonly ProductProvider m_productProvider;
        private readonly SellerProvider m_sellerProvider;

        public ProductController(BuyerProvider buyerProvider, ProductProvider productProvider, SellerProvider sellerProvider)
        {
            m_buyerProvider = buyerProvider;
            m_productProvider = productProvider;
            m_sellerProvider = sellerProvider;
        }

        [HttpGet]
        [Route("title")]
        public IEnumerable<Product> GetProducts([FromQuery] string searchVal, [FromQuery] bool fullMatch = false)
        {
            return m_productProvider.GetByTitle(searchVal, fullMatch, StringComparison.OrdinalIgnoreCase);
        }

        [HttpPost]
        [Route("ids")]
        public IEnumerable<Product> GetProducts([FromBody] Guid[] ids)
        {
            return m_productProvider.GetById(ids);
        }

        [HttpPost]
        [Route("sellerId")]
        public IEnumerable<Product> GetBySeller([FromBody] IEnumerable<Guid> ids)
        {
            return m_productProvider.GetBySeller(ids);
        }

        [HttpGet]
        public Product Get([FromQuery] Guid id)
        {
            return m_productProvider.GetById(new[] { id }).Single();
        }

        [HttpDelete]
        public void RemoveById([FromBody] IEnumerable<Guid> ids)
        {
            m_productProvider.RemoveById(ids);
        }

        [HttpPost]
        public void Insert([FromBody] IEnumerable<Product> products)
        {
            m_productProvider.Insert(products);
        }

        [HttpPut]
        public void Update([FromBody] Product product)
        {
            m_productProvider.Update(product);
        }
    }
}
