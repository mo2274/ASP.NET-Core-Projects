using System.Collections.Generic;

namespace Pie2Shop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; } =
            new List<Category>()
            {
                new Category() { CategoryId = 1, Name = "Fruits pies", Descriprion = "All-fruity pies"},
                new Category() { CategoryId = 2, Name = "Cheese cakes", Descriprion = "Cheesy all the way"},
                new Category() { CategoryId = 3, Name = "Seasonal Pies", Descriprion = "Get in the mood for a seasonal pie"}
            };
    }
}
