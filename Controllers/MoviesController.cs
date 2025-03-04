using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModels;

namespace Vidly1.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Bat Man 2"},
                new Movie {Id = 2, Name = "Inception"}
            };
        }

        public ActionResult Random()  //localhost:5262/Movies/Random
        {
            var movie = new Movie() { Id = 1, Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int movieId)  //localhost:5262/Movies/Edit/1
        {
            return Content("id=" + movieId);
        }

        // GET: Movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year:regex(\\d{4}):range(1950,2025)}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month) //localhost/5262/movies/released/2020/5
        //{
        //    return Content(year + "/" + month);
        //}
    }
}