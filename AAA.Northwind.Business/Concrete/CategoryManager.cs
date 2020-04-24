using System;
using System.Collections.Generic;
using System.Text;
using AAA.Northwind.Business.Abstact;
using AAA.Northwind.DataAccess.Abstract;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
