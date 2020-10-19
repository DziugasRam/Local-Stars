using Models;
using System;
using System.Collections.Generic;

namespace Server
{
    public static class MockData
    {
        public static readonly Seller Seller1 = new Seller(nameof(Seller1), $"{nameof(Seller1)}_lastName", new Location((1,0), "Seller1 address"), Guid.NewGuid());
        public static readonly Seller Seller2 = new Seller(nameof(Seller2), $"{nameof(Seller2)}_lastName", new Location((2,0), "Seller2 address"), Guid.NewGuid());
        public static readonly Seller Seller3 = new Seller(nameof(Seller3), $"{nameof(Seller3)}_lastName", new Location((3,0), "Seller3 address"), Guid.NewGuid());
        public static readonly Seller Seller4 = new Seller(nameof(Seller4), $"{nameof(Seller4)}_lastName", new Location((4,0), "Seller4 address"), Guid.NewGuid());

        public static readonly List<Seller> Sellers = new List<Seller> { Seller1, Seller2, Seller3, Seller4 };

        public static readonly Buyer Buyer1 = new Buyer(nameof(Buyer1), $"{nameof(Buyer1)}_lastName", Guid.NewGuid(), new List<Product>());
        public static readonly Buyer Buyer2 = new Buyer(nameof(Buyer2), $"{nameof(Buyer2)}_lastName", Guid.NewGuid(), new List<Product>());
        public static readonly Buyer Buyer3 = new Buyer(nameof(Buyer3), $"{nameof(Buyer3)}_lastName", Guid.NewGuid(), new List<Product>());
        public static readonly Buyer Buyer4 = new Buyer(nameof(Buyer4), $"{nameof(Buyer4)}_lastName", Guid.NewGuid(), new List<Product>());

        public static readonly List<Buyer> Buyers = new List<Buyer> { Buyer1, Buyer2, Buyer3, Buyer4 };
      
        public static readonly List<Product> Products = new List<Product> {

            new Product($"{nameof(Seller1)}_Product1","Pears", 2, Seller1.Id,Guid.NewGuid(), "new"),
            new Product($"{nameof(Seller1)}_Product3","Potatoes", 3, Seller1.Id, Guid.NewGuid(), "new"),
            new Product($"{nameof(Seller1)}_Product2","Garlics", 1, Seller1.Id,Guid.NewGuid(),"new"),
            new Product($"{nameof(Seller2)}_Product1","Cucumbers", 1, Seller2.Id,Guid.NewGuid(),"new"),
            new Product($"{nameof(Seller2)}_Product2","Garlics", 4, Seller2.Id, Guid.NewGuid(),"new"),
            new Product($"{nameof(Seller4)}_Product1","Apples", 1, Seller4.Id,Guid.NewGuid(),"new"),
            new Product($"{nameof(Seller4)}_Product2","Pears", 1, Seller4.Id, Guid.NewGuid(),"new")
        };

        public static readonly User User1 = new User("user1", "psw", Guid.NewGuid(), Buyer1.Id, Seller1.Id);
        public static readonly User User2 = new User("user2", "psw", Guid.NewGuid(), Buyer2.Id, Seller3.Id);
        public static readonly User User3 = new User("user3", "psw", Guid.NewGuid(), Buyer3.Id, Seller4.Id);
        public static readonly User User4 = new User("user4", "psw", Guid.NewGuid(), Buyer4.Id, Seller2.Id);

        public static readonly List<User> Users = new List<User>
        {
            User1,
            User2,
            User3,
            User4
        };
 
    }
}
