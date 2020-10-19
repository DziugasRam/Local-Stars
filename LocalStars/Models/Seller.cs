using System;

namespace Models
{
    public class Seller : IIdentifiable
    {
        public Seller(string firstName, string lastName, string phoneNumber, Location location, Guid id)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Location = location;
            Id = id;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string PhoneNumber { get; }
        public Location Location { get; }
        public Guid Id { get; }
    }
}
