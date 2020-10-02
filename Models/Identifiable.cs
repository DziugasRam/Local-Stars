using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Identifiable
    {
        protected Identifiable(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }

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
