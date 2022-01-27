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
    public class DeleteModel : PageModel
    {
        private readonly IMovieStoreData movieStoreData;

        public Movie Movie { get; set; }

        public DeleteModel(IMovieStoreData movieStoreData)
        {
            this.movieStoreData = movieStoreData;
        }

        public void OnGet(int id)
        {
            Movie = movieStoreData.GetById(id);
        }

        public IActionResult OnPost(int id)
        {
            Movie = movieStoreData.Delete(id);

            if (Movie == null)
                return NotFound();
            movieStoreData.Commit();
            return RedirectToPagePermanent("List");
        }
    }
}
