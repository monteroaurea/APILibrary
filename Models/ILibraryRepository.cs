using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*Repository:
Class to isolate the code of the Database for Tests purpose.
*/

namespace APILibrary.Models
{
    public interface ILibraryRepository
    {
        public IQueryable<Book> Books { get; }
        public IQueryable<Author> Authors { get; }

        void add<EntityType>(EntityType entity);

        void SaveChanges();
    }
}