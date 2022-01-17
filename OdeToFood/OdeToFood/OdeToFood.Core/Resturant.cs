using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OdeToFood.Core
{
    public class Resturant
    {
        public int Id { get; set; }      
        [Required, StringLength(60)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public CoisineType Coisine { get; set; }
    }
}
