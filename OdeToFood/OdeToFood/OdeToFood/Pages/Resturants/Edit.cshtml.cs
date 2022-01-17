using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Resturants
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Resturant resturant { get;  set; }
        private readonly IRestuarntData restuarntData;
        private readonly IHtmlHelper htmlHelper;
        public IEnumerable<SelectListItem> Cuisines;

        public EditModel(IRestuarntData restuarntData, IHtmlHelper htmlHelper)
        {
            this.restuarntData = restuarntData;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int id)
        {
            Cuisines = htmlHelper.GetEnumSelectList(typeof(CoisineType));
            resturant = restuarntData.GetAll().Where(r => r.Id == id).FirstOrDefault();
            if (resturant is null)
                resturant = new Resturant();

            return Page();
        }

        public IActionResult OnPost()
        {
            Cuisines = htmlHelper.GetEnumSelectList(typeof(CoisineType));

            if (!ModelState.IsValid)
                return Page();

            Resturant result;
            
            if (resturant.Id == 0)
            {
               result = restuarntData.Create(resturant);
            }
            else
            {
                result = restuarntData.Edit(resturant);
            }
           
            restuarntData.Commit();

            if (result is null)
                return BadRequest();

            TempData["Message"] = "Resturant Saved";
            return RedirectToPage("./Details", new { Id = result.Id});
        }
    }
}
