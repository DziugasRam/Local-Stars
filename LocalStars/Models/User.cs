using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        public User(string userName, string password, Guid? associatedBuyer, Guid? associatedSeller, Guid id)
        {
            UserName = userName;
            Password = password;
            AssociatedBuyer = associatedBuyer;
            AssociatedSeller = associatedSeller;
            Id = id;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid? AssociatedBuyer { get; set; }
        public Guid? AssociatedSeller { get; set; }
        public Guid Id { get; set; }
    }
}
