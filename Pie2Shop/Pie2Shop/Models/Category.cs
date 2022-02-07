using System.Collections.Generic;

namespace Pie2Shop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
        public List<Pie> Pies { get; set; }
    }
}