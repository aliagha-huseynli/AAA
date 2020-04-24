using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.Mvc.WebUI.Models
{
    public class ProductListViewModel
    {
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public List<Product> Products { get; internal set; }
    }
}
