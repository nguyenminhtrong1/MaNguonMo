using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [ Required( ErrorMessage ="Title is required.")]
        [ MaxLength(35)]
        [MinLength(5)]
      
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}