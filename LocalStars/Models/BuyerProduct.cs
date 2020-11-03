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

        public BuyerProduct(RelationType type, Buyer buyer, Product product)
        {
            Type = type;
            Buyer = buyer;
            Product = product;

        }

        public enum RelationType
        {
            Favorite,
            ShoppingCart
        }

        public RelationType Type { get; set; }
        public Guid ProductId { get; set; }
        public Guid BuyerId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Buyer Buyer { get; set; }
    }
}
