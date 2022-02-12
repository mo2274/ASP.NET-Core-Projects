using System.Collections.Generic;
using System.Linq;

namespace Pie2Shop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>()
            {
                new Pie() {PieId = 1, Name = "StrawBerry Pie", Price = 15.95M, ShortDescription = "hhhhhhhhhhhhhhhhhhhhh",
                    ImageThumbnailUrl = "/Images/carousel2.jpg",
                    Category = new Category() { CategoryId = 1, Name = "Fruits pies", Description = "All-fruity pies"}},
                new Pie() {PieId = 2, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "hhhhhhhhhhhhhhhhhhhhhhhhh",
                      ImageThumbnailUrl = "/Images/carousel2.jpg",
                    Category = new Category() { CategoryId = 1, Name = "Fruits pies", Description = "All-fruity pies"}},
                new Pie() {PieId = 3, Name = "Prubrab Pie", Price = 15.95M, ShortDescription = "hhhhhhhhhhhhhhhhhhhhhhhhh",
                      ImageThumbnailUrl = "/Images/carousel2.jpg",
                    Category = new Category() { CategoryId = 1, Name = "Fruits pies", Description = "All-fruity pies"}},
                new Pie() {PieId = 4, Name = "Pumpkin Pie", Price = 12.95M, ShortDescription = "hhhhhhhhhhhhhhhhhhhhhhhh",
                      ImageThumbnailUrl = "/Images/carousel2.jpg",
                    Category = new Category() { CategoryId = 1, Name = "Fruits pies", Description = "All-fruity pies"}}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(pie => pie.PieId == pieId);
        }

        public Pie GetPieByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Pie> GetPiesByCategory(int CategoryId)
        {
            throw new System.NotImplementedException();
        }
    }
}
