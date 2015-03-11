using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bipa.Models
{
    public class CodeTable
    {
       [Key]
       [Display(Name = "Code")]
       [StringLength(10)]
        public string CodeID { get; set; }

         
       [Display(Name = "Code Type")]
       [StringLength(1)]
       public string CodeType { get; set; }
       [Display(Name = "Code Severity")]
     
       public int? CodeSeverity { get; set; }
         [Display(Name = "Code Description")]
       public string CodeDescription { get; set; }

    }
}