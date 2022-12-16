using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    public partial class tbl_m_DQCS_Supplier
    {
        public tbl_m_DQCS_Supplier()
        {
            tbl_m_DQCS_Models = new HashSet<tbl_m_DQCS_Model>();
        }

        [Key]
        public int SupplierID { get; set; }
        [Required]
        [StringLength(15)]
        public string SupplierCode { get; set; }
        [Required]
        [StringLength(50)]
        public string SupplierName { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [StringLength(100)]
        public string UpdateReason { get; set; }

        [InverseProperty("IDNavigation")]
        public virtual tbl_m_DQCS_SupplierFTP tbl_m_DQCS_SupplierFTP { get; set; }
        [InverseProperty(nameof(tbl_m_DQCS_Model.supplier))]
        public virtual ICollection<tbl_m_DQCS_Model> tbl_m_DQCS_Models { get; set; }
    }
}
