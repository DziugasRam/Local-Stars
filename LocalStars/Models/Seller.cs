using System;

namespace Models
{
    public class Seller : Locatable, IIdentifiable<Guid>
    {
        public Seller()
        {
        }

        public Seller(string firstName, string lastName, string phoneNumber, double longitude, double latitude, string address, Guid id)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Longitude = longitude;
            Latitude = latitude;
            Address = address;
            Id = id;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public override double Longitude { get; set; }
        public override double Latitude { get; set; }
        public override string Address { get; set; }
        public Guid Id { get; set; }
    }
}
