using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Bipa.Models
{
    public class ReferralList
    {
        [Key]
        [StringLength(100)]
        public string RecordID
        {
            get;
            set;
        } 
        [Display(Name = "Application no")]
        [Required]
        public string APP_NO { get; set; }//varchar(15)	Unchecked
       
        [Display(Name = "Train SN")]
        [Required]
        public string TRAIN_S_N { get; set; }//	varchar(15)	Unchecked
       
        [Display(Name = "Code")]
        [StringLength(10)]
        public string CodeID { get; set; }

        [Display(Name = "Departure Day")]
        
        public int? DepDay { get; set; }


        [Display(Name = "Case Description")]
        [StringLength(int.MaxValue)]
        public string CaseDesc { get; set; }

        [Display(Name = "Remarks")]
        [StringLength(int.MaxValue)]
        public string Remarks { get; set; }



    }
}