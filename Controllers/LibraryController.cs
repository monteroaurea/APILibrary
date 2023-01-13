using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APILibrary.Models;



namespace APILibrary.Controllers;

    [Route("controller")]
    public class LibraryController : Controller
    {
    private readonly ILibraryRepository _context;

    public LibraryController(LibraryContext context)
            {
              _context = context;
            }

    public IActionResult Index()
            {
             var model = _context.Books.Include(a => a.Author);
                return View(model);
            }

    public IActionResult Create()
            {
            var tolkien = new Author { Name = "J.R.R.Tolkien" };
            var hobbit = new Book { Title = "The Hobbit", Author = tolkien };
                _context.Add(hobbit);
                    _context.SaveChanges();
            }   
    
    }
