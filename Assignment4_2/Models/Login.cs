﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_2.Models
{
    public class LogIn
    {
        [Key]
        public string email { get; set; }
        public string password { get; set; }
        
    }
}
