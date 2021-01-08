using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Controllers.Models
{
    public class UpdateProductData
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
    }
}
