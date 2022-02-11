using Microsoft.AspNetCore.Mvc;
using Pie2Shop.Models;
using Pie2Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.ViewComponents
{
    public class ShoppingCartSummery : ViewComponent
    {
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartSummery(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetCartTotal()
            };

            return View(shoppingCartViewModel);
        }
    }
}
