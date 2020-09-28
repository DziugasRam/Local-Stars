using System;

namespace Models
{
    public class Seller
    {
        public Seller(string firstName, string lastName, Guid id, Location location)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Location = location;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public Guid Id { get; }
        public Location Location { get; }

        public override bool Equals(object obj)
        {
            if (!(obj is Seller seller))
                return false;

            return seller.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
