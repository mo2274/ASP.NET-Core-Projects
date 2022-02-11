using Microsoft.AspNetCore.Mvc;
using Pie2Shop.Models;
using Pie2Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var pieOfTheWeek = new HomeViewModel()
            {
                PiesOfTheWeek = pieRepository.PiesOfTheWeek
            };

            return View(pieOfTheWeek);
        }
    }
}
