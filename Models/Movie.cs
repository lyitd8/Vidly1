using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly1.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int GenreId { get; set; }
        public Genre Genre { get; set; }

		// Read-only property (not stored in database)
		public string GenreName => Genre.Name;
        public DateTime? ReleaseDate => Genre?.ReleaseDate;
		public DateTime? DateAdded => Genre?.DateAdded;
		public int NumberInStock => Genre.NumberInStock;
    }
}