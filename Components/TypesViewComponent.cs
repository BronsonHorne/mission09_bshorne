using Microsoft.AspNetCore.Mvc;
using mission09_bshorne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission09_bshorne.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private ILibraryRepository repo { get; set; }

        public TypesViewComponent (ILibraryRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookType"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }
    }
}
