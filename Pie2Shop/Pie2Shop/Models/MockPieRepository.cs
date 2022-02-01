﻿using System.Collections.Generic;
using System.Linq;

namespace Pie2Shop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>()
            {
                new Pie() {PieId = 1, Name = "StrawBerry Pie", Price = 15.95M, ShortDescription = "", 
                    Category = new Category() { CategoryId = 1, Name = "Fruits pies", Descriprion = "All-fruity pies"}},
                new Pie() {PieId = 2, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "",
                    Category = new Category() { CategoryId = 1, Name = "Fruits pies", Descriprion = "All-fruity pies"}},
                new Pie() {PieId = 3, Name = "Prubrab Pie", Price = 15.95M, ShortDescription = "",
                    Category = new Category() { CategoryId = 1, Name = "Fruits pies", Descriprion = "All-fruity pies"}},
                new Pie() {PieId = 4, Name = "Pumpkin Pie", Price = 12.95M, ShortDescription = "",
                    Category = new Category() { CategoryId = 1, Name = "Fruits pies", Descriprion = "All-fruity pies"}}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(pie => pie.PieId == pieId);
        }
    }
}
