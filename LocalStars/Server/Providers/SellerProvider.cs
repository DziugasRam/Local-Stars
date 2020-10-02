using Models;
using Server.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Providers
{
    public class SellerProvider
    {
        public IEnumerable<Seller> GetById(IEnumerable<Guid> ids)
        {
            return ids.Join(
                MockData.s_sellers,
                id => id,
                s => s.Id,
                (id, s) => s);
        }

        public void Insert(Seller seller)
        {
            if (MockData.s_sellers.Any(b => b.Id == seller.Id))
            {
                throw new ConflictException("Buyer id already exists");
            }
            MockData.s_sellers.Add(seller);
        }

        public void Remove(Guid id)
        {
            MockData.s_sellers.RemoveAll(b => b.Id == id);
        }

        public void Update(Seller seller)
        {
            Remove(seller.Id);
            Insert(seller);
        }
    }
}
