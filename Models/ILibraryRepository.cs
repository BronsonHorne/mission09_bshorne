using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission09_bshorne.Models
{
    public interface ILibraryRepository
    {
        //Instead of List <ofType>     can read, but can't write
        IQueryable<Book> Books { get; }
    }
}
