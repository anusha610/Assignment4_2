using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_2.Models
{
    public class Student
    {
        [Key]
        public string Name { get; set; }
        public string email { get; set; }
        public int contact { get; set; }
        public List<Applications> applications  { get; set; }
    }
}
