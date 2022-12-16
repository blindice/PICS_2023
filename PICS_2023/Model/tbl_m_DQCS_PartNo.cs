using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Table("tbl_m_DQCS_PartNo")]
    public partial class tbl_m_DQCS_PartNo
    {
        public tbl_m_DQCS_PartNo()
        {
            tbl_m_DQCS_Models = new HashSet<tbl_m_DQCS_Model>();
        }

        [Key]
        public int assyID { get; set; }
        [Required]
        [StringLength(20)]
        public string assycode { get; set; }
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
        public int? tenID { get; set; }

        [ForeignKey(nameof(tenID))]
        [InverseProperty(nameof(tbl_m_DQCS_TEN.tbl_m_DQCS_PartNos))]
        public virtual tbl_m_DQCS_TEN ten { get; set; }
        [InverseProperty(nameof(tbl_m_DQCS_Model.assy))]
        public virtual ICollection<tbl_m_DQCS_Model> tbl_m_DQCS_Models { get; set; }
    }
}
