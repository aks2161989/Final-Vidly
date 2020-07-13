using Final_Vidly.Models;
using Final_Vidly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
        {
            new Movie{Id = 1, Name = "Shrek"},
            new Movie{Id = 2, Name = "Wall-e"}
        };
        }
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{ Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers,
                Movie = movie
            };
            return View(viewModel);
        }
    }
}