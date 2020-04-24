using System.Collections.Generic;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.Business.Abstact
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}