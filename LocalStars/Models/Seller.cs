using System;

namespace Models
{
    public class Seller : IIdentifiable
    {
        public Seller(string firstName, string lastName, Location location, Guid id)
        {
            FirstName = firstName;
            LastName = lastName;
            Location = location;
            Id = id;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public Location Location { get; }
        public Guid Id { get; }
        public Guid GetId()
        {
            return Id;
        }
    }
}
