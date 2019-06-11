using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MembershipTypeDto
    {
        public byte ID { get; set; }

        public string Name { get; set; }

        public byte DiscountRate { get; set; }
    }
}