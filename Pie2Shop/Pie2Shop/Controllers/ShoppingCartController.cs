using Microsoft.AspNetCore.Mvc;
using Pie2Shop.Models;
using Pie2Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPieRepository pieRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(IPieRepository pieRepository, ShoppingCart shoppingCart)
        {
            this.pieRepository = pieRepository;
            this.shoppingCart = shoppingCart;
        }

        public IActionResult Index()
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

        public IActionResult AddToShoppingCart(int pieId)
        {
            var pie = pieRepository.GetPieById(pieId);

            if (pie == null)
                return BadRequest();

            shoppingCart.AddToCart(pie, 1);

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int pieId)
        {
            var pie = pieRepository.GetPieById(pieId);

            if (pie == null)
                return BadRequest();

            shoppingCart.RemoveFromCart(pie);

            return RedirectToAction("Index");
        }
    }
}
