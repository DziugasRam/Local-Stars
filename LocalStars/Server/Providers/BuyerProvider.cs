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

        public Buyer Insert(string firstName, string lastName)
        {
            var buyer = new Buyer(firstName, lastName, Guid.NewGuid(), new List<BuyerProduct>());

            if (_context.Buyers.Where(b => b.Id == buyer.Id).Count() > 0)
            {
                throw new ConflictException("Buyer id already exists");
            }
            _context.Buyers.Add(buyer);
            _context.SaveChanges();
            return buyer;
        }

        public void Remove(Guid id)
        {
            _context.Buyers.RemoveRange(_context.Buyers.Where(b => b.Id == id));
        }

        //public void Update(Buyer buyer)
        //{
        //    Remove(buyer.Id);
        //    Insert(buyer);
        //}

        public void AddLikedProduct(Guid id, Product product)
        {
            var buyer = GetById(id);
            buyer.BuyerProducts.Add(new BuyerProduct(BuyerProduct.RelationType.Favorite, buyer, product));
            _context.SaveChanges();
        }

        public void RemoveLikedProduct(Guid id, Product product)
        {
            var buyer = GetById(id);
            var buyerProduct = buyer.BuyerProducts.First(bp => bp.ProductId == product.Id);
            buyer.BuyerProducts.Remove(buyerProduct);
            _context.SaveChanges();
        }

        public bool IsLikedProduct(Guid id, Product product)
        {
            var buyer = GetById(id);
            return buyer.BuyerProducts.Any(bp => bp.Type == BuyerProduct.RelationType.Favorite && bp.ProductId == product.Id);
        }
    }
}
