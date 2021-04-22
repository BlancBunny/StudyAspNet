using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortpolio.Models
{
    public class Board
    {
        [Key]
        public int Idx { get; set; }

        [Required(ErrorMessage = "제목을 입력하세요.")]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "작성자를 입력하세요.")]
        [DataType(DataType.Text)]
        [StringLength(20)]
        public string Writer { get; set; }

        [DataType(DataType.Text)]
        public string Contents { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RegDate { get; set; }

        public int ReadCount { get; set; }
    }
}
