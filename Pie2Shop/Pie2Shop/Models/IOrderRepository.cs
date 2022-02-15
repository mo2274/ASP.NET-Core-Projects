using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
