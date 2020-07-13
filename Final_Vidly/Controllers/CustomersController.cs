using Final_Vidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer{ Id = 1, Name = "John Smith" },
                new Customer{ Id = 2, Name = "Mary Williams"}
            };
        }
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer != null)
            {
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }

        }
    }
}