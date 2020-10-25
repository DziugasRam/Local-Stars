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
    public class TempController : ControllerBase
    {
        private readonly DataContext _context;

        public TempController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("populate")]
        public void GetProducts()
        {
            _context.Sellers.AddRange(MockData.Sellers);
            _context.Buyers.AddRange(MockData.Buyers);
            _context.Users.AddRange(MockData.Users);
            _context.Products.AddRange(MockData.Products);
            _context.SaveChanges();
        }

        [HttpGet]
        [Route("getp")]
        public IEnumerable<Product> asd()
        {
            return _context.Products.AsEnumerable();
        }

        [HttpGet]
        [Route("getb")]
        public IEnumerable<Buyer> hdgf()
        {
            return _context.Buyers.AsEnumerable();
        }

        [HttpGet]
        [Route("gets")]
        public IEnumerable<Seller> asdf()
        {
            return _context.Sellers.AsEnumerable();
        }

        [HttpGet]
        [Route("getu")]
        public IEnumerable<User> qw3rwe()
        {
            return _context.Users.AsEnumerable();
        }
    }
}
