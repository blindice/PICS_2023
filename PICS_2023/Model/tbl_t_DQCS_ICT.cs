using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Table("tbl_t_DQCS_ICT")]
    public partial class tbl_t_DQCS_ICT
    {
        [Key]
        public int Id { get; set; }
        public int No { get; set; }
        [Required]
        [StringLength(30)]
        public string Mode { get; set; }
        [Required]
        [StringLength(30)]
        public string Device { get; set; }
        [Required]
        [StringLength(30)]
        public string Actual { get; set; }
        [Required]
        [StringLength(30)]
        public string Refer { get; set; }
        [Required]
        [StringLength(30)]
        public string Measure { get; set; }
        [StringLength(30)]
        public string MinLimit { get; set; }
        public int? MinLimitValue { get; set; }
        [StringLength(30)]
        public string MaxLimit { get; set; }
        public int? MaxLimitValue { get; set; }
        [StringLength(30)]
        public string Offset { get; set; }
        public int? Delay { get; set; }
        [StringLength(30)]
        public string Bias { get; set; }
        public int HPin { get; set; }
        public int LPin { get; set; }
        public int? G1 { get; set; }
        public int? G2 { get; set; }
        public int? G3 { get; set; }
        public int? G4 { get; set; }
        public int? G5 { get; set; }
        [Required]
        [StringLength(30)]
        public string Loc { get; set; }
    }
}
