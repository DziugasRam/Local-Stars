using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class BuyerProduct
    {
        public BuyerProduct()
        {
        }

        public BuyerProduct(RelationType type, Guid id, Product product)
        {
            Type = type;
            Id = id;
            Product = product;
        }

        public enum RelationType
        {
            Favorite,
            ShoppingCart
        }

        public RelationType Type { get; set; }
        public Guid Id { get; set; }
        public virtual Product Product { get; set; }
    }
}
