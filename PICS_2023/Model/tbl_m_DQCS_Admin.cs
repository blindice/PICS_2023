using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Table("tbl_m_DQCS_Admin")]
    public partial class tbl_m_DQCS_Admin
    {
        [Key]
        [StringLength(20)]
        public string username { get; set; }
        [Required]
        [StringLength(20)]
        public string createBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime createdDate { get; set; }
        [StringLength(20)]
        public string updatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? updatedDate { get; set; }
    }
}
