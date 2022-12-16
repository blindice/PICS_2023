using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    public partial class tbl_m_DQCS_Model
    {
        [Key]
        public int modelID { get; set; }
        public int supplierID { get; set; }
        [Required]
        [StringLength(20)]
        public string modelcode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? createdDate { get; set; }
        [StringLength(50)]
        public string createdBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? updatedDate { get; set; }
        [StringLength(50)]
        public string updatedBy { get; set; }
        [StringLength(100)]
        public string UpdateReason { get; set; }
        public int? tenID { get; set; }
        public int? assyID { get; set; }

        [ForeignKey(nameof(assyID))]
        [InverseProperty(nameof(tbl_m_DQCS_PartNo.tbl_m_DQCS_Models))]
        public virtual tbl_m_DQCS_PartNo assy { get; set; }
        [ForeignKey(nameof(supplierID))]
        [InverseProperty(nameof(tbl_m_DQCS_Supplier.tbl_m_DQCS_Models))]
        public virtual tbl_m_DQCS_Supplier supplier { get; set; }
        [ForeignKey(nameof(tenID))]
        [InverseProperty(nameof(tbl_m_DQCS_TEN.tbl_m_DQCS_Models))]
        public virtual tbl_m_DQCS_TEN ten { get; set; }
    }
}
