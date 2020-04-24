using System;
using System.Collections.Generic;
using System.Text;
using AAA.Core.DataAccess;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //Custom Operations
        //void Delete(int productId);
    }
}
