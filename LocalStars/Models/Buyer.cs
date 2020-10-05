using System;

namespace Models
{
    public class Buyer : IIdentifiable
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
    }
}
