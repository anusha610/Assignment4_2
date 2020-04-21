using Newtonsoft.Json;
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
        [JsonProperty]
        public Results[] results { get; set; }
    }

    public class Metadata
    {
        public int total { get; set; }
        public int page { get; set; }
        public int per_page { get; set; }
    }

    public class Results
    {
        public int? tuitionOutState { get; set; }
        public string schoolZip { get; set; }
        public string schoolUrl { get; set; }
        public string accCode { get; set; }
        public string schoolName { get; set; }
        public int? studentSize { get; set; }
        public int id { get; set; }

    }
}









