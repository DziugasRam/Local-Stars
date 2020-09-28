using System;

namespace Models
{
    public class Buyer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Guid Id { get; }

        public Buyer(string firstName, string lastName, Guid id) =>
            (FirstName, LastName, Id) =
            (firstName, lastName, id);

        public override bool Equals(object obj)
        {
            if (!(obj is Buyer buyer))
                return false;

            return buyer.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
