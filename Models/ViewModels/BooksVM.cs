using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission09_bshorne.Models.ViewModels
{
    public class BooksVM
    {
        public IQueryable<Book> Books { get; set; }
        public PageInformation PageInfo { get; set; }
    }
}
