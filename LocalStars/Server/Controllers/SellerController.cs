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
    public class SellerController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Seller> GetSellersForProduct(string productTitle)
        {
            var products = MockData.s_products.Where(p => p.Title == productTitle);
            return MockData.s_sellers.Join(
                products,
                s => s.Id,
                p => p.SellerId,
                (s, p) => s
            );
        }
    }
}
