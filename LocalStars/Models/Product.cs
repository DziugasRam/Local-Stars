using System;
using System.Collections;

namespace Models
{
    public class Product : IIdentifiable
    {
        public Product(string title, string category, int price, Guid sellerId, Guid id, string description)
        {
            Title = title;
            Category = category;
            Price = price;
            SellerId = sellerId;
            Description = description;
            Id = id;
        }

        public string Title { get; }
        public int Price { get; }
        public string Category { get; }
        public Guid SellerId { get; }
        public string Description { get; }
        public Guid Id { get; }
    }
}
