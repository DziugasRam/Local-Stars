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
            return MockData.Buyers.Single(b => b.Id == id);
        }

        public void Insert(Buyer buyer)
        {
            if (MockData.Buyers.Any(b => b.Id == buyer.Id))
            {
                throw new ConflictException("Buyer id already exists");
            }
            MockData.Buyers.Add(buyer);
        }

        public void Remove(Guid id)
        {
            MockData.Buyers.RemoveAll(b => b.Id == id);
        }

        public void Update(Buyer buyer)
        {
            Remove(buyer.Id);
            Insert(buyer);
        }


        public void AddLikedProduct(Guid id,Product product)
        {
            GetById(id).FavoriteProducts.Add(product);
        }

        public void RemoveLikedProduct(Guid id, Product product)
        {
            GetById(id).FavoriteProducts.Remove(product);
        }
    }
}
