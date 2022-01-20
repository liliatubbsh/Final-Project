using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API.core.Data
{
   public class STD
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string S_FNAME { get; set; }
        [Required]
        public string S_LNAME { get; set; }
        [Required]
        public int C_PRICE { get; set; }
        [Required]
        public DateTime PARTHDATE { get; set; }
        [Required]
        public int MARK { get; set; }

        public ICollection<STD_COURSE> StudentCourses { get; set; }
    }
}
