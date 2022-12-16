using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Table("tbl_t_DQCS_QPIT")]
    public partial class tbl_t_DQCS_QPIT
    {
        [Key]
        public int Id { get; set; }
        public int SupplierId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Time { get; set; }
        [Required]
        [StringLength(30)]
        public string Process { get; set; }
        [Required]
        [StringLength(50)]
        public string ControlNo { get; set; }
        [Required]
        [StringLength(20)]
        public string Result { get; set; }
        [StringLength(30)]
        public string ErrorCode { get; set; }
        [StringLength(100)]
        public string ErrorClass { get; set; }
        [StringLength(100)]
        public string ErrorDetails { get; set; }
        [StringLength(50)]
        public string ErrorAddress { get; set; }
        [StringLength(20)]
        public string ErrorPinNo { get; set; }
        [Required]
        [StringLength(30)]
        public string LineName { get; set; }
        [Required]
        [StringLength(10)]
        public string ShiftName { get; set; }
        [Required]
        [StringLength(20)]
        public string PcNo { get; set; }
        [Required]
        [StringLength(20)]
        public string JigNo { get; set; }
        [Required]
        [StringLength(30)]
        public string PowerBoxNo { get; set; }
        public int SystemProgVer { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal TargetProgramVer { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal ProgVer { get; set; }
        [Required]
        [StringLength(40)]
        public string DetailedSetting { get; set; }
        [Required]
        [StringLength(100)]
        public string FunctionSum { get; set; }
        [Required]
        [StringLength(50)]
        public string OperatorName { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal PasswordVer { get; set; }
    }
}
