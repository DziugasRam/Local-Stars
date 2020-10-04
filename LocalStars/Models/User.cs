using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User : IIdentifiable
    {
        public User(string userName, string password, Guid id, Guid? associatedBuyer, Guid? associatedSeller)
        {
            UserName = userName;
            Password = password;
            Id = id;
            AssociatedBuyer = associatedBuyer;
            AssociatedSeller = associatedSeller;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid Id { get; }
        public Guid GetId()
        {
            return Id;
        }
        public Guid? AssociatedBuyer { get; set; }
        public Guid? AssociatedSeller { get; set; }
    }
}
