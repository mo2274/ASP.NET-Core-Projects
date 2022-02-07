﻿using Microsoft.AspNetCore.Mvc;
using Pie2Shop.Models;
using Pie2Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie2Shop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this._pieRepository = pieRepository;
            this._categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var pieViewModel = new PieListViewModel()
            {
                Pies = _pieRepository.AllPies,
                CurrentCategory = "Cheese Cake"
            };

            return View(pieViewModel);
        }
    }
}