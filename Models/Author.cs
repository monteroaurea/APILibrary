using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILibrary
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books {get; set;}

        public override string ToString()
        {
            return Name; 
        }
    }
}