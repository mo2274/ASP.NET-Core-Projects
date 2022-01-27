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
    public class CreateModel : PageModel
    {
        private readonly IMovieStoreData movieStoreData;
        private readonly IHtmlHelper htmlHelper;

        public Movie Movie { get; set; }
        public IEnumerable<SelectListItem> Genres { get; set; }

        public CreateModel(IMovieStoreData movieStoreData, IHtmlHelper htmlHelper)
        {
            this.movieStoreData = movieStoreData;
            this.htmlHelper = htmlHelper;
            Genres = htmlHelper.GetEnumSelectList(typeof(Genre));
        }

        public void OnGet()
        {
           
        }

        public IActionResult OnPost(Movie movie)
        {
            if (!ModelState.IsValid)
                return Page();

            movieStoreData.Add(movie);
            movieStoreData.Commit();

            TempData["Message"] = "Item Created!";
            return RedirectToPagePermanent("./List");
        }
    }
}
