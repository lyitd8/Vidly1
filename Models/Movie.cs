﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly1.Models
{
	public class Movie
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Movie Name is required")]
		[StringLength(255)]
		public string Name { get; set; }

		[Display(Name="Genre")]
		[Required]
		public int GenreId { get; set; }

        public Genre Genre { get; set; }

		[Display(Name ="Genre Name")]
		public string GenreName { get; set; }

        [Display(Name="Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
		[Range(1,20)]
        public int NumberInStock { get; set; }
    }
}