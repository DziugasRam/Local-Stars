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
        private readonly ProductProvider m_productProvider;

        public ProductController(ProductProvider productProvider)
        {
            m_productProvider = productProvider;
        }

        [HttpGet]
        [Route("title")]
        public IEnumerable<Product> GetProducts([FromQuery]string searchVal, [FromQuery]bool fullMatch = false)
        {
            return m_productProvider.GetByTitle(searchVal, fullMatch, StringComparison.OrdinalIgnoreCase);
        }

        [HttpPost]
        [Route("id")]
        public IEnumerable<Product> GetProducts([FromBody]Guid[] ids)
        {
            return m_productProvider.GetById(ids);
        }

        [HttpPost]
        [Route("sellerId")]
        public IEnumerable<Product> GetBySeller([FromBody]IEnumerable<Guid> ids)
        {
            return m_productProvider.GetBySeller(ids);
        }

        [HttpDelete]
        public void RemoveById([FromBody]IEnumerable<Guid> ids)
        {
            m_productProvider.RemoveById(ids);
        }

        [HttpPost]
        public void Insert([FromBody]IEnumerable<Product> products)
        {
            m_productProvider.Insert(products);
        }

        [HttpPut]
        public void Update([FromBody]Product product)
        {
            m_productProvider.Update(product);
        }
    }
}
