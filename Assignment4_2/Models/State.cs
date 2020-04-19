using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_2.Models
{
    public class State
    {
        [Key]
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        
    }
}
