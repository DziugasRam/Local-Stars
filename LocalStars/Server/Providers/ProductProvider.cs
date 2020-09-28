using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Providers
{
    public class ProductProvider
    {
        public IEnumerable<Product> GetById(IEnumerable<Guid> ids)
        {
            return ids.Join(
                MockData.s_products,
                id => id,
                p => p.Id,
                (id, p) => p);
        }

        public IEnumerable<Product> GetByTitle(string title, bool fullMatch = true, StringComparison comparisonType = StringComparison.Ordinal)
        {
            if(title == null || title == string.Empty)
            {
                return new List<Product>();
            }

            return MockData.s_products.Where(p => fullMatch
                ? string.Equals(p.Title, title, comparisonType)
                : p.Title.Contains(title, comparisonType));
        }

        public IEnumerable<Product> GetBySeller(IEnumerable<Guid> ids)
        {
            return ids.Join(
                MockData.s_products,
                id => id,
                p => p.SellerId,
                (id, p) => p);
        }

        public void RemoveById(IEnumerable<Guid> ids)
        {
            var idsHashSet = ids.ToHashSet();
            MockData.s_products.RemoveAll(p => idsHashSet.Contains(p.Id));
        }

        public void Insert(IEnumerable<Product> products)
        {
            MockData.s_products.AddRange(products);
        }

        public void Update(Product product)
        {
            MockData.s_products.RemoveAll(p => p.Id == product.Id);
            MockData.s_products.Add(product);
        }
    }
}
