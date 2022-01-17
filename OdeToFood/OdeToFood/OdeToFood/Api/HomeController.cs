using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Api
{
    public class HomeController : Controller
    {
        private readonly IRestuarntData restuarntData;

        public HomeController(IRestuarntData restuarntData)
        {
            this.restuarntData = restuarntData;
        }

        [Route("/api/home")]
        [HttpGet]
        public IActionResult Index()
        {
            return Json(restuarntData.GetAll());
        }
    }
}
