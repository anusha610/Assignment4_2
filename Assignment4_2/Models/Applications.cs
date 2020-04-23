using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_2.Models
{
    public class Applications
    {
        [Key]
        public string Name { get; set; }
        public string University { get; set; }
        public string Major { get; set; }
    }
}
