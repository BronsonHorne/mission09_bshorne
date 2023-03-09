using Microsoft.AspNetCore.Mvc;
using mission09_bshorne.Models;
using mission09_bshorne.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace mission09_bshorne.Controllers
{
    public class HomeController : Controller
    {
        private ILibraryRepository repo;

        public HomeController(ILibraryRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string bookType, int pageNum = 1)
        {
            int perPage = 10;

            var b = new BooksVM
            {
                Books = repo.Books
                .Where(b => b.Category == bookType | bookType == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * perPage)
                .Take(perPage),

                PageInfo = new PageInformation
                {
                    TotalBooks = 
                    (bookType == null 
                    ? repo.Books.Count() 
                    : repo.Books.Where(x => x.Category == bookType).Count()),
                    BooksPerPage = perPage,
                    CurrentPage = pageNum
                }
            };

            return View(b);

        }
    }
}
