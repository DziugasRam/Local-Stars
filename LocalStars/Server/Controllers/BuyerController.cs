using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Providers;

namespace Server.Controllers
{
    [AllowAnonymous]
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
        [Route("get")]
        public Buyer GetById([FromQuery]Guid id)
        {
            return _buyerProvider.GetById(id);
        }

        //[HttpPost]
        //public void Insert(Buyer buyer)
        //{
        //    _buyerProvider.Insert(buyer);
        //}

        [HttpDelete]
        public void Remove(Guid id)
        {
            _buyerProvider.Remove(id);
        }

        //[HttpPut]
        //public void Update(Buyer buyer)
        //{
        //    _buyerProvider.Insert(buyer);
        //}

        [HttpPost]
        [Route("like/{id}")]
        public void AddLikedProduct([FromRoute]Guid id, [FromBody]Product product)
        {
            _buyerProvider.AddLikedProduct(id, product);
        }

        [HttpDelete]
        [Route("unlike/{id}")]
        public void RemoveLikedProduct([FromRoute]Guid id,[FromBody]Product product)
        {
            _buyerProvider.RemoveLikedProduct(id, product);
        }

        [HttpGet]
        [Route("isLiked")]
        public bool IsLikedProduct([FromQuery]Guid buyerId, [FromQuery]Guid productId)
        {
            return _buyerProvider.IsLikedProduct(buyerId, productId);
        }
    }
}
