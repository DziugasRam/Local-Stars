﻿using Server.Controllers;
using Server.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forms
{
    public static class Controllers
    {
        private static readonly BuyerProvider s_buyerProvider = new BuyerProvider();
        private static readonly ProductProvider s_productProvider = new ProductProvider();
        private static readonly SellerProvider s_sellerProvider = new SellerProvider();

        public static readonly BuyerController s_buyerController = new BuyerController(s_buyerProvider, s_productProvider, s_sellerProvider);
        public static readonly ProductController s_productController = new ProductController(s_buyerProvider, s_productProvider, s_sellerProvider);
        public static readonly SellerController s_sellerController = new SellerController(s_buyerProvider, s_productProvider, s_sellerProvider);
    }
}
