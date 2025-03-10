using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly1.Models
{
	public class ApplicationDbContext: IdentityDbContext<ApplicationUser> 
    { 
		public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

        public ApplicationDbContext()			
		{
			
		}

        public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
       
    }
}