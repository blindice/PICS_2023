using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Index(nameof(UserName), Name = "unique_username", IsUnique = true)]
    public partial class tbl_m_user
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [StringLength(100)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        public int? Role_Id { get; set; }
        public int? Type_Id { get; set; }
        public int? Supplier_Id { get; set; }
    }
}
