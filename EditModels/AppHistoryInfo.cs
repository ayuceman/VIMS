using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bipa.Models;

namespace Bipa.EditModels
{
    public class AppHistoryInfo
    {
        [Key]
        public int ID { get; set; }
        [Display(Name="Any Previous Training")]
        public bool? ANY_PREV_TRAINING { get; set; }//	varchar(5)	Checked
        [Display(Name = "Any Previous Experience")]
        public bool? APP_ANY_PREV_EXP { get; set; }//varchar(5)	Checked
        [Display(Name = "First Train Place")]
        [StringLength(50)]
        public string FIRST_TRAIN_PLACE { get; set; }//varchar(50)	Checked
        [Display(Name = "Frist Teacher Name")]
        [StringLength(50)]
        public string FIRST_TRAIN_TEACH_NAME { get; set; }//varchar(50)	Checked
        [Display(Name = "First Train Date")]
        [StringLength(20)]
        public string FIRST_TRAIN_DATE { get; set; }//varchar(20)	Checked
        [Display(Name = "Last Train Place")]
        [StringLength(50)]
        public string LAST_TRAIN_PLACE { get; set; }//varchar(50)	Checked
        [Display(Name = "Last Training Teacher Name")]
        [StringLength(50)]
        public string LAST_TRAIN_TEACH_NAME { get; set; }//varchar(50)	Checked
        [Display(Name = "Last Train Date")]
        [StringLength(20)]
        public string LAST_TRAIN_DATE { get; set; }//varchar(20)	Checked
        [Display(Name = "Previous Experience Detail")]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string APP_PREV_EXP_DETAIL { get; set; }//varchar(500)	Checked
        public static void CopyInfoToEntity(AppHistoryInfo from, Application to)
        {
            if (from == null || to == null) { return; }
            to.ANY_PREV_TRAINING = from.ANY_PREV_TRAINING == null ? null : (from.ANY_PREV_TRAINING == true ? "Y" : "N");
            to.APP_ANY_PREV_EXP = from.APP_ANY_PREV_EXP == null ? null : (from.APP_ANY_PREV_EXP == true ? "Y" : "N");
            to.APP_PREV_EXP_DETAIL = from.APP_PREV_EXP_DETAIL;
            to.FIRST_TRAIN_DATE = from.FIRST_TRAIN_DATE;
            to.FIRST_TRAIN_PLACE = from.FIRST_TRAIN_PLACE;
            to.FIRST_TRAIN_TEACH_NAME = from.FIRST_TRAIN_TEACH_NAME;
            to.LAST_TRAIN_DATE = from.LAST_TRAIN_DATE;
            to.LAST_TRAIN_PLACE = from.LAST_TRAIN_PLACE;
            to.LAST_TRAIN_TEACH_NAME = from.LAST_TRAIN_TEACH_NAME;
            
        }
        public static AppHistoryInfo CopyInfoFromEntity(Application from)
        {
            var to = new AppHistoryInfo
            {
                ANY_PREV_TRAINING =
                    @from.APP_DISABILITY == null ? (bool?) null : (@from.ANY_PREV_TRAINING.ToUpper() == "Y"),
                APP_ANY_PREV_EXP =
                    @from.APP_ANY_PREV_EXP == null ? (bool?)null : (@from.APP_ANY_PREV_EXP.ToUpper() == "Y"),
                APP_PREV_EXP_DETAIL = @from.APP_PREV_EXP_DETAIL,
                FIRST_TRAIN_DATE = @from.FIRST_TRAIN_DATE,
                FIRST_TRAIN_PLACE = @from.FIRST_TRAIN_PLACE,
                FIRST_TRAIN_TEACH_NAME = @from.FIRST_TRAIN_TEACH_NAME,
                LAST_TRAIN_DATE = @from.LAST_TRAIN_DATE,
                LAST_TRAIN_PLACE = @from.LAST_TRAIN_PLACE,
                LAST_TRAIN_TEACH_NAME = @from.LAST_TRAIN_TEACH_NAME
            };
            return to;
        }
    }
}