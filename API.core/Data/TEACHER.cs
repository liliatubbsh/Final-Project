using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.core.Data
{
  public  class TEACHER
    {
       [Key]
        public int ID { get; set; }
        [Required]
        public string  TNAME { get; set; }
        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please Enter valid Email ^_^")]

        public string EMAIL { get; set; }
        [Required]
        public int SALARY { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter Phone Number ")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "Phone number is not valid format")]
        public string PHONE { get; set; }
        [Required]
        public int LOGINID { get; set; }
    
        
        [ForeignKey("LOGINID")]
        public virtual LOGIN_TABLE Login { get; set; }
        public ICollection<TEACHER_COURSE> TeacherCourses { get; set; }












    }
}
