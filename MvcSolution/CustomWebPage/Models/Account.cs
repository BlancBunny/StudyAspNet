using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWebPage.Models
{
    public class Account
    {
        [Key]
        public int Idx { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        public char Grade { get; set; }

       
    }

}

