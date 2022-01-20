using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.core.Data
{
    public class TEACHER_COURSE
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int COURSID { get; set; }
        [Required]
        public int TEACHERID { get; set; }

        [ForeignKey("COURSID")]
        public virtual COURS Course { get; set; }
    
        [ForeignKey("TEACHERID")]
        public virtual TEACHER Teacher { get; set; }




    }
}
