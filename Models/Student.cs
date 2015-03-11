using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bipa.Models
{
    [Table("TDLSTD")]
    public class Student
    {
        [Key]
        public int ID { get; set; }//	int
        [Display(Name = "SID")]
        public string SID { get; set; }//	varchar(510)
        [Display(Name = "First Name")]
        public string FNAME { get; set; }//	varchar(510)
        [Display(Name = "Middle Name")]
        public string MNAME { get; set; }//	varchar(510)
        [Display(Name = "Last Name")]
        public string LNAME { get; set; }//	varchar(510)
        [Display(Name = "Foreigner")]
        public string FOREIGNER { get; set; }//	varchar(510)
        [Display(Name = "Address")]
        public string ADDRE { get; set; }//	varchar(510)
        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }//	varchar(510)
        [Display(Name = "Occupation")]
        public string OCC { get; set; }//	varchar(510)
        [Display(Name = "Education")]
        public string EDUCATION { get; set; }//	varchar(510)
        [Display(Name = "Telephone 1")]
        public string TEL1 { get; set; }//	varchar(510)
        [Display(Name = "Telephone 2")]
        public string TEL2 { get; set; }//	varchar(510)
        [Display(Name = "SID")]
        [DataType(DataType.EmailAddress)]
        public string EMAIL { get; set; }//	varchar(510)
        [Display(Name = "remarks")]
        [DataType(DataType.MultilineText)]
        public string REMARKS { get; set; }//	varchar(510)
        [Display(Name = "10 day special with guru")]
        public string TENSNG { get; set; }//	varchar(510)
        [Display(Name = "10 day special ")]
        public string TENSP { get; set; }//	varchar(510)
        [Display(Name = "10 day course")]
        public string TEN { get; set; }//	varchar(510)
        [Display(Name = "7 day course")]
        public string SEVEN { get; set; }//	varchar(510)
        [Display(Name = "20 Day Course")]
        public string TWENTY { get; set; }//	varchar(510)
        [Display(Name = "30 Day course")]
        public string THIRTY { get; set; }//	varchar(510)
        [Display(Name = "45 Day Course")]
        public string FOURTYFIVE { get; set; }//	varchar(510)
        [Display(Name = "60 Day course")]
        public string SIXTY { get; set; }//	varchar(510)
        [Display(Name = "Served")]
        public string SERVED { get; set; }//	varchar(510)
        [Display(Name = "Introduced By")]
        public string INTRODUCEDBY { get; set; }//	varchar(510)
        [Display(Name = "Sex")]
        public string SEX { get; set; }//	varchar(510)


    }
}