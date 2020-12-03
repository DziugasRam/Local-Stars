using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Controllers.Models;
using Server.Providers;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly BuyerProvider _buyerProvider;
        private readonly ProductProvider _productProvider;
        private readonly SellerProvider _sellerProvider;
        private readonly UserProvider _userProvider;

        public SellerController(BuyerProvider buyerProvider, ProductProvider productProvider, SellerProvider sellerProvider, UserProvider userProvider)
        {
            _buyerProvider = buyerProvider;
            _productProvider = productProvider;
            _sellerProvider = sellerProvider;
            _userProvider = userProvider;
        }

        [HttpGet]
        [Route("byProductTitle")]
        public IEnumerable<Seller> GetSellersForProduct(string productTitle, bool fullMatch = true)
        {
            var productSellerIds = _productProvider.GetByTitle(productTitle, fullMatch).Select(p => p.Seller.Id);
            return _sellerProvider.GetById(productSellerIds);
        }

        [HttpGet]
        [Route("byLocation")]
        public IEnumerable<Seller> GetSellersByLocationForProduct(Locatable location, double maxDistanceToSeller, string productTitle, bool fullMatch = true)
        {
            var sellers = GetSellersForProduct(productTitle, fullMatch);
            var squareMaxDistance = maxDistanceToSeller * maxDistanceToSeller;
            return sellers.Where(s => s.SquareDistanceTo(location) < squareMaxDistance);
        }

        [HttpGet]
        public Seller GetById(Guid id)
        {
            return _sellerProvider.GetById(new[] { id }).Single();
        }

        [HttpPost]
        [Route("register")]
        public void Register([FromBody]SellerData sellerData)
        {
            var seller = _sellerProvider.Insert(sellerData.FirstName, sellerData.LastName, sellerData.PhoneNumber, sellerData.Address, sellerData.Longitude, sellerData.Latitude);
            string userId = Request.HttpContext.User.Claims.Single(c => c.Type == ClaimTypes.NameIdentifier).Value;
            _userProvider.LinkToSeller(Guid.Parse(userId), seller.Id);
        }

        [HttpDelete]
        public void Remove(Guid id)
        {
            _sellerProvider.Remove(id);
        }

        //[HttpPut]
        //public void Update(Seller seller)
        //{
        //    _sellerProvider.Insert(seller);
        //}
    }
}
