using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IIdentifiable<T>
    {
        public T Id { get; }
    }

    public class IdentifiableComparer<T>: IEqualityComparer<IIdentifiable<T>>
    {
        public bool Equals(IIdentifiable<T> item1, IIdentifiable<T> item2)
        {
            return Equals(item1.Id, item2.Id);
        }

        public int GetHashCode(IIdentifiable<T> item)
        {
            return item.Id.GetHashCode();
        }
    }
}
