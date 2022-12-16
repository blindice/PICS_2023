using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Keyless]
    [Table("TBL_M_USERMASTER")]
    public partial class TBL_M_USERMASTER
    {
        [StringLength(50)]
        public string EmployeeNo { get; set; }
        [StringLength(50)]
        public string APOAccount { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string MiddleName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Position { get; set; }
        [StringLength(50)]
        public string Grade { get; set; }
        [StringLength(100)]
        public string SectionName { get; set; }
        [StringLength(100)]
        public string DepartmentName { get; set; }
        [StringLength(100)]
        public string DivisionName { get; set; }
        [StringLength(50)]
        public string CostCenterCode { get; set; }
        [StringLength(50)]
        public string BirthDate { get; set; }
        [StringLength(100)]
        public string EmailAddress { get; set; }
        [StringLength(50)]
        public string NickName { get; set; }
        [StringLength(50)]
        public string EmploymentStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateHired { get; set; }
        public int? RoleID { get; set; }
        public int? JPFlag { get; set; }
        [StringLength(20)]
        public string SupplierCode { get; set; }
        public short FailCount { get; set; }
        public short EnableFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }
    }
}
