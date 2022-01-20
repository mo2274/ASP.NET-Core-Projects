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
    public class ListModel : PageModel
    {
        private readonly IMovieStoreData movieStoreData;
        public IEnumerable<Movie> Movies { get; set; }

        public ListModel(IMovieStoreData movieStoreData)
        {
            this.movieStoreData = movieStoreData;
        }

        public void OnGet()
        {
            Movies = movieStoreData.GetMovies();
        }
    }
}
