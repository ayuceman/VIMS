using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bipa.Models;

namespace Bipa.EditModels
{
    public class AppHealthInfo
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Disability")]
        public bool? APP_DISABILITY { get; set; }//varchar(5)	Checked
        [Display(Name = "Disability Detail")]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string APP_DISAB_DETAIL { get; set; }//	varchar(500)	Checked
        [Display(Name = "Smoking Habit")]
        public bool? SMOKING_HABIT { get; set; }//	varchar(5)	Checked
        [Display(Name = "Quit During Training")]
        public bool? QUIT_DURING { get; set; }//varchar(5)	Checked
        [Display(Name = "Physically able for train")]
        public bool? PHYSICAL_ABLE_FOR_TRAIN { get; set; }//varchar(5)	Checked

        public static void CopyInfoToEntity(AppHealthInfo from, Application to)
        {
            if (from == null || to == null){return;}
            to.APP_DISABILITY=from.APP_DISABILITY==null?null:(from.APP_DISABILITY==true?"Y":"N");
            to.APP_DISAB_DETAIL=from.APP_DISAB_DETAIL;
            to.PHYSICAL_ABLE_FOR_TRAIN = from.PHYSICAL_ABLE_FOR_TRAIN == null ? (string)null : (from.PHYSICAL_ABLE_FOR_TRAIN == true ? "Y" : "N");
            to.QUIT_DURING = from.QUIT_DURING == null ? (string)null : (from.QUIT_DURING == true ? "Y" : "N");
            to.SMOKING_HABIT = from.SMOKING_HABIT == null ? (string)null : (from.SMOKING_HABIT == true ? "Y" : "N");
        }
        public static AppHealthInfo CopyInfoFromEntity(Application from)
        {
            var to = new AppHealthInfo()
            {
                APP_DISABILITY = from.APP_DISABILITY == null ? (bool?) null : (from.APP_DISABILITY.ToUpper() == "Y"),
                APP_DISAB_DETAIL=from.APP_DISAB_DETAIL,
                PHYSICAL_ABLE_FOR_TRAIN = from.PHYSICAL_ABLE_FOR_TRAIN == null ? (bool?)null : (from.PHYSICAL_ABLE_FOR_TRAIN.ToUpper() == "Y"),
                QUIT_DURING = from.QUIT_DURING == null ? (bool?)null : (from.QUIT_DURING.ToUpper() == "Y"),
                SMOKING_HABIT = from.SMOKING_HABIT == null ? (bool?)null : (from.SMOKING_HABIT.ToUpper() == "Y"),
                //PHYSICAL_ABLE_FOR_TRAIN = from.PHYSICAL_ABLE_FOR_TRAIN == null ? (bool?)null : (from.PHYSICAL_ABLE_FOR_TRAIN.ToUpper() == "Y"),
            };
            return to;
        }
    }
}