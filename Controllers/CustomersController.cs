using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using System.Data.Entity;

namespace Vidly1.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            return View();
        }

        // GET: Customers
        public ViewResult Index() //concrete class
        {
            var customers = _context.Customers.Include(m => m.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id) //abstract class
        {
            var customer = _context.Customers.Include(m => m.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

       
    }
}