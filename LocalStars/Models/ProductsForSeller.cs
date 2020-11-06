using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class ProductsForSeller
    {
        public Product this[int index] => Products[index];
        public int Length { 
            get {
                return Products.Length;
            }
        }

        public ProductsForSeller(Seller seller, Product[] products)
        {
            Seller = seller;
            Products = products;
        }
        public Seller Seller { get; }
        public Product[] Products { get; }
    }
}
