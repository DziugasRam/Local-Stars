using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Models
{
    public class Buyer : IIdentifiable
    {
        public Buyer()
        {
        }

        public Buyer(string firstName, string lastName, Guid id, List<BuyerProduct> buyerProducts)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            BuyerProducts = buyerProducts;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Id { get; set; }
        public virtual List<BuyerProduct> BuyerProducts { get; set; }
    }
}
