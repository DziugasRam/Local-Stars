using System;


namespace Models
{
    public class Product
    {
        public string Title { get; }
        public int Price { get; }

        public string Category { get; }

        public string Description { get; }
        public Guid SellerId { get; }

        public Product(string title, int price, string category, string description, Guid sellerId) =>
            (Title, Price, Category, Description, SellerId) =
            (title, price, category, description, sellerId);

    
    }
}
