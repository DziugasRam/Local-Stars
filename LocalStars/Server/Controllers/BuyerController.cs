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
        private readonly Lazy<BuyerProvider> _buyerProvider;
        private readonly Lazy<ProductProvider> _productProvider;
        private readonly Lazy<SellerProvider> _sellerProvider;

        public BuyerController(Lazy<BuyerProvider> buyerProvider, Lazy<ProductProvider> productProvider, Lazy<SellerProvider> sellerProvider)
        {
            _buyerProvider = buyerProvider;
            _productProvider = productProvider;
            _sellerProvider = sellerProvider;

        }

        [HttpGet]
        public Buyer GetById(Guid id)
        {
            return _buyerProvider.Value.GetById(id);
        }

        [HttpPost]
        public void Insert(Buyer buyer)
        {
            _buyerProvider.Value.Insert(buyer);
        }

        [HttpDelete]
        public void Remove(Guid id)
        {
            _buyerProvider.Value.Remove(id);
        }

        [HttpPut]
        public void Update(Buyer buyer)
        {
            _buyerProvider.Value.Insert(buyer);
        }

        [HttpPut]
        public void AddLikedProduct(Guid id, Product product)
        {
            _buyerProvider.Value.AddLikedProduct(id, product);
        }

        public void RemoveLikedProduct(Guid id,Product product)
        {
            _buyerProvider.Value.RemoveLikedProduct(id, product);
        }

        public bool IsLikedProduct(Guid id, Product product)
        {
            return _buyerProvider.Value.IsLikedProduct(id, product);
        }
    }
}
