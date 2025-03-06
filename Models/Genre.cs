using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly1.Models
{
	public class Genre
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}