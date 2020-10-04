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
                MockData.Sellers,
                id => id,
                s => s.Id,
                (id, s) => s);
        }

        public void Insert(Seller seller)
        {
            if (MockData.Sellers.Any(b => b.Id == seller.Id))
            {
                throw new ConflictException("Buyer id already exists");
            }
            MockData.Sellers.Add(seller);
        }

        public void Remove(Guid id)
        {
            MockData.Sellers.RemoveAll(b => b.Id == id);
        }

        public void Update(Seller seller)
        {
            Remove(seller.Id);
            Insert(seller);
        }
    }
}
