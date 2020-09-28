using System;
using System.Collections;

namespace Models
{
    public class Product
    {
        public string Title { get; }
        public int Price { get; }
        public Guid SellerId { get; }
        public Guid Id { get; }

        public Product(string title, int price, Guid sellerId, Guid id) =>
            (Title, Price, SellerId, Id) =
            (title, price, sellerId, id);

        public override bool Equals(object obj)
        {
            if (!(obj is Product product))
                return false;

            return product.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
