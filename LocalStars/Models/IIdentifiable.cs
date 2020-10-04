using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IIdentifiable
    {
        public Guid GetId();
    }

    public class IdentifiableComparer: IEqualityComparer<IIdentifiable>
    {
        public bool Equals(IIdentifiable item1, IIdentifiable item2)
        {
            return item1.GetId() == item2.GetId();
        }

        public int GetHashCode(IIdentifiable item)
        {
            return item.GetId().GetHashCode();
        }
    }
}
