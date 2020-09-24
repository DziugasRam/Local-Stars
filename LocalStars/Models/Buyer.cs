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
    }
}
