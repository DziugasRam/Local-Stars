using System;

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
    }
}
