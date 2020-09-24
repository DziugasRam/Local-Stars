using System;

namespace Models
{
    public class Product
    {
        public string Title { get; }
        public int Price { get; }
        public Guid SellerId { get; }

        public Product(string title, int price, Guid sellerId) =>
            (Title, Price, SellerId) =
            (title, price, sellerId);
    }
}
