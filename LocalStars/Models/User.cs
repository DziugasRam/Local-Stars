using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User : IIdentifiable
    {
        public User()
        {
        }

        public User(string userName, string password, Guid id, Buyer associatedBuyer, Seller associatedSeller)
        {
            UserName = userName;
            Password = password;
            Id = id;
            AssociatedBuyer = associatedBuyer;
            AssociatedSeller = associatedSeller;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid Id { get; set;  }
        public virtual Buyer AssociatedBuyer { get; set; }
        public virtual Seller AssociatedSeller { get; set; }
    }
}
