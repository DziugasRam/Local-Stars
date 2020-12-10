using Microsoft.AspNetCore.Http;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers.Models
{
    public class ProductData
    {

        public IFormFile ImageFile { get;  set; }
        //public string ImageSrc { get; set; }
        //public string ImageName { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
