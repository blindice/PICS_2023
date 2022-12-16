using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Table("tbl_m_DQCS_SupplierFTP")]
    public partial class tbl_m_DQCS_SupplierFTP
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string ftpServer { get; set; }
        [StringLength(10)]
        public string ftpPort { get; set; }
        [StringLength(100)]
        public string ftpUser { get; set; }
        [StringLength(20)]
        public string ftpPassword { get; set; }
        [Required]
        [StringLength(100)]
        public string ftpUpload { get; set; }
        [Required]
        [StringLength(100)]
        public string ftpDownload { get; set; }
        [Required]
        [StringLength(20)]
        public string createdBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime createdDate { get; set; }
        [StringLength(20)]
        public string updatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? updatedDate { get; set; }

        [ForeignKey(nameof(ID))]
        [InverseProperty(nameof(tbl_m_DQCS_Supplier.tbl_m_DQCS_SupplierFTP))]
        public virtual tbl_m_DQCS_Supplier IDNavigation { get; set; }
    }
}
