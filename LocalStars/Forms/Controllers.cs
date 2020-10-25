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
        public static Buyer CurrentBuyer = BuyerController.GetById(new Guid("7253737e-6365-4e70-aaf9-c8824680b3bf"));
        public static Seller CurrentSeller = SellerController.GetById(new Guid("fbcfcd13-2e98-4faf-beb1-4c544d0badd2"));
    }
}
