using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace API.core.Data
{
  public  class LOGIN_TABLE
    {
        
        public int ID { get; set; }
        
        public string USERNAME { get; set; }
      
        //[RegularExpression(@"^(?=.?[A-Z])(?=.?[a-z])(?=.?[0-9])(?=.?[#?!@$%^&*-]).{6,}$", ErrorMessage = "should contain at least one upper case or should contain at least one lower case or should contain at least one digit")]
        public string PASSWORD { get; set; }
     
        public int LOGINTYPE { get; set; }
    
        public int COURSID { get; set; }
        
        public string ROLNAME { get; set; }
        public ICollection<TEACHER> Teachers { get; set; }



            }
}
