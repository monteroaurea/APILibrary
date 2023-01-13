using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APILibrary.Models;

[Table("Authors")]
    public class Author
{
    [Key]
    public int AuthorId { get; set; }
    [Required]
    [StringLength(80)]
    public string Name { get; set; }
    [Required]
    [StringLength(300)]
    public ICollection<Book> Books { get; set; }

    public override string ToString()
    {
        return Name;
    }
}
