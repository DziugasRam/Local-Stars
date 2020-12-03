using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Exceptions;

namespace Server.Providers
{
    public class UserProvider : ControllerBase
    {
        private readonly DataContext _context;

        public UserProvider(DataContext context)
        {
            _context = context;
        }

        public User GetUser(string username, string password)
        {
            var matchingUsers = _context.Users.Where(u => u.UserName == username && u.Password == password).ToList();

            return matchingUsers.Count switch
            {
                0 => null,
                1 => matchingUsers.First(),
                _ => throw new ConflictException("More than 1 user with matching Username and Password found")
            };
        }

        public User GetUser(string username)
        {
            var matchingUsers = _context.Users.Where(u => u.UserName == username).ToList();

            return matchingUsers.Count switch
            {
                0 => null,
                1 => matchingUsers.First(),
                _ => throw new ConflictException("More than 1 user with matching Username found")
            };
        }

        public User GetUser(Guid id)
        {
            return _context.Users.Single(u => u.Id == id);
        }

        public User AddUser(string username, string password)
        {
            User addedUser;
            // TODO: make sure db field is unique
            if (GetUser(username) == null)
            {
                addedUser = new User(username, password, Guid.NewGuid(), null, null);
                _context.Users.Add(addedUser);
                _context.SaveChanges();
            }
            else
            {
                throw new ConflictException("User with this Username already exists");
            }
            return addedUser;
        }

        public void LinkToBuyer(Guid userId, Guid buyerId)
        {
            GetUser(userId).AssociatedBuyer = _context.Buyers.Single(b => b.Id == buyerId);
            _context.SaveChanges();
        }

        public void LinkToSeller(Guid userId, Guid sellerId)
        {
            GetUser(userId).AssociatedSeller = _context.Sellers.Single(s => s.Id == sellerId);
            _context.SaveChanges();
        }
    }
}
