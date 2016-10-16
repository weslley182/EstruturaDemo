using EstruturaDemo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstruturaDemo.Domain.Entities;

namespace EstruturaDemo.Infra.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return Context.Products.Where(p => p.Price == price);
        }
    }
}
