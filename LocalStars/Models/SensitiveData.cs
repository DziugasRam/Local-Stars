using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{

    public class SensitiveData
    {
        public DateTime Date { get; set; }
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
