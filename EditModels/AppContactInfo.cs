using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bipa.Models;

namespace Bipa.EditModels
{
    public class AppContactInfo
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        [Display(Name = "Address")]
        public string APP_ADDR { get; set; }//	varchar(100)	Checked
        [StringLength(50)]
        [Display(Name = "Home Phone")]
        public string APP_HPH_NO { get; set; }//	varchar(50)	Checked
        [StringLength(50)]
        [Display(Name = "Office Phone")]
        public string APP_OPH_NO { get; set; }//	varchar(50)	Checked
        [StringLength(50)]
        [Display(Name = "N Phone No")]
        public string APP_NPH_NO { get; set; }//	varchar(50)	Checked
        [StringLength(50)]
        [Display(Name = "Email")]
        public string APP_EMAIL { get; set; }//varchar(50)	Checked
        [StringLength(50)]

        [Display(Name = "Refrence Name")]
        public string REF_NAME { get; set; }//	varchar(50)	Checked
        [StringLength(50)]
        [Display(Name = "Refrence Address")]
        public string REF_ADDR { get; set; }//varchar(50)	Checked
        [StringLength(50)]
        [Display(Name = "Refrence Phone No")]
        public string REF_PH_NO { get; set; }//	varchar(50)	Checked
        
        [Display(Name = "Refrence Date")]
        public DateTime? REF_DATE { get; set; }//date	Checked

        [StringLength(50)]
        [Display(Name = "Name for Emergency")]
        public string NAME_FOR_EMERGENCY { get; set; }//varchar(50)	Checked
        [StringLength(20)]
        [Display(Name = "Relation")]
        public string RELATION_FOR_EMERGENCY { get; set; }//	varchar(20)	Checked
        [StringLength(50)]
        [Display(Name = "Address")]
        public string ADDR_FOR_EMERGENCY { get; set; }//varchar(50)	Checked
        [StringLength(50)]
        [Display(Name = "Phone")]
        public string PH_NO_FOR_EMERGENCY { get; set; }//	varchar(50)	Checked

        public static void CopyToEntity(AppContactInfo from, Application to)
        {
            if (from == null || to == null) return;
            to.ADDR_FOR_EMERGENCY = from.ADDR_FOR_EMERGENCY;
            to.APP_ADDR=from.APP_ADDR;
            to.APP_EMAIL=from.APP_EMAIL;
            to.APP_HPH_NO=from.APP_HPH_NO;
            to.APP_NPH_NO=from.APP_NPH_NO;
            to.APP_OPH_NO=from.APP_OPH_NO;
            to.NAME_FOR_EMERGENCY=from.NAME_FOR_EMERGENCY;
            to.PH_NO_FOR_EMERGENCY=from.PH_NO_FOR_EMERGENCY;
            to.REF_ADDR=from.REF_ADDR;
            to.REF_DATE=from.REF_DATE;
            to.REF_NAME=from.REF_NAME;
            to.REF_PH_NO=from.REF_PH_NO;
            to.RELATION_FOR_EMERGENCY=from.RELATION_FOR_EMERGENCY;
        }
    }
}