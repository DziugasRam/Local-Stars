using System;

namespace Models
{
    public class Seller
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Guid Id { get; }
        public Location Location { get; }

        public Seller(string firstName, string lastName, Guid id, Location location) =>
            (FirstName, LastName, Id, Location) =
            (firstName, lastName, id, location);
    }
}
