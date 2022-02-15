using Microsoft.AspNetCore.Mvc;
using Pie2Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository orderRepository;
        private readonly ShoppingCart shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            this.orderRepository = orderRepository;
            this.shoppingCart = shoppingCart;
        }

        [HttpGet]
        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            if (shoppingCart.GetShoppingCartItems().Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add pies first");
            }

            if (!ModelState.IsValid)
                return View(order);

            orderRepository.CreateOrder(order);
            shoppingCart.ClearCart();

            return RedirectToAction("CheckOutComplete");
        }

        public IActionResult CheckOutComplete()
        {
            return View("CheckOutComplete","Thanks for your order");
        }
    }
}
