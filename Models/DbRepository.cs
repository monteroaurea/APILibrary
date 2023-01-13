using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILibrary.Models
{
    public class DbRepository : ILibraryRepository
    {
        private readonly LibraryContext _db;
        public DbRepository(LibraryContext db)
        {
            _db = db;
        }
        public IQueryable<Book> Books => throw new NotImplementedException();

        public IQueryable<Author> Authors => throw new NotImplementedException();

        public void add<EntityType>(EntityType entity) => _db.Add(entity);
        public void SaveChanges() => _db.SaveChanges();
    }
}