using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly ShoppingCart shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            this.appDbContext = appDbContext;
            this.shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            appDbContext.Orders.Add(order);

            var shopingCartItems = shoppingCart.ShoppingCartItems;

            foreach (var shopingCartItem in shopingCartItems)
            {
                var OrderDetail = new OrderDetails()
                {
                    Amount = shopingCartItem.Amount,
                    PieId = shopingCartItem.Pie.PieId,
                    OrderId = order.Id,
                    Price = shopingCartItem.Pie.Price
                };

                appDbContext.OrderDetails.Add(OrderDetail);
            }

            appDbContext.SaveChanges();
        }
    }
}
