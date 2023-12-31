﻿using Casgem.DataAccessLayer.Abstract;
using Casgem.DataAccessLayer.Concrete.Context;
using Casgem.DataAccessLayer.Repositories;
using Casgem.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DataAccessLayer.Concrete.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(ApiContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            using (var context = new ApiContext())
            {
                return context.Products.Include(x=>x.Category).ToList();
            }
           
        }
    }
}
