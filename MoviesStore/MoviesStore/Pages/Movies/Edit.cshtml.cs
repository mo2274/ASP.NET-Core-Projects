using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieStore.Core;
using MovieStore.Data;

namespace MoviesStore.Pages.Movies
{
    public class EditModel : PageModel
    {
        private readonly IMovieStoreData movieStoreData;
        private readonly IHtmlHelper htmlHelper;
        public Movie Movie { get; set; }
        public IEnumerable<SelectListItem> Genres { get; set; }


        public EditModel(IMovieStoreData movieStoreData, IHtmlHelper htmlHelper )
        {
            this.movieStoreData = movieStoreData;
            this.htmlHelper = htmlHelper;
            Genres = htmlHelper.GetEnumSelectList(typeof(Genre));
        }

        public IActionResult OnGet(int id)
        {
            Movie = movieStoreData.GetById(id);
            if (Movie == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost(Movie movie)
        {
            if (!ModelState.IsValid)
                return Page();

            var result = movieStoreData.Update(movie);

            if (result == null)
                return NotFound();

            movieStoreData.Commit();

            TempData["Message"] = "Item Updated!";
            return RedirectToPagePermanent("./List");
        }
    }
}
