using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Director
    {
        public int Id { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Surnanme { get; set; }


        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        public decimal WonOscars { get; set; }

    }
}

