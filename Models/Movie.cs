using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]  
        
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]   
        public DateTime ReleaseDate { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [EmailAddress]
        public string Rating { get; set; }
        public string Email { get; set; }
       
    }
}