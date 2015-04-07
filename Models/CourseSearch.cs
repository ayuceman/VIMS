using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Bipa.Models
{
    public class CourseSearch
    {
        [Required]
        [Display(Name = "Train SN")]
        public string TRAIN_S_N { get; set; }//	varchar(15)	Unchecked
     
        [Display(Name = "First Name")]
        public string APP_FNAME { get; set; }//varchar(50)	Checked
       
        [Display(Name = "Last Name")]
        public string APP_LNAME { get; set; }

    }
}