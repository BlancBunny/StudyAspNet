using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortpolio.Models
{
    public class Account
    {
        [Key]
        public int Idx { get; set; }

        [DataType(DataType.Text)]

        public string Name { get; set; }

        [Required(ErrorMessage ="이메일은 필수입니다.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "패스워드는 필수입니다.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public char Grade { get; set; }
    }
}
