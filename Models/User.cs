using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User : Identifiable
    {
        public User(string userName, string password, Guid? associatedBuyer, Guid? associatedSeller, Guid id) : base(id)
        {
            UserName = userName;
            Password = password;
            AssociatedBuyer = associatedBuyer;
            AssociatedSeller = associatedSeller;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid? AssociatedBuyer { get; set; }
        public Guid? AssociatedSeller { get; set; }
    }
}
