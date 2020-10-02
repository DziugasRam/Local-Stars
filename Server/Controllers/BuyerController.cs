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
    public class BuyerController : ControllerBase
    {
        private readonly BuyerProvider m_buyerProvider;
        private readonly ProductProvider m_productProvider;
        private readonly SellerProvider m_sellerProvider;

        public BuyerController(BuyerProvider buyerProvider, ProductProvider productProvider, SellerProvider sellerProvider)
        {
            m_buyerProvider = buyerProvider;
            m_productProvider = productProvider;
            m_sellerProvider = sellerProvider;
        }

        [HttpGet]
        public Buyer GetById(Guid id)
        {
            return m_buyerProvider.GetById(id);
        }

        [HttpPost]
        public void Insert(Buyer buyer)
        {
            m_buyerProvider.Insert(buyer);
        }

        [HttpDelete]
        public void Remove(Guid id)
        {
            m_buyerProvider.Remove(id);
        }

        [HttpPut]
        public void Update(Buyer buyer)
        {
            m_buyerProvider.Insert(buyer);
        }
    }
}
