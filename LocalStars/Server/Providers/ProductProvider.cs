using Models;
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

        public IEnumerable<Product> Get()
        {
            return _context.Products.AsEnumerable();
        }

        public IEnumerable<Product> GetByTitle(string title, bool fullMatch = true, StringComparison comparisonType = StringComparison.Ordinal)
        {
            if (title == null || title == string.Empty)
            {
                return new List<Product>();
            }
            return _context.Products
                .Where(p => fullMatch ? string.Equals(p.Title, title, comparisonType) : p.Title.Contains(title, comparisonType));
        }

        public IEnumerable<Product> GetByType(string category, bool fullMatch = true, StringComparison comparisonType = StringComparison.Ordinal)
        {
            if (category == null || category == string.Empty)
            {
                return new List<Product>();
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
                new IdentifiableComparer());
        }

        public void RemoveById(IEnumerable<Guid> ids)
        {
            var idsHashSet = ids.ToHashSet();
            _context.Products.RemoveRange(_context.Products.Where(p => idsHashSet.Contains(p.Id)));
            _context.SaveChanges();
        }

        public void Insert(IEnumerable<Product> products)
        {
            _context.Products.AddRange(products);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            RemoveById(new[] { product.Id });
            Insert(new[] { product });
        }
    }
}
