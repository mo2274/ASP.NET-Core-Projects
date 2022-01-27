using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieStore.Core
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(100), Required]
        public string Name { get; set; }
        
        [Required]
        public decimal Rate { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [DisplayName("Image Link")]
        public string ImageLink { get; set; }
    }
}
