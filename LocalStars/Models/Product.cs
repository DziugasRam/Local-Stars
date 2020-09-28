using System;
using System.Collections;

namespace Models
{
    public class Product : Identifiable
    {
        public Product(string title, int price, Guid sellerId, Guid id) : base(id)
        {
            Title = title;
            Price = price;
            SellerId = sellerId;
        }

        public string Title { get; }
        public int Price { get; }
        public Guid SellerId { get; }
    }
}
