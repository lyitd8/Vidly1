using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly1.Models
{
	public class Genres
	{
		public int Id { get; set; }
		public string Genre { get; set; }
		public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
		public int NumberInStock { get; set; }
    }
}