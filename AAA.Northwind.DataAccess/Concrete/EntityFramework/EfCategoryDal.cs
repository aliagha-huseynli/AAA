using AAA.Core.DataAccess.EntityFramework;
using AAA.Northwind.DataAccess.Abstract;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {

    }
}