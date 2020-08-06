using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Vidly.Models;

namespace Final_Vidly.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}