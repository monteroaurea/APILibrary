using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APILibrary.Models;

[Table("Books")]
public class Book
{
    [Key]
    public int BookId { get; set; }
    [Required]
    [StringLength(80)]
    public string Title { get; set; }
    [Required]
    [StringLength(300)]
    public Author Author { get; set; }
  
    public override string ToString()
    {
        return $"({Title}{Author})";
    }

}
