using Models;
using Server.Controllers;
using Server.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Media;

namespace Forms
{
    public static class Controllers
    {
        public static readonly BuyerController BuyerController = Program.ServiceProvider.GetService(typeof(BuyerController)) as BuyerController;
        public static readonly ProductController ProductController = Program.ServiceProvider.GetService(typeof(ProductController)) as ProductController;
        public static readonly SellerController SellerController = Program.ServiceProvider.GetService(typeof(SellerController)) as SellerController;
        public static Buyer CurrentBuyer = BuyerController.GetById(new Guid("13b7945e-05d0-432c-810f-7c039bb1663a"));
        public static Seller CurrentSeller = SellerController.GetById(new Guid("5b0339c2-5a71-4f8d-8d0e-601dfb22bd92"));
    }
}
