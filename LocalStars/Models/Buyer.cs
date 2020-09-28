using System;

namespace Models
{
    public class Buyer
    {
        public Buyer(string firstName, string lastName, Guid id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public Guid Id { get; }

        public override bool Equals(object obj)
        {
            if (!(obj is Buyer buyer))
                return false;

            return buyer.Id == Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
