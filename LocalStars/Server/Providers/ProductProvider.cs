﻿using Models;
using Server.Controllers.Models;
using Server.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Providers
{
    public class ProductProvider
    {
        private readonly DataContext _context;

        public ProductProvider(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetById(IEnumerable<Guid> ids)
        {
            return ids.Join(
                _context.Products,
                id => id,
                p => p.Id,
                (id, p) => p);
        }

        public int CountProducts()
        {
            return _context.Products.Count();
        }

        public IEnumerable<ProductModel> Get()
        {
            return _context.Products.Select(x => new ProductModel()
            {
                Title = x.Title,
                Price = x.Price,
                Seller = x.Seller,
                Category = x.Category,
                Description = x.Description,
                Id = x.Id,
                Image = Convert.ToBase64String(x.Image, 0, x.Image.Length)
            }).ToList();
        }

        public IEnumerable<ProductModel> GetPage(int page)
        {
            int pageSize = 8;

           return  _context.Products.Select(x => new ProductModel()
            {
                Title = x.Title,
                Price = x.Price,
                Seller = x.Seller,
                Category = x.Category,
                Description = x.Description,
                Id = x.Id,
                Image = Convert.ToBase64String(x.Image, 0, x.Image.Length)
            }).ToList().Skip((page - 1) * pageSize).Take(pageSize);
        }

        public IEnumerable<Product> GetByTitle(string title, bool fullMatch = true, StringComparison comparisonType = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(title))
            {
                return _context.Products.AsEnumerable();
            }
            return _context.Products
                .Where(p => fullMatch ? string.Equals(p.Title, title, comparisonType) : p.Title.Contains(title, comparisonType));
        }

        public IEnumerable<Product> GetSorted(string variant)
        {
            var sortedProducts = variant switch
            {
                "Price: Lowest First" => _context.Products.AsEnumerable().OrderBy(o => o.Price),
                "Price: Highest First" => _context.Products.AsEnumerable().OrderByDescending(o => o.Price),
                "A-Z" => _context.Products.AsEnumerable().OrderBy(o => o.Title),
                "Z-A" => _context.Products.AsEnumerable().OrderByDescending(o => o.Title),
                _ => _context.Products.AsEnumerable()
            };

            return sortedProducts;
        }

        public IEnumerable<Product> GetByType(string category, bool fullMatch = true, StringComparison comparisonType = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(category))
            {
                return _context.Products.AsEnumerable();
            }

            return _context.Products
                .Where(product => fullMatch ? string.Equals(product.Category, category, comparisonType) : product.Category.Contains(category, comparisonType));
        }

        public IEnumerable<ProductsForSeller> GetBySeller(IEnumerable<Seller> sellers)
        {
            return sellers.GroupJoin(
                _context.Products,
                seller => seller,
                product => product.Seller,
                (seller, products) => new ProductsForSeller(seller, products.ToArray()),
                new IdentifiableComparer<Guid>());
        }

        public void RemoveById(IEnumerable<Guid> ids)
        {
            var idsHashSet = ids.ToHashSet();
            _context.Products.RemoveRange(_context.Products.Where(p => idsHashSet.Contains(p.Id)));
            _context.SaveChanges();
        }

        public void Insert(Product product)
        {
            _context.Products.AddRange(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            RemoveById(new[] { product.Id });
            Insert( product );
        }
    }
}
