﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;

namespace Vidly1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index() //concrete class
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id) //abstract class
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Cillian Murphy"},
                new Customer {Id = 2, Name = "Leopard"}
            };
        }
    }
}