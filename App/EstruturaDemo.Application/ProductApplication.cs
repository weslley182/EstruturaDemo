using EstruturaDemo.Domain.Entities;
using EstruturaDemo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDemo.Application
{
    public class ProductApplication: ApplicationBase
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Register(Product product)
        {
            BeginTransaction();

            _productRepository.Add(product);

            Commit();
        }
    }
}
