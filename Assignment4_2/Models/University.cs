using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_2.Models
{
    public class UniversityData
    {
        public Metadata metadata { get; set; }
        public List<University> universityList { get; set; }
    }

    public class Metadata
    {
        public int total { get; set; }
        public int page { get; set; }
        public int per_page { get; set; }
    }

    public class University
    {
        public string schoolname { get; set; }
        public int? _2013studentsize { get; set; }
        public int id { get; set; }
    }
}






