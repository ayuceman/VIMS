using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bipa.Models;

namespace Bipa.EditModels
{
    public class AppTrainInfo
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "No of 10 days")]
        [Range(0,99999)]
        public decimal? NO_OF_10_DAYS { get; set; }//decimal(5, 0)	Checked
        [Display(Name = "No of 10 days (other)")]
        [Range(0,99999)]
        public decimal? NO_OF_10_DAYS_OTHER { get; set; }//decimal(5, 0)	Checked
        [Display(Name = "No of Satipathan")]
        [Range(0,99999)]
        public decimal? NO_OF_SATIPATHAN { get; set; }//decimal(5, 0)	Checked
        [Display(Name = "No of special days")]
        [Range(0,99999)]
        public decimal? NO_OF_SPECIAL { get; set; }//decimal(5, 0)	Checked
        [Display(Name = "No of 20 days")]
        [Range(0,99999)]
        public decimal? NO_OF_20_DAYS { get; set; }//decimal(5, 0)	Checked
        [Display(Name = "No of 10 days")]
        [Range(0,99999)]
        public decimal? NO_OF_30_DAYS { get; set; }//	decimal(5, 0)	Checked
        [Display(Name = "No of 45-60 days")]
        [Range(0,99999)]
        public decimal? NO_OF_45_60_DAYS { get; set; }//decimal(5, 0)	Checked
        [Display(Name = "No of Self Teach")]
        [Range(0,99999)]
        public decimal? NO_OF_TEACH_SELF { get; set; }//decimal(5, 0)	Checked
        [Display(Name = "No of 1 day train class")]
        [Range(0, 999)]
        public decimal? NO_OF_ONEDAY_TRAIN_CLASS { get; set; }//decimal(3, 0)	Checked
        [Display(Name = "No of 1 day train service")]
        [Range(0, 999)]
        public decimal? NO_OF_ONDAY_TRAIN_SERV { get; set; }//decimal(3, 0)	Checked
        [Display(Name = "No of Exercise in a day")]
        [Range(0, 999)]
        public decimal? NO_OF_EXERCISE_IN_A_DAY { get; set; }//	decimal(3, 0)	Checked
        [Display(Name = "Any other train Class")]
        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        public string ANY_OTHER_TRAIN_CLASS { get; set; }//varchar(100)	Checked
        [Display(Name = "Any other train service")]
        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        public string ANY_OTHER_TRAIN_SERV { get; set; }//	varchar(100)	Checked
        [Display(Name = "Train after satya")]
        public bool? TRAIN_AFTER_SATYA { get; set; }//varchar(5)	Checked
        [Display(Name = "Train after satya details")]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string TRAIN_AFTER_SATYA_DETAIL { get; set; }//varchar(500)	Checked
        [Display(Name = "Continue after last train")]
        public bool? CONTINUE_AFTER_LAST_TRAIN { get; set; }//varchar(5)	Checked

        public static void CopyToEntity(AppTrainInfo from, Application to)
        {
            if (from == null || to == null) return;
            to.ANY_OTHER_TRAIN_CLASS = from.ANY_OTHER_TRAIN_CLASS;
            to.ANY_OTHER_TRAIN_SERV = from.ANY_OTHER_TRAIN_SERV;
            to.CONTINUE_AFTER_LAST_TRAIN = from.CONTINUE_AFTER_LAST_TRAIN == null ? null : (from.CONTINUE_AFTER_LAST_TRAIN == true ? "Y" : "N");
            to.NO_OF_10_DAYS = from.NO_OF_10_DAYS;
            to.NO_OF_10_DAYS_OTHER = from.NO_OF_10_DAYS_OTHER;
            to.NO_OF_20_DAYS = from.NO_OF_20_DAYS;
            to.NO_OF_30_DAYS = from.NO_OF_30_DAYS;
            to.NO_OF_45_60_DAYS = from.NO_OF_45_60_DAYS;
            to.NO_OF_EXERCISE_IN_A_DAY = from.NO_OF_EXERCISE_IN_A_DAY;
            to.NO_OF_ONDAY_TRAIN_SERV = from.NO_OF_ONDAY_TRAIN_SERV;
            to.NO_OF_ONEDAY_TRAIN_CLASS = from.NO_OF_ONEDAY_TRAIN_CLASS;
            to.NO_OF_SATIPATHAN = from.NO_OF_SATIPATHAN;
            to.NO_OF_SPECIAL = from.NO_OF_SPECIAL;
            to.NO_OF_TEACH_SELF = from.NO_OF_TEACH_SELF;
            to.TRAIN_AFTER_SATYA = from.TRAIN_AFTER_SATYA == null ? null : (from.TRAIN_AFTER_SATYA == true ? "Y" : "N");
            to.TRAIN_AFTER_SATYA_DETAIL = from.TRAIN_AFTER_SATYA_DETAIL;
        }

        public static AppTrainInfo CopyInfoFromEntity(Application from)
        {
            var to = new AppTrainInfo
            {
                ANY_OTHER_TRAIN_CLASS = @from.ANY_OTHER_TRAIN_CLASS,
                ANY_OTHER_TRAIN_SERV = @from.ANY_OTHER_TRAIN_SERV,
                CONTINUE_AFTER_LAST_TRAIN = @from.CONTINUE_AFTER_LAST_TRAIN == null
                    ? (bool?) null
                    : (@from.CONTINUE_AFTER_LAST_TRAIN.ToUpper() == "Y"),
                NO_OF_10_DAYS = @from.NO_OF_10_DAYS,
                NO_OF_10_DAYS_OTHER = @from.NO_OF_10_DAYS_OTHER,
                NO_OF_20_DAYS = @from.NO_OF_20_DAYS,
                NO_OF_30_DAYS = @from.NO_OF_30_DAYS,
                NO_OF_45_60_DAYS = @from.NO_OF_45_60_DAYS,
                NO_OF_EXERCISE_IN_A_DAY = @from.NO_OF_EXERCISE_IN_A_DAY,
                NO_OF_ONDAY_TRAIN_SERV = @from.NO_OF_ONDAY_TRAIN_SERV,
                NO_OF_ONEDAY_TRAIN_CLASS = @from.NO_OF_ONEDAY_TRAIN_CLASS,
                NO_OF_SATIPATHAN = @from.NO_OF_SATIPATHAN,
                NO_OF_SPECIAL = @from.NO_OF_SPECIAL,
                NO_OF_TEACH_SELF = @from.NO_OF_TEACH_SELF,
                TRAIN_AFTER_SATYA = @from.TRAIN_AFTER_SATYA == null
                    ? (bool?) null
                    : (@from.TRAIN_AFTER_SATYA.ToUpper() == "Y"),
                TRAIN_AFTER_SATYA_DETAIL = @from.TRAIN_AFTER_SATYA_DETAIL
            };
            return to;
        }
    }
}