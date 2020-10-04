using Models;
using System;
using System.Collections.Generic;

namespace Server
{
    static class MockData
    {
        public static readonly Seller Seller1 = new Seller(nameof(Seller1), $"{nameof(Seller1)}_lastName", new Location((1,0), "Seller1 address"), new Guid());
        public static readonly Seller Seller2 = new Seller(nameof(Seller2), $"{nameof(Seller2)}_lastName", new Location((2,0), "Seller2 address"), new Guid());
        public static readonly Seller Seller3 = new Seller(nameof(Seller3), $"{nameof(Seller3)}_lastName", new Location((3,0), "Seller3 address"), new Guid());
        public static readonly Seller Seller4 = new Seller(nameof(Seller4), $"{nameof(Seller4)}_lastName", new Location((4,0), "Seller4 address"), new Guid());

        public static readonly List<Seller> Sellers = new List<Seller> { Seller1, Seller2, Seller3, Seller4 };

        public static readonly Buyer Buyer1 = new Buyer(nameof(Buyer1), $"{nameof(Buyer1)}_lastName", new Guid());
        public static readonly Buyer Buyer2 = new Buyer(nameof(Buyer2), $"{nameof(Buyer2)}_lastName", new Guid());
        public static readonly Buyer Buyer3 = new Buyer(nameof(Buyer3), $"{nameof(Buyer3)}_lastName", new Guid());
        public static readonly Buyer Buyer4 = new Buyer(nameof(Buyer4), $"{nameof(Buyer4)}_lastName", new Guid());

        public static readonly List<Buyer> Buyers = new List<Buyer> { Buyer1, Buyer2, Buyer3, Buyer4 };

        public static readonly List<Product> Products = new List<Product> {

            new Product($"{nameof(Seller1)}_Product1", 1, Seller1.Id, "new", new Guid()),
            new Product($"{nameof(Seller1)}_Product3", 1, Seller1.Id, "new", new Guid()),
            new Product($"{nameof(Seller1)}_Product2", 1, Seller1.Id, "new", new Guid()),
            new Product($"{nameof(Seller2)}_Product1", 1, Seller2.Id, "new", new Guid()),
            new Product($"{nameof(Seller2)}_Product2", 1, Seller2.Id, "new", new Guid()),
            new Product($"{nameof(Seller4)}_Product1", 1, Seller4.Id, "new", new Guid()),
            new Product($"{nameof(Seller4)}_Product2", 1, Seller4.Id, "new", new Guid())
        };

        public static readonly User User1 = new User("user1", "psw", Buyer1.Id, Seller1.Id, new Guid());
        public static readonly User User2 = new User("user2", "psw", Buyer2.Id, Seller3.Id, new Guid());
        public static readonly User User3 = new User("user3", "psw", Buyer3.Id, Seller4.Id, new Guid());
        public static readonly User User4 = new User("user4", "psw", Buyer4.Id, Seller2.Id, new Guid());

        public static readonly List<User> Users = new List<User>
        {
            User1,
            User2,
            User3,
            User4
        };
    }
}
