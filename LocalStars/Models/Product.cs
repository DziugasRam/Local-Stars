using System;
using System.Collections;

namespace Models
{
    public class Product : IIdentifiable
    {
        public Product(string title, int price, Guid sellerId, string description, Guid id)
        {
            Title = title;
            Price = price;
            SellerId = sellerId;
            Description = description;
            Id = id;
        }

        public string Title { get; }
        public int Price { get; }
        public Guid SellerId { get; }
        public string Description { get; }
        public Guid Id { get; }
        public Guid GetId()
        {
            return Id;
        }
    }
}
