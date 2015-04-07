using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bipa.Models
{
    public class ReferralListInquiry
    {


        [Display(Name = "First Name")]
        public string APP_FNAME { get; set; }//varchar(50)	Checked
       [Display(Name = "Last Name")]
        public string APP_LNAME { get; set; }//	varchar(50)	Checked
        [Display(Name = "Course Num")]
        public string TRAIN_S_N { get; set; }//	varchar(15)	Unchecked
        [Display(Name = "Application Num")]
        public string APP_NO { get; set; }//varchar(15)	Unchecked
         [Display(Name = "Gender")]
        public string APP_GENDER { get; set; }//	varchar(10)	Checked
        [Display(Name = "Address")]
        public string APP_ADDR { get; set; }//	varchar(100)	Checked
        [Display(Name = "Course Start Date")]
        public DateTime? START_DATE { get; set; }//	date	Unchecked
        [Display(Name = "Course End Date")]
        public DateTime? TILL_DATE { get; set; }//date	Checked
        public string RecordID
        {
            get;
            set;
        } 

    }
}