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
    public class SellerController : ControllerBase
    {
        private readonly BuyerProvider m_buyerProvider;
        private readonly ProductProvider m_productProvider;
        private readonly SellerProvider m_sellerProvider;

        public SellerController(BuyerProvider buyerProvider, ProductProvider productProvider, SellerProvider sellerProvider)
        {
            m_buyerProvider = buyerProvider;
            m_productProvider = productProvider;
            m_sellerProvider = sellerProvider;
        }

        [HttpGet]
        [Route("byProductTitle")]
        public IEnumerable<Seller> GetSellersForProduct(string productTitle, bool fullMatch = true)
        {
            var productSellerIds = m_productProvider.GetByTitle(productTitle, fullMatch).Select(p => p.SellerId);
            return m_sellerProvider.GetById(productSellerIds);
        }

        [HttpGet]
        [Route("byLocation")]
        public IEnumerable<Seller> GetSellersByLocationForProduct(Location location, double maxDistanceToSeller, string productTitle, bool fullMatch = true)
        {
            var sellers = GetSellersForProduct(productTitle, fullMatch);
            var squareMaxDistance = maxDistanceToSeller * maxDistanceToSeller;
            return sellers.Where(s => s.Location.SquareDistanceTo(location) < squareMaxDistance);
        }

        [HttpGet]
        public Seller GetById(Guid id)
        {
            return m_sellerProvider.GetById(new[] { id }).Single();
        }

        [HttpPost]
        public void Insert(Seller seller)
        {
            m_sellerProvider.Insert(seller);
        }

        [HttpDelete]
        public void Remove(Guid id)
        {
            m_sellerProvider.Remove(id);
        }

        [HttpPut]
        public void Update(Seller seller)
        {
            m_sellerProvider.Insert(seller);
        }
    }
}
