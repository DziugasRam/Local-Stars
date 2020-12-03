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
        private readonly DataContext _context;

        public SellerProvider(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Seller> GetById(IEnumerable<Guid> ids)
        {
            return ids.Join(
                _context.Sellers,
                id => id,
                s => s.Id,
                (id, s) => s);
        }

        public Seller Insert(string firstName, string lastName, string phoneNumber, string address, double longitude, double latitude)
        {
            var seller = new Seller(firstName, lastName, phoneNumber, longitude, latitude, address, Guid.NewGuid());
            if (_context.Sellers.Any(b => b.Id == seller.Id))
            {
                throw new ConflictException("Buyer id already exists");
            }
            _context.Sellers.Add(seller);
            _context.SaveChanges();
            return seller;
        }

        public void Remove(Guid id)
        {
            _context.Sellers.RemoveRange(_context.Sellers.Where(b => b.Id == id));
        }

        //public void Update(Seller seller)
        //{
        //    Remove(seller.Id);
        //    Insert(seller);
        //}
    }
}
