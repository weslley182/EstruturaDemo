﻿using EstruturaDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDemo.Domain.Interfaces
{
    public interface IProductRepository: IRepositoryBase<Product>
    {
        IEnumerable<Product> GetByPrice(decimal price);
    }
}
