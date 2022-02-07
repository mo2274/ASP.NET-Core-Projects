using System.Collections.Generic;

namespace Pie2Shop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; } =
            new List<Category>()
            {
                new Category() { CategoryId = 1, Name = "Fruits pies", Description = "All-fruity pies"},
                new Category() { CategoryId = 2, Name = "Cheese cakes", Description = "Cheesy all the way"},
                new Category() { CategoryId = 3, Name = "Seasonal Pies", Description = "Get in the mood for a seasonal pie"}
            };
    }
}
