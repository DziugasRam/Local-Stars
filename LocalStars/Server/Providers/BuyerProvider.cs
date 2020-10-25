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
        private readonly DataContext _context;

        public BuyerProvider(DataContext context)
        {
            _context = context;
        }

        public Buyer GetById(Guid id)
        {
            return _context.Buyers.Single(b => b.Id == id);
        }

        public void Insert(Buyer buyer)
        {
            if (_context.Buyers.Any(b => b.Id == buyer.Id))
            {
                throw new ConflictException("Buyer id already exists");
            }
            _context.Buyers.Add(buyer);
        }

        public void Remove(Guid id)
        {
            _context.Buyers.RemoveRange(_context.Buyers.Where(b => b.Id == id));
        }

        public void Update(Buyer buyer)
        {
            Remove(buyer.Id);
            Insert(buyer);
        }

        public void AddLikedProduct(Guid id, Product product)
        {
            //var buyer = GetById(id);
            //buyer.BuyerProducts.Add(new BuyerProduct(BuyerProduct.RelationType.Favorite, Guid.NewGuid(), product));
            //_context.SaveChanges();
        }

        public void RemoveLikedProduct(Guid id, Product product)
        {
            //var buyer = GetById(id);
            //buyer.BuyerProducts.Remove(new BuyerProduct(BuyerProduct.RelationType.Favorite, Guid.NewGuid(), product));
            //_context.SaveChanges();
        }
    }
}
