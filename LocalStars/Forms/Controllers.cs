using Models;
using Server.Controllers;
using Server.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forms
{
    public static class Controllers
    {
        public static readonly BuyerController BuyerController = Program.ServiceProvider.GetService(typeof(BuyerController)) as BuyerController;
        public static readonly ProductController ProductController = Program.ServiceProvider.GetService(typeof(ProductController)) as ProductController;
        public static readonly SellerController SellerController = Program.ServiceProvider.GetService(typeof(SellerController)) as SellerController;
        public static Buyer CurrentBuyer = BuyerController.GetById(new Guid("aefbc372-b8e5-4261-aa54-a04fcefa8feb"));
        public static Seller CurrentSeller = SellerController.GetById(new Guid("33e73203-f1c0-49f9-a4cc-cf88ee5b334d"));
    }
}
