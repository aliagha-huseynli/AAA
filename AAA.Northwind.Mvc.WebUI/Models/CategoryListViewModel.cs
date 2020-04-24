using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.Mvc.WebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
