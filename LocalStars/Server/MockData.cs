using Models;
using System;
using System.Collections.Generic;

namespace Server
{
    struct MockData
    {
        public static readonly Seller Seller1 = new Seller(nameof(Seller1), $"{nameof(Seller1)}_lastName", $"{nameof(Seller1)} phone number", 1, 0, "Seller1 address", Guid.NewGuid());
        public static readonly Seller Seller2 = new Seller(nameof(Seller2), $"{nameof(Seller2)}_lastName", $"{nameof(Seller2)} phone number", 2, 0, "Seller2 address", Guid.NewGuid());
        public static readonly Seller Seller3 = new Seller(nameof(Seller3), $"{nameof(Seller3)}_lastName", $"{nameof(Seller3)} phone number", 3, 0, "Seller3 address", Guid.NewGuid());
        public static readonly Seller Seller4 = new Seller(nameof(Seller4), $"{nameof(Seller4)}_lastName", $"{nameof(Seller4)} phone number", 4, 0, "Seller4 address", Guid.NewGuid());

        public static readonly List<Seller> Sellers = new List<Seller> { Seller1, Seller2, Seller3, Seller4 };

        public static readonly Buyer Buyer1 = new Buyer(nameof(Buyer1), $"{nameof(Buyer1)}_lastName", Guid.NewGuid(), new List<BuyerProduct>());
        public static readonly Buyer Buyer2 = new Buyer(nameof(Buyer2), $"{nameof(Buyer2)}_lastName", Guid.NewGuid(), new List<BuyerProduct>());
        public static readonly Buyer Buyer3 = new Buyer(nameof(Buyer3), $"{nameof(Buyer3)}_lastName", Guid.NewGuid(), new List<BuyerProduct>());
        public static readonly Buyer Buyer4 =
            new Buyer(nameof(Buyer4), $"{nameof(Buyer4)}_lastName", Guid.NewGuid(),
                new List<BuyerProduct>());

        public static readonly List<Buyer> Buyers = new List<Buyer> { Buyer1, Buyer2, Buyer3, Buyer4 };

        public static readonly List<Product> Products = new List<Product>
        {
            new Product($"{nameof(Seller1)}_Product1", "Pears", 2, Seller1, "new", Guid.NewGuid()),
            new Product($"{nameof(Seller1)}_Product3", "Potatoes", 3, Seller1, "new", Guid.NewGuid()),
            new Product($"{nameof(Seller1)}_Product2", "Garlics", 1, Seller1, "new", Guid.NewGuid()),
            new Product($"{nameof(Seller2)}_Product1", "Cucumbers", 1, Seller2, "new", Guid.NewGuid()),
            new Product($"{nameof(Seller2)}_Product2", "Garlics", 4, Seller2, "new", Guid.NewGuid()),
            new Product($"{nameof(Seller4)}_Product1", "Apples", 1, Seller4, "new", Guid.NewGuid()),
            new Product($"{nameof(Seller4)}_Product2", "Pears", 1, Seller4, "new", Guid.NewGuid())
        };


        public static readonly List<BuyerProduct> BuyerProducts = new List<BuyerProduct>(){
            new BuyerProduct(BuyerProduct.RelationType.Favorite, Buyer4, Products[0])
        };


        public static readonly User User1 = new User("user1", "psw", Guid.NewGuid(), Buyer1, Seller1);
        public static readonly User User2 = new User("user2", "psw", Guid.NewGuid(), Buyer2, Seller3);
        public static readonly User User3 = new User("user3", "psw", Guid.NewGuid(), Buyer3, Seller4);
        public static readonly User User4 = new User("user4", "psw", Guid.NewGuid(), Buyer4, Seller2);

        public static readonly List<User> Users = new List<User> { User1, User2, User3, User4 };
    }
}
