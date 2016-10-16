using EstruturaDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDemo.Infra.Repository.EF
{
    public class ProductMap: EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.Price).IsRequired().HasPrecision(10, 2);
        }
    }
}
