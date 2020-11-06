using System;
using System.Collections;

namespace Models
{
    public class Product : IIdentifiable<Guid>, IEquatable<Product>
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

        public bool Equals(Product product)
        {
            return
                Title == product.Title
                && Category == product.Category
                && Price == product.Price
                && Description == product.Description
                && Seller.Id == product.Seller.Id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Product);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Category, Price, Description, Seller.Id);
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Product p1, Product p2)
        {
            return !p1.Equals(p2);
        }
    }
}
