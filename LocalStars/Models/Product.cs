﻿using System;
using System.Collections;

namespace Models
{
    public class Product : IIdentifiable
    {
        public Product()
        {
        }

        public Product(string title, string category, int price, Seller seller, string description, Guid id)
        {
            Title = title;
            Category = category;
            Price = price;
            Seller = seller;
            Description = description;
            Id = id;
        }

        public string Title { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public virtual Seller Seller { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
    }
}
