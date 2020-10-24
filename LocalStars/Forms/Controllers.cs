using Server.Controllers;
using Server.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forms
{
    public static class Controllers
    {
        private static readonly BuyerProvider _buyerProvider = new BuyerProvider();
        private static readonly ProductProvider _productProvider = new ProductProvider();
        private static readonly SellerProvider _sellerProvider = new SellerProvider();

        public static readonly BuyerController BuyerController = new BuyerController(_buyerProvider, _productProvider, _sellerProvider);
        public static readonly ProductController ProductController = new ProductController(_buyerProvider, _productProvider, _sellerProvider);
        public static readonly SellerController SellerController = new SellerController(_buyerProvider, _productProvider, _sellerProvider);
    }
}
