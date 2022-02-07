using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.Models
{
    public class CategoryRepositorySqlServer : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepositorySqlServer(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => appDbContext.Categories;
    }
}
