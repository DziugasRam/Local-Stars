using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers.Models
{
    public class SellerData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
