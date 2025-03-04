﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly1.Models
{
	public class ApplicationDbContext:DbContext
	{ 
		public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
		public ApplicationDbContext()			
		{
			
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
       
    }
}