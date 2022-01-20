using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API.core.Data
{
  public  class COURS
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string C_NAME { get; set; }
        [Required]
        public int C_PRICE { get; set; }
        [Required]
        public DateTime STARTDATE { get; set; }
        [Required]
        public DateTime ENDDATE { get; set; }
        [Required]
        public string IMAGEPATH { get; set; }


        public ICollection<BOOK> Books { get; set; }
    }
}
