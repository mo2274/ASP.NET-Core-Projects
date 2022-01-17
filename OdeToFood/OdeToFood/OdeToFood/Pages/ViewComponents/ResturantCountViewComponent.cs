using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Pages.ViewComponents
{
    public class ResturantCountViewComponent : ViewComponent
    {
        public ResturantCountViewComponent(IRestuarntData restuarntData)
        {
            RestuarntData = restuarntData;
        }

        IRestuarntData RestuarntData { get; }

        public IViewComponentResult Invoke()
        {
            var count = RestuarntData.GetCountOfResturants();
            return View(count);
        }
    }
}
