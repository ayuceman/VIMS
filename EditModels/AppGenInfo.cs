using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bipa.Models;

namespace Bipa.EditModels
{
    public class AppGenInfo
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Registration no")]
        public string REG_NO { get; set; }//	varchar(15)	Checked
        [Display(Name = "Application no")]
        [Required]
        public string APP_NO { get; set; }//varchar(15)	Unchecked
        [Required]
        [Display(Name = "Train SN")]
        public string TRAIN_S_N { get; set; }//	varchar(15)	Unchecked
        public DateTime? REG_DATE { get; set; }//date	Checked
        [Display(Name = "First Name")]
        public string APP_FNAME { get; set; }//varchar(50)	Checked
        [Display(Name = "Middle Name")]
        public string APP_MNAME { get; set; }//varchar(50)	Checked
        [Display(Name = "Last Name")]
        public string APP_LNAME { get; set; }//	varchar(50)	Checked
        [Display(Name = "Age")]
        public decimal? APP_AGE { get; set; }//decimal(3, 0)	Checked
        [Display(Name = "Gender")]
        [StringLength(10)]
        public string APP_GENDER { get; set; }//	varchar(10)	Checked
        [Display(Name = "Date of Birth")]
        public DateTime? APP_DOB { get; set; }//	date	Checked
        [Display(Name = "Start Date")]
        [Required]
        public DateTime? START_DATE { get; set; }//	date	Unchecked
        [Display(Name = "Till Date")]
        public DateTime? TILL_DATE { get; set; }//date	Checked
        [Display(Name = "Business")]
        public string APP_BUSINESS { get; set; }//	varchar(50)	Checked
        [Display(Name = "Education")]
        public string APP_EDU { get; set; }//varchar(50)	Checked

        [Display(Name = "Foreigner")]
        public bool? FOREIGN_Y_N { get; set; }//varchar(3)	Checked
        [Display(Name = "Monk")]
        public bool? MONK_Y_N { get; set; }//varchar(3)	Checked
        [Display(Name = "Confirmed?")]
        public bool? CONFIRMED { get; set; }//	varchar(3)	Checked
        
        public static void CopyInfoToEntity(AppGenInfo from, Application to)
        {
            if (from == null || to == null) return;
            to.APP_AGE = from.APP_AGE;
            to.APP_FNAME = from.APP_FNAME;
            to.APP_GENDER = from.APP_GENDER;
            to.APP_LNAME = from.APP_LNAME;
            to.APP_MNAME = from.APP_MNAME;
            to.APP_NO = from.APP_NO;
            to.REG_NO = from.REG_NO;
            to.REG_DATE = from.REG_DATE;
            to.START_DATE = from.START_DATE;
            to.TILL_DATE = from.TILL_DATE;
            to.APP_BUSINESS = from.APP_BUSINESS;
            to.TRAIN_S_N = from.TRAIN_S_N;
            to.FOREIGN_Y_N = from.FOREIGN_Y_N == null ? null : (from.FOREIGN_Y_N == true ? "Y" : "N");
            to.MONK_Y_N = from.MONK_Y_N == null ? null : (from.MONK_Y_N == true ? "Y" : "N");
            to.CONFIRMED = from.CONFIRMED == null ? null : (from.CONFIRMED == true ? "Y" : "N");
        }
        public static AppGenInfo CopyInfoFromEntity( Application from)
        {
            var to = new AppGenInfo
            {
                APP_AGE = @from.APP_AGE,
                APP_FNAME = @from.APP_FNAME,
                APP_GENDER = @from.APP_GENDER,
                APP_LNAME = @from.APP_LNAME,
                APP_MNAME = @from.APP_MNAME,
                APP_NO = @from.APP_NO,
                REG_NO = @from.REG_NO,
                REG_DATE = @from.REG_DATE,
                START_DATE = @from.START_DATE,
                TILL_DATE = @from.TILL_DATE,
                APP_BUSINESS = @from.APP_BUSINESS,
                TRAIN_S_N = @from.TRAIN_S_N,
                FOREIGN_Y_N = @from.FOREIGN_Y_N == null ? (bool?) null : (@from.FOREIGN_Y_N.ToUpper() == "Y"),
                MONK_Y_N = @from.MONK_Y_N == null ? (bool?) null : (@from.MONK_Y_N.ToUpper() == "Y"),
                CONFIRMED = @from.CONFIRMED == null ? (bool?) null : (@from.CONFIRMED.ToUpper() == "Y")
            };
            return to;
        }
    }
}