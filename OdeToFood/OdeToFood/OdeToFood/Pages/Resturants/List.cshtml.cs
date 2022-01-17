using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Resturants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly IRestuarntData restuarntData;
        private readonly ILogger<ListModel> logger;

        [TempData]
        public string Message { get; set; }
        public IEnumerable<Resturant> Resturants { get; set; }
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration configuration, IRestuarntData restuarntData, ILogger<ListModel> logger)
        {
            this.configuration = configuration;
            this.restuarntData = restuarntData;
            this.logger = logger;
            //Message  = configuration["Message"];
        }

        public void OnGet(string q)
        {
            logger.LogInformation("#############################################");
            SearchTerm = q;
            Resturants = restuarntData.GetResturantsByName(q);
            //throw new Exception("hellllllllllo");
        }

        public void Delete(int id)
        {
            restuarntData.Delete(id);
            restuarntData.Commit();
        }
    }
}
