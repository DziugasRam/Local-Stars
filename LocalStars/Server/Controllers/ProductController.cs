using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> SearchProducts(string searchVal)
        {
            return MockData.s_products.Where(p => p.Title?.ToLower().Contains(searchVal, StringComparison.InvariantCultureIgnoreCase) ?? false);
        }
    }
}
