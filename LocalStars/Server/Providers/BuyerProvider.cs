using Models;
using Server.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Providers
{
    public class BuyerProvider
    {
        public Buyer GetById(Guid id)
        {
            return MockData.s_buyers.Single(b => b.Id == id);
        }

        public void Insert(Buyer buyer)
        {
            if (MockData.s_buyers.Any(b => b.Id == buyer.Id))
            {
                throw new ConflictException("Buyer id already exists");
            }
            MockData.s_buyers.Add(buyer);
        }

        public void Remove(Guid id)
        {
            MockData.s_buyers.RemoveAll(b => b.Id == id);
        }

        public void Update(Buyer buyer)
        {
            Remove(buyer.Id);
            Insert(buyer);
        }
    }
}
