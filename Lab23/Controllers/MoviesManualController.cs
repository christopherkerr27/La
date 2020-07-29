using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab23.Data;
using Lab23.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab23.Controllers
{
    public class MoviesManualController : Controller
    {
        private readonly MoviesContext _dbContext;

        public MoviesManualController(MoviesContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var movies = _dbContext.Movies.ToList();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Blind("Title", "Genre", "RunTime")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
