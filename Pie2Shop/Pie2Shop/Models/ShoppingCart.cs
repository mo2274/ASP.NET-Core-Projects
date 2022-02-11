using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pie2Shop.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }


        public ShoppingCart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Pie pie, int amount)
        {
            var shoppingCartItem =
                appDbContext.ShoppingCartItems.
                SingleOrDefault(s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    Pie = pie,
                    Amount = amount,
                    ShoppingCartId = ShoppingCartId
                };

                appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Pie pie)
        {
            var shoppingCartItem =
                appDbContext.ShoppingCartItems
                .Where(i => i.Pie.PieId == pie.PieId && i.ShoppingCartId == ShoppingCartId)
                .SingleOrDefault();

            int localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }

                appDbContext.SaveChanges();
            }

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? 
                ( 
                    ShoppingCartItems =
                        appDbContext.ShoppingCartItems
                                    .Where(i => i.ShoppingCartId == ShoppingCartId)
                                    .Include(i => i.Pie)
                                    .ToList()
                );
        }

        public void ClearCart()
        {
            var items = appDbContext.ShoppingCartItems.Where(i => i.ShoppingCartId == ShoppingCartId);
            appDbContext.ShoppingCartItems.RemoveRange(items);
            appDbContext.SaveChanges();
        }

        public decimal GetCartTotal()
        {
            var total = appDbContext.ShoppingCartItems
                .Where(i => i.ShoppingCartId == ShoppingCartId)
                .Sum(i => i.Pie.Price * i.Amount);

            return total;
        }
    }
}
