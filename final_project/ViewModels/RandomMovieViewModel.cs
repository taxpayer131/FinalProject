using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using final_project.Models;

namespace final_project.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}