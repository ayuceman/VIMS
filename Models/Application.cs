using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bipa.Models
{
    [Table("T_APPLICATION")]
    public class Application
    {
        public string REG_NO { get; set; }//	varchar(15)	Checked
        
        public string APP_NO { get; set; }//varchar(15)	Unchecked
        public DateTime? START_DATE { get; set; }//	date	Unchecked
        public string START_NDATE { get; set; }//	varchar(11)	Checked
        public DateTime? TILL_DATE { get; set; }//date	Checked
        public string TILL_NDATE { get; set; }//varchar(11)	Checked
        public string APP_FNAME { get; set; }//varchar(50)	Checked
        public string APP_MNAME { get; set; }//varchar(50)	Checked
        public string APP_LNAME { get; set; }//	varchar(50)	Checked
        public string APP_ADDR { get; set; }//	varchar(100)	Checked
        public string APP_BUSINESS { get; set; }//	varchar(50)	Checked
        public string APP_EDU { get; set; }//varchar(50)	Checked
        public string APP_HPH_NO { get; set; }//	varchar(50)	Checked
        public string APP_OPH_NO { get; set; }//	varchar(50)	Checked
        public string APP_NPH_NO { get; set; }//	varchar(50)	Checked
        
        public decimal? APP_AGE { get; set; }//decimal(3, 0)	Checked
        public string APP_GENDER { get; set; }//	varchar(10)	Checked
        public DateTime? APP_DOB { get; set; }//	date	Checked
        public string APP_NDOB { get; set; }//	varchar(11)	Checked
        public string APP_EMAIL { get; set; }//varchar(50)	Checked
        public string APP_WITH_F_R { get; set; }//	varchar(5)	Checked
        public string F_R_NAME { get; set; }//varchar(50)	Checked
        public string F_R_RELATION { get; set; }//varchar(50)	Checked
        public string APP_LANG_HINDI { get; set; }//	varchar(5)	Checked
        public string APP_LANG_ENG { get; set; }//varchar(5)	Checked
        public string APP_LANG_NEP { get; set; }//varchar(5)	Checked
        public string APP_LANG_NEWARY { get; set; }//	varchar(5)	Checked
        public string APP_LANG_OTHERS { get; set; }//varchar(50)	Checked
        public string ANY_PREV_TRAINING { get; set; }//	varchar(5)	Checked
        public string APP_DISABILITY { get; set; }//varchar(5)	Checked
        public string APP_DISAB_DETAIL { get; set; }//	varchar(500)	Checked
        public string APP_ANY_PREV_EXP { get; set; }//varchar(5)	Checked
        public string APP_PREV_EXP_DETAIL { get; set; }//varchar(500)	Checked
        public string HOW_U_KNOW_DETAIL { get; set; }//	varchar(500)	Checked
        public string REF_NAME { get; set; }//	varchar(50)	Checked
        public string REF_ADDR { get; set; }//varchar(50)	Checked
        public string REF_PH_NO { get; set; }//	varchar(50)	Checked
        public string REF_LAST_TRAIN_PLACE { get; set; }//	varchar(50)	Checked
        public string REF_LAST_TRAIN_DATE { get; set; }//	varchar(50)	Checked
        public string REF_LAST_TRAIN_TEACH_NAME { get; set; }//	varchar(50)	Checked
        public DateTime? REF_DATE { get; set; }//date	Checked
        public string REF_NDATE { get; set; }//varchar(11)	Checked
        public string READ_ABOUT_BIPA { get; set; }//varchar(5)	Checked
        public string UNDERSTAND_ABOUT_BIPA { get; set; }//varchar(5)	Checked
        public string ABIDE_IN_RULES { get; set; }//varchar(5)	Checked
        public string NO_LEAVE_DURING { get; set; }//varchar(5)	Checked
        public string MAINTAIN_SILENCE { get; set; }//	varchar(5)	Checked
        public string LEAVE_OTHER_EXERCISE { get; set; }//varchar(5)	Checked
        public string SMOKING_HABIT { get; set; }//	varchar(5)	Checked
        public string QUIT_DURING { get; set; }//varchar(5)	Checked
        public string PHYSICAL_ABLE_FOR_TRAIN { get; set; }//varchar(5)	Checked
        public string FIRST_TRAN_NDATE { get; set; }//varchar(11)	Checked
        public string FIRST_TRAIN_PLACE { get; set; }//varchar(50)	Checked
        public string FIRST_TRAIN_TEACH_NAME { get; set; }//varchar(50)	Checked
        public string LAST_TRAN_NDATE { get; set; }//	varchar(11)	Checked
        public string LAST_TRAIN_PLACE { get; set; }//varchar(50)	Checked
        public string LAST_TRAIN_TEACH_NAME { get; set; }//varchar(50)	Checked
        public decimal? NO_OF_ONEDAY_TRAIN_CLASS { get; set; }//decimal(3, 0)	Checked
        public decimal? NO_OF_ONDAY_TRAIN_SERV { get; set; }//decimal(3, 0)	Checked
        public string ANY_OTHER_TRAIN_CLASS { get; set; }//varchar(100)	Checked
        public string ANY_OTHER_TRAIN_SERV { get; set; }//	varchar(100)	Checked
        public string TRAIN_AFTER_SATYA { get; set; }//varchar(5)	Checked
        public string TRAIN_AFTER_SATYA_DETAIL { get; set; }//varchar(500)	Checked
        public string CONTINUE_AFTER_LAST_TRAIN { get; set; }//varchar(5)	Checked
        public decimal? NO_OF_EXERCISE_IN_A_DAY { get; set; }//	decimal(3, 0)	Checked
        public string COME_EARLY_ON_REG_DAY { get; set; }//	varchar(5)	Checked
        public string CAN_YOU_SERVE_IF_NEEDED { get; set; }//	varchar(5)	Checked
        public DateTime? COMING_DATE_IF_PARTIAL { get; set; }//	date	Checked
        public string COMING_NDATE_IF_PARTIAL { get; set; }//	varchar(11)	Checked
        public string COMING_TIME_IF_PARTIAL { get; set; }//	varchar(50)	Checked
        public DateTime? GOING_DATE_IF_PARTIAL { get; set; }//date	Checked
        public string GOING_NDATE_IF_PARTIAL { get; set; }//	varchar(11)	Checked
        public string GOING_TIME_IF_PARTIAL { get; set; }//	varchar(50)	Checked
        public DateTime? REG_DATE { get; set; }//date	Checked
        public string REG_NDATE { get; set; }//varchar(11)	Checked
        public string NAME_FOR_EMERGENCY { get; set; }//varchar(50)	Checked
        public string RELATION_FOR_EMERGENCY { get; set; }//	varchar(20)	Checked
        public string ADDR_FOR_EMERGENCY { get; set; }//varchar(50)	Checked
        public string PH_NO_FOR_EMERGENCY { get; set; }//	varchar(50)	Checked
        public string TRAIN_S_N { get; set; }//	varchar(15)	Unchecked
        public string HOUSE { get; set; }//	varchar(50)	Checked
        public string P_S_N { get; set; }//	varchar(15)	Checked
        public string FOREIGN_Y_N { get; set; }//varchar(3)	Checked
        public string LAST_TRAIN_DATE { get; set; }//varchar(20)	Checked
        public string FIRST_TRAIN_DATE { get; set; }//varchar(20)	Checked
        public string CANCELLED_Y_N { get; set; }//	varchar(3)	Checked
        public string OLD_Y_N { get; set; }//varchar(3)	Checked
        public decimal? NO_OF_10_DAYS { get; set; }//decimal(5, 0)	Checked
        public decimal? NO_OF_10_DAYS_OTHER { get; set; }//decimal(5, 0)	Checked
        public decimal? NO_OF_SATIPATHAN { get; set; }//decimal(5, 0)	Checked
        public decimal? NO_OF_SPECIAL { get; set; }//decimal(5, 0)	Checked
        public decimal? NO_OF_20_DAYS { get; set; }//decimal(5, 0)	Checked
        public decimal? NO_OF_30_DAYS { get; set; }//	decimal(5, 0)	Checked
        public decimal? NO_OF_45_60_DAYS { get; set; }//decimal(5, 0)	Checked
        public decimal? NO_OF_TEACH_SELF { get; set; }//decimal(5, 0)	Checked
        public decimal? NO_OF_SERVICE { get; set; }//decimal(5, 0)	Checked
        public string PERSONAL_IDENTIFICATION_SUMM { get; set; }//varchar(500)	Checked
        public string MARRIED_Y_N { get; set; }//varchar(3)	Checked
        public string F_H_W_NAME { get; set; }//varchar(100)	Checked
        public string F_H_W_EXERCISE { get; set; }//varchar(3)	Checked
        public string EXER_DATE { get; set; }//varchar(15)	Checked
        public string NEW_Y_N { get; set; }//varchar(3)	Checked
        public string NEW_Y_N1 { get; set; }//varchar(3)	Checked
        public string MONK_Y_N { get; set; }//varchar(3)	Checked
        public string CONFIRMED { get; set; }//	varchar(3)	Checked
        public string NEP_NAME { get; set; }//	varchar(100)	Checked
        [Key]
        public int ID { get; set; }//	int	Unchecked
    }
}