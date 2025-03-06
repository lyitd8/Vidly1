using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly1.Models;

namespace Vidly1.ViewModels
{
	public class MovieFormViewModel
	{
		public IEnumerable<Genre> Genres { get; set; }

		public int? Id { get; set; }

        [Required]
		[StringLength(255)]
		public string Name { get; set; }

		[Display(Name="Genre")]
		[Required]
		public int GenreId { get; set; }

		[Required]
		[Display(Name="Release Data")]
		public DateTime? ReleaseDate { get; set; }

		[Display(Name="Number in Stock")]
		[Required]
		[Range(1,20)]
		public int NumberInStock { get; set; }

        public string Title
		{
			get
			{
				return Id != 0 ? "Edit movie" : "New movie";
			}
		}

		public MovieFormViewModel()
		{
			Id = 0;
		}

		public MovieFormViewModel(Movie movie)
		{
			Id = movie.Id;
			Name = movie.Name;
			ReleaseDate = movie.ReleaseDate;
			NumberInStock = movie.NumberInStock;
			GenreId = movie.GenreId;
		}
    }
}