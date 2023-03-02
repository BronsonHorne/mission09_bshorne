using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission09_bshorne.Models
{
    //Implement an Instance of a IWaterProjectRepository
    public class EFLibraryRepository : ILibraryRepository
    {
        private BookstoreContext context { get; set; }

        public EFLibraryRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
