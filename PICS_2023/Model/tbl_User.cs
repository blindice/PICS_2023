using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    public partial class tbl_User
    {
        [Key]
        [StringLength(50)]
        public string UserID { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(100)]
        public string Fullname { get; set; }
        [StringLength(100)]
        public string SectionName { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(100)]
        public string DivisionName { get; set; }
        public bool? StaffFlag { get; set; }
        public bool? SVFlag { get; set; }
        public bool? AMGMGFlag { get; set; }
        public bool? DMGFlag { get; set; }
        [Required]
        [StringLength(200)]
        public string EmailAddress { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
