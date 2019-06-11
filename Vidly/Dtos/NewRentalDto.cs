using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class NewRentalDto
    {
        public List<int> MovieIds { get; set; }
        public int CustomerId { get; set; }
    }
}