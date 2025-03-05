using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModels;
using System.Data.Entity;

namespace Vidly1.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }        

        public ActionResult Details(int id)  //localhost:5262/Movies/Details/1
        {
            var movies = _context.Movies.Include(m => m.Genre)
                .SingleOrDefault(c => c.Id == id);

            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }

        
    }
}