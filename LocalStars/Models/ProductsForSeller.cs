using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ProductsForSeller
    {
        public ProductsForSeller(Guid sellerId, IEnumerable<Product> products)
        {
            SellerId = sellerId;
            Products = products;
        }

        public Guid SellerId { get; }
        public IEnumerable<Product> Products { get; }
    }
}
