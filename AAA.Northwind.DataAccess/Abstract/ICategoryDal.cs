using AAA.Core.DataAccess;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        //Custom Operations
    }
}