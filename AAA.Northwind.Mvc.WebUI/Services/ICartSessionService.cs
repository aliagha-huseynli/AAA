using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.Mvc.WebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
