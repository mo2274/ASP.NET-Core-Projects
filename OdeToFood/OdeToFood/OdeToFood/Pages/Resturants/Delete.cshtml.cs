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
    public class DeleteModel : PageModel
    {
        private readonly IRestuarntData restuarntData;

        public Resturant resturant { get; set; }

        public DeleteModel(IRestuarntData restuarntData)
        {
            this.restuarntData = restuarntData;
        }

        public void OnGet(int id)
        {
            resturant = restuarntData.GetResturantsById(id);

            if (resturant is null)
                RedirectToPagePermanent("NotFound");
        }

        public IActionResult OnPost(int id)
        {
            resturant = restuarntData.Delete(id);
            restuarntData.Commit();

            if (resturant is null)
                RedirectToPagePermanent("NotFound");

            TempData["Message"] = $"{resturant.Name} deleted";
            return RedirectToPagePermanent("List");
        }
    }
}
