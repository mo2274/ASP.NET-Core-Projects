using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieStore.Core;
using MovieStore.Data;

namespace MoviesStore.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly IMovieStoreData movieStoreData;

        public Movie movie { get; set; }

        public DetailsModel(IMovieStoreData movieStoreData)
        {
            this.movieStoreData = movieStoreData;
        }

        public IActionResult OnGet(int id)
        {
            movie = movieStoreData.GetById(id);

            if (movie == null)
                return NotFound();

            return Page();
        }
    }
}
