using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.core.Data
{
   public class BOOK
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public string B_NAME { get; set; }
        [Required]
        public int P_PRICE { get; set; }
        [Required]
        public DateTime PUBLISHDATE { get; set; }
        [Required]
        public DateTime ENDDATE { get; set; }
        [Required]
        public int COURSID { get; set; }
        [ForeignKey("CourseId")]
        public virtual COURS Course { get; set; }


    }
}
