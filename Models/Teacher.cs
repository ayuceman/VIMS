using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bipa.Models
{
    [Table("T_TEACHER")]
    public class Teacher
    {
        [Key]
        public int ID { get; set; }	//int?	Unchecked
        [Required]
        [StringLength(10)]
        [DisplayName("Teacher Id")]
        public string TID { get; set; }	//varchar(15)	Unchecked
        [DisplayName("Student Id")]
        [StringLength(10)]
        public string SID { get; set; }	//varchar(15)	Checked
        [DisplayName("Designation")]
        [StringLength(50)]
        public string DEGIGNATION { get; set; }	//varchar(50)	Checked
        [Required]
        [DisplayName("First Name")]
        [StringLength(50)]
        public string FNAME { get; set; }	//	varchar(50)	Checked
        [DisplayName("Middle Name")]
        [StringLength(50)]
        public string MNAME { get; set; }	//	varchar(50)	Checked
        [DisplayName("Last Name")]
        [StringLength(50)]
        public string LNAME { get; set; }	//	varchar(50)	Checked
        [DisplayName("Date of Birth")]
        public DateTime? DOB { get; set; }	//	date	Checked
        [DisplayName("Date of Birth (Nepali)")]
        public string NDOB { get; set; }	//	varchar(12)	Checked
        [DisplayName("Occupation")]
        [StringLength(50)]
        public string OCC { get; set; }	//	varchar(50)	Checked
        [DisplayName("Education")]
        [StringLength(50)]
        public string EDUCATION { get; set; }	//	varchar(50)	Checked
        [DisplayName("Address")]
        [StringLength(50)]
        public string ADDR { get; set; }	//	varchar(50)	Checked
        [DisplayName("Telephone 1")]
        [Phone]
        [StringLength(50)]
        public string TEL1 { get; set; }	//	varchar(50)	Checked
        [Phone]
        [DisplayName("Telephone 2")]
        [StringLength(50)]
        public string TEL2 { get; set; }	//varchar(50)	Checked
        [DisplayName("Email")]
        [EmailAddress]
        [StringLength(50)]
        public string EMAIL { get; set; }	//	varchar(50)	Checked
        [DisplayName("Remarks")]
        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        public string REMARKS { get; set; }	//varchar(100)	Checked
        [DisplayName("10 days Special")]
        public int? TENSP { get; set; }	//	decimal(18, 0)	Checked
        [DisplayName("10 days Special with Guru")]
        public int? TENSNG { get; set; }	//	decimal(18, 0)	Checked
        [DisplayName("10 days")]
        public int? TEN { get; set; }	//decimal(18, 0)	Checked
        [DisplayName("7 days")]
        public int? SEVEN { get; set; }	//	decimal(18, 0)	Checked
        [DisplayName("20 days")]
        public int? TWENTY { get; set; }	//decimal(18, 0)	Checked
        [DisplayName("30 days")]
        public int? THIRTY { get; set; }	//decimal(18, 0)	Checked
        [DisplayName("45 days")]
        public int? FOURTYFIVE { get; set; }	//	decimal(18, 0)	Checked
        [DisplayName("60 days")]
        public int? SIXTY { get; set; }	//	decimal(18, 0)	Checked
        [DisplayName("Teacher special 45 days")]
        public int? TSC45 { get; set; }	//decimal(18, 0)	Checked
        [DisplayName("Teacher special 30")]
        public int? TSC30 { get; set; }	//decimal(18, 0)	Checked
        [DisplayName("Served")]
        public int? SERVED { get; set; }	//	decimal(18, 0)	Checked
        [DisplayName("Introduced By")]
        [StringLength(50)]
        public string INTRODUCEDBY { get; set; }	//	varchar(50)	Checked
        [DisplayName("Sex")]
        [StringLength(10)]
        public string SEX { get; set; }	//	varchar(10)	Checked
        [DisplayName("From")]
        [StringLength(50)]
        public string FROMS { get; set; }	//	varchar(50)	Checked
        [DisplayName("Application Date (Nepali)")]
        public string APP_NDATE { get; set; }	//	varchar(11)	Checked
        [DisplayName("Application Date")]
        public DateTime? APP_DATE { get; set; }	//date	Checked
        
    }
}