using System;
using System.Collections.Generic;
using System.Text;
using AAA.Core.DataAccess.EntityFramework;
using AAA.Northwind.DataAccess.Abstract;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
