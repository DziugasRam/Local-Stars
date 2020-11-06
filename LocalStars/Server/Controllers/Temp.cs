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
    public class TempController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ProductProvider _productProvider;

        public TempController(DataContext context, ProductProvider productProvider)
        {
            _context = context;
            _productProvider = productProvider;
        }

        [HttpGet]
        [Route("populate")]
        public void InsertMockDataIntoDB()
        {
            _context.Sellers.AddRange(MockData.Sellers);
            _context.Buyers.AddRange(MockData.Buyers);
            _context.Users.AddRange(MockData.Users);
            _context.Products.AddRange(MockData.Products);
            _context.BuyerProducts.AddRange(MockData.BuyerProducts);
            _context.SaveChanges();
        }

        [HttpGet]
        [Route("getp")]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.AsEnumerable();
        }

        [HttpGet]
        [Route("getb")]
        public IEnumerable<Buyer> GetBuyers()
        {
            return _context.Buyers.AsEnumerable();
        }

        [HttpGet]
        [Route("gets")]
        public IEnumerable<Seller> GetSellers()
        {
            return _context.Sellers.AsEnumerable();
        }

        [HttpGet]
        [Route("getu")]
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.AsEnumerable();
        }

        [HttpGet]
        [Route("getProductsForSellers")]
        public IEnumerable<ProductsForSeller> GetProductsForSellers()
        {
            var sellers = GetSellers().ToList();
            return _productProvider.GetBySeller(sellers);
        }
    }
}
