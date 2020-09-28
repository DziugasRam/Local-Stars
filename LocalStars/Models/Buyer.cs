using System;

namespace Models
{
    public class Buyer : Identifiable
    {
        public Buyer(string firstName, string lastName, Guid id) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }
}
