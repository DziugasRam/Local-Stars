using System;

namespace Models
{
    public class Seller : Identifiable
    {
        public Seller(string firstName, string lastName, Guid id, Location location) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Location = location;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public Location Location { get; }
    }
}
