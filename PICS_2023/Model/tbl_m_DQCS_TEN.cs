using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Table("tbl_m_DQCS_TEN")]
    public partial class tbl_m_DQCS_TEN
    {
        public tbl_m_DQCS_TEN()
        {
            tbl_m_DQCS_Models = new HashSet<tbl_m_DQCS_Model>();
            tbl_m_DQCS_PartNos = new HashSet<tbl_m_DQCS_PartNo>();
        }

        [Key]
        public int tenID { get; set; }
        [Required]
        [StringLength(20)]
        public string tencode { get; set; }
        [StringLength(20)]
        public string old_ten { get; set; }
        [Required]
        [StringLength(20)]
        public string createdBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime createdDate { get; set; }
        [StringLength(20)]
        public string updatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? updatedDate { get; set; }
        [StringLength(50)]
        public string updateReason { get; set; }

        [InverseProperty(nameof(tbl_m_DQCS_Model.ten))]
        public virtual ICollection<tbl_m_DQCS_Model> tbl_m_DQCS_Models { get; set; }
        [InverseProperty(nameof(tbl_m_DQCS_PartNo.ten))]
        public virtual ICollection<tbl_m_DQCS_PartNo> tbl_m_DQCS_PartNos { get; set; }
    }
}
