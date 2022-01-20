using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.core.Data
{
   public class STD_COURSE
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int COURSID { get; set; }

        [ForeignKey("COURSID")]

        public virtual COURS Course { get; set; }

        [Required]
        public int STUDUNTID { get; set; }

        [ForeignKey("STUDUNTID")]
        public virtual STD Student { get; set; }

    }
}
