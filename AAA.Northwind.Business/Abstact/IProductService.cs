using System;
using System.Collections.Generic;
using System.Text;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.Business.Abstact
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetById(int productId);
    }
}
