using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Models
{
    public class Buyer : IIdentifiable
    {
        public Buyer(string firstName, string lastName, Guid id,List<Product> favoriteProducts)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            FavoriteProducts = favoriteProducts;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public Guid Id { get; }
        public List<Product> FavoriteProducts { get; set; }
    }
}
