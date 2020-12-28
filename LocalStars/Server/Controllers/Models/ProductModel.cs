﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }

        public ProductModel(string title, string category, int price, Seller seller, string description, Guid id, string image = default)
        {
            Title = title;
            Category = category;
            Price = price;
            Seller = seller;
            Description = description;
            Id = id;
            Image = image;
        }

        public string Image { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public virtual Seller Seller { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
    }
}
