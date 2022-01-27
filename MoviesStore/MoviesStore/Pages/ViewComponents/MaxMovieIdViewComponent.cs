using Microsoft.AspNetCore.Mvc;
using MovieStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesStore.Pages.ViewComponents
{
    public class MaxMovieIdViewComponent : ViewComponent
    {
        private readonly IMovieStoreData movieStoreData;

        public MaxMovieIdViewComponent(IMovieStoreData movieStoreData)
        {
            this.movieStoreData = movieStoreData;
        }

        public IViewComponentResult Invoke()
        {
            var max = movieStoreData.GetMax();
            return View(max);
        }
    }
}
