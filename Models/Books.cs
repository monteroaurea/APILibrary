using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Author})";
        }

    }
}