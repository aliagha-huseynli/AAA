using System;
using System.Collections.Generic;
using System.Text;
using AAA.Northwind.Entities.Concrete;

namespace AAA.Northwind.Business.Abstact
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
