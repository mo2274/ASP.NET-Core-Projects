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

        public IActionResult CheckOut()
        {
            var order = new Order();

            return View(order);
        }

        public IActionResult Create(Order order)
        {
            orderRepository.CreateOrder(order);
            return View();
        }
    }
}
