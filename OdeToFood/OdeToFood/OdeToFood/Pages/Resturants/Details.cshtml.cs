using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Resturants
{
    public class DetailsModel : PageModel
    {
        private readonly IRestuarntData restuarntData;
        public Resturant resturant;
        [TempData]
        public string Message { get; set; }

        public DetailsModel(IRestuarntData restuarntData)
        {
            this.restuarntData = restuarntData;
        }

        public IActionResult OnGet(int Id)
        {
            resturant = restuarntData.GetAll().Where(r => r.Id == Id).FirstOrDefault();
            if (resturant is null)
               return RedirectToPage("./NotFound");

            return Page();
        }
    }
}
