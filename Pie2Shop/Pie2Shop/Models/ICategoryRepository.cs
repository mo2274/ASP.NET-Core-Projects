using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pie2Shop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
