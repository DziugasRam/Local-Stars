using Models;
using System;
using System.Collections.Generic;

namespace Server
{
    static class MockData
    {
        public static readonly Seller Seller1 = new Seller(nameof(Seller1), $"{nameof(Seller1)}_lastName", new Guid(), new Location());
        public static readonly Seller Seller2 = new Seller(nameof(Seller2), $"{nameof(Seller2)}_lastName", new Guid(), new Location());
        public static readonly Seller Seller3 = new Seller(nameof(Seller3), $"{nameof(Seller3)}_lastName", new Guid(), new Location());
        public static readonly Seller Seller4 = new Seller(nameof(Seller4), $"{nameof(Seller4)}_lastName", new Guid(), new Location());

        public static readonly IEnumerable<Seller> s_sellers = new List<Seller> { Seller1, Seller2, Seller3, Seller4 };

        public static readonly Buyer Buyer1 = new Buyer(nameof(Buyer1), $"{nameof(Buyer1)}_lastName", new Guid());
        public static readonly Buyer Buyer2 = new Buyer(nameof(Buyer2), $"{nameof(Buyer2)}_lastName", new Guid());
        public static readonly Buyer Buyer3 = new Buyer(nameof(Buyer3), $"{nameof(Buyer3)}_lastName", new Guid());
        public static readonly Buyer Buyer4 = new Buyer(nameof(Buyer4), $"{nameof(Buyer4)}_lastName", new Guid());

        public static readonly IEnumerable<Buyer> s_buyers = new List<Buyer> { Buyer1, Buyer2, Buyer3, Buyer4 };

        public static readonly IEnumerable<Product> s_products = new List<Product> {
            new Product($"{nameof(Seller1)}_Product1", 1, Seller1.Id),
            new Product($"{nameof(Seller1)}_Product3", 1, Seller1.Id),
            new Product($"{nameof(Seller1)}_Product2", 1, Seller1.Id),
            new Product($"{nameof(Seller2)}_Product1", 1, Seller2.Id),
            new Product($"{nameof(Seller2)}_Product2", 1, Seller2.Id),
            new Product($"{nameof(Seller4)}_Product1", 1, Seller4.Id),
            new Product($"{nameof(Seller4)}_Product2", 1, Seller4.Id)
        };
    }
}
