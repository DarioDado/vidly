using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class RentalDto
    {
        public int ID { get; set; }

        [Required]
        public CUstomerDto Customer { get; set; }

        [Required]
        public MovieDto Movie { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}