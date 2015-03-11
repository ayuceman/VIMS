using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bipa.Models;

namespace Bipa.EditModels
{
    public class AppExtraInfo
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Read about BIPA")]
        public bool? READ_ABOUT_BIPA { get; set; }//varchar(5)	Checked
        [Display(Name = "Understnd about BIPA")]
        public bool? UNDERSTAND_ABOUT_BIPA { get; set; }//varchar(5)	Checked
        
        [Display(Name = "Abide in rules")]
        public bool? ABIDE_IN_RULES { get; set; }//varchar(5)	Checked
        [Display(Name = "No Leave During Training")]
        public bool? NO_LEAVE_DURING { get; set; }//varchar(5)	Checked
        [Display(Name = "Maintain silence")]
        public bool? MAINTAIN_SILENCE { get; set; }//	varchar(5)	Checked
        [Display(Name = "Leave other exercise")]
        public bool? LEAVE_OTHER_EXERCISE { get; set; }//varchar(5)	Checked
        [Display(Name = "No of Service")]
        public decimal? NO_OF_SERVICE { get; set; }//decimal(5, 0)	Checked
        [DataType(DataType.MultilineText)]
        [StringLength(500)]
        [Display(Name = "Personal Identification Summary")]
        public string PERSONAL_IDENTIFICATION_SUMM { get; set; }//varchar(500)	Checked
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        [Display(Name="How you know about us")]
        public string HOW_U_KNOW_DETAIL { get; set; }//	varchar(500)	Checked
        [Display(Name="Coming Date if Partial")]
        public DateTime? COMING_DATE_IF_PARTIAL { get; set; }//	date	Checked
        [Display(Name = "Coming Time if Partial")]
        [StringLength(50)]
        public string COMING_TIME_IF_PARTIAL { get; set; }//	varchar(50)	Checked
        [Display(Name = "Going Date if Partial")]
        public DateTime? GOING_DATE_IF_PARTIAL { get; set; }//date	Checked
        [Display(Name = "Going Time if Partial")]
        [StringLength(50)]
        public string GOING_TIME_IF_PARTIAL { get; set; }//	varchar(50)	Checked

        public static void CopyToEntity(AppExtraInfo from, Application to)
        {
            if (from == null || to == null) return;
            to.ABIDE_IN_RULES = from.ABIDE_IN_RULES == null ? null : (from.ABIDE_IN_RULES == true ? "Y" : "N");
            to.COMING_DATE_IF_PARTIAL = from.COMING_DATE_IF_PARTIAL;
            to.COMING_TIME_IF_PARTIAL = from.COMING_TIME_IF_PARTIAL;
            to.GOING_DATE_IF_PARTIAL = from.GOING_DATE_IF_PARTIAL;
            to.GOING_TIME_IF_PARTIAL = from.GOING_TIME_IF_PARTIAL;
            to.HOW_U_KNOW_DETAIL = from.HOW_U_KNOW_DETAIL;
            to.LEAVE_OTHER_EXERCISE = from.LEAVE_OTHER_EXERCISE == null ? null : (from.LEAVE_OTHER_EXERCISE == true ? "Y" : "N");
            to.MAINTAIN_SILENCE = from.MAINTAIN_SILENCE == null ? null : (from.MAINTAIN_SILENCE == true ? "Y" : "N");
            to.NO_LEAVE_DURING = from.NO_LEAVE_DURING == null ? null : (from.NO_LEAVE_DURING == true ? "Y" : "N");
            to.NO_OF_SERVICE = from.NO_OF_SERVICE;
            to.PERSONAL_IDENTIFICATION_SUMM = from.PERSONAL_IDENTIFICATION_SUMM;
            to.READ_ABOUT_BIPA = from.READ_ABOUT_BIPA == null ? null : (from.READ_ABOUT_BIPA == true ? "Y" : "N");
            to.UNDERSTAND_ABOUT_BIPA = from.UNDERSTAND_ABOUT_BIPA == null ? null : (from.UNDERSTAND_ABOUT_BIPA == true ? "Y" : "N");
        }

        public static AppExtraInfo CopyFromEntity(Application from)
        {
            var to = new AppExtraInfo();
            to.ABIDE_IN_RULES = from.ABIDE_IN_RULES == null ? (bool?)null : (from.ABIDE_IN_RULES.ToUpper() == "Y");
            to.COMING_DATE_IF_PARTIAL = from.COMING_DATE_IF_PARTIAL;
            to.COMING_TIME_IF_PARTIAL = from.COMING_TIME_IF_PARTIAL;
            to.GOING_DATE_IF_PARTIAL = from.GOING_DATE_IF_PARTIAL;
            to.GOING_TIME_IF_PARTIAL = from.GOING_TIME_IF_PARTIAL;
            to.HOW_U_KNOW_DETAIL = from.HOW_U_KNOW_DETAIL;
            to.LEAVE_OTHER_EXERCISE = from.LEAVE_OTHER_EXERCISE == null ? (bool?)null : (from.LEAVE_OTHER_EXERCISE.ToUpper() == "Y");
            to.MAINTAIN_SILENCE = from.MAINTAIN_SILENCE == null ? (bool?)null : (from.MAINTAIN_SILENCE.ToUpper() == "Y");
            to.NO_LEAVE_DURING = from.NO_LEAVE_DURING == null ? (bool?)null : (from.NO_LEAVE_DURING.ToUpper() == "Y");
            to.NO_OF_SERVICE = from.NO_OF_SERVICE;
            to.PERSONAL_IDENTIFICATION_SUMM = from.PERSONAL_IDENTIFICATION_SUMM;
            to.READ_ABOUT_BIPA = from.READ_ABOUT_BIPA == null ? (bool?)null : (from.READ_ABOUT_BIPA.ToUpper() == "Y");
            to.UNDERSTAND_ABOUT_BIPA = from.UNDERSTAND_ABOUT_BIPA == null ? (bool?)null : (from.UNDERSTAND_ABOUT_BIPA.ToUpper() == "Y");
            return to;
        }
    }
}