using System.Collections.Generic;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.Mvc.WebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}