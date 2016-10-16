using EstruturaDemo.Domain.Interfaces;
using System.Collections.Generic;
using EstruturaDemo.Domain.Entities;

namespace EstruturaDemo.Infra.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByPrice(decimal price)
        {
            //return Context.Products.Where(p => p.Price == price);
            return null;
        }
    }
}
