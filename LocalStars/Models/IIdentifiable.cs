using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IIdentifiable
    {
        public Guid Id { get; }
    }

    public class IdentifiableComparer: IEqualityComparer<IIdentifiable>
    {
        public bool Equals(IIdentifiable item1, IIdentifiable item2)
        {
            return item1.Id == item2.Id;
        }

        public int GetHashCode(IIdentifiable item)
        {
            return item.Id.GetHashCode();
        }
    }
}
