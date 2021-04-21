using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortpolio.Models
{
    public class Contact
    {
        [Key]
        public int Idx { get; set; }

        [Required(ErrorMessage = "이름은 필수입니다")]
        [DataType(DataType.Text)]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "이메일은 필수입니다")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "내용은 필수입니다")]
        [DataType(DataType.Text)]
        public string Contents { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime RegDate { get; set; }
    }
}
