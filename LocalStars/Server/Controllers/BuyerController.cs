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
        private readonly BuyerProvider _buyerProvider;
        private readonly ProductProvider _productProvider;
        private readonly SellerProvider _sellerProvider;

        public BuyerController(BuyerProvider buyerProvider, ProductProvider productProvider, SellerProvider sellerProvider)
        {
            _buyerProvider = buyerProvider;
            _productProvider = productProvider;
            _sellerProvider = sellerProvider;
        }

        [HttpGet]
        public Buyer GetById(Guid id)
        {
            return _buyerProvider.GetById(id);
        }

        [HttpPost]
        public void Insert(Buyer buyer)
        {
            _buyerProvider.Insert(buyer);
        }

        [HttpDelete]
        public void Remove(Guid id)
        {
            _buyerProvider.Remove(id);
        }

        [HttpPut]
        public void Update(Buyer buyer)
        {
            _buyerProvider.Insert(buyer);
        }

        [HttpPut]
        public void AddLikedProduct(Guid id, Product product)
        {
            _buyerProvider.AddLikedProduct(id, product);
        }

        public void RemoveLikedProduct(Guid id,Product product)
        {
            _buyerProvider.RemoveLikedProduct(id, product);
        }
    }
}
