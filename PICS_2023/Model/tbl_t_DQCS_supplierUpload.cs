using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Table("tbl_t_DQCS_supplierUpload")]
    [Index(nameof(supplier), nameof(part_name), nameof(upload_date), Name = "NIX_SupplierPartNameUploadDate_incEPPIJudge")]
    [Index(nameof(upload_date), Name = "NIX_uploadDate")]
    public partial class tbl_t_DQCS_supplierUpload
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string no { get; set; }
        [Required]
        [StringLength(50)]
        public string supplier { get; set; }
        [StringLength(50)]
        public string ten_no { get; set; }
        [Required]
        [StringLength(50)]
        public string part_name { get; set; }
        [Required]
        [StringLength(50)]
        public string assy_code { get; set; }
        [Required]
        [StringLength(50)]
        public string shipment_lot_no_15_char { get; set; }
        [Required]
        [StringLength(50)]
        public string lot_no_serial_on_board { get; set; }
        public int? qty { get; set; }
        [StringLength(10)]
        public string smt_line_bottom_b_side { get; set; }
        [StringLength(10)]
        public string smt_line_top_a_side { get; set; }
        [StringLength(50)]
        public string be_line { get; set; }
        public DateTime? smt_aoi_date_bottom { get; set; }
        public DateTime? smt_vi_date_bottom { get; set; }
        public DateTime? smt_aoi_date_top { get; set; }
        public DateTime? smt_vi_date_top { get; set; }
        public DateTime? smt_aoi_time_bottom { get; set; }
        public DateTime? smt_vi_time_bottom { get; set; }
        public DateTime? smt_aoi_time_top { get; set; }
        public DateTime? smt_vi_time_top { get; set; }
        [StringLength(50)]
        public string smt_aoi_bottom { get; set; }
        [StringLength(50)]
        public string smt_vi_bottom { get; set; }
        [StringLength(50)]
        public string smt_aoi_top { get; set; }
        [StringLength(50)]
        public string smt_vi_top { get; set; }
        public DateTime? ict_date { get; set; }
        public DateTime? qpit_date { get; set; }
        public DateTime? aoi_hw_date_top { get; set; }
        public DateTime? aoi_hw_date_bottom { get; set; }
        public DateTime? fvi_date { get; set; }
        public DateTime? oqc_date { get; set; }
        public DateTime? ict_time { get; set; }
        public DateTime? qpit_time { get; set; }
        public DateTime? aoi_hw_time_top { get; set; }
        public DateTime? aoi_hw_time_bottom { get; set; }
        public DateTime? fvi_time { get; set; }
        public DateTime? oqc_time { get; set; }
        [StringLength(50)]
        public string ict { get; set; }
        [StringLength(50)]
        public string qpit { get; set; }
        [StringLength(50)]
        public string aoi_hw_bottom { get; set; }
        [StringLength(50)]
        public string aoi_hw_top { get; set; }
        [StringLength(50)]
        public string fvi { get; set; }
        [StringLength(50)]
        public string oba { get; set; }
        [StringLength(50)]
        public string judgement { get; set; }
        public DateTime? judge_date { get; set; }
        [StringLength(50)]
        public string system_judge { get; set; }
        [StringLength(50)]
        public string eppi_judge { get; set; }
        public string cause_ipd { get; set; }
        public string action_ipd { get; set; }
        [StringLength(50)]
        public string defect { get; set; }
        [StringLength(50)]
        public string location { get; set; }
        [StringLength(50)]
        public string action_repair { get; set; }
        [StringLength(50)]
        public string ict_reprocess { get; set; }
        [StringLength(50)]
        public string qpit_reprocess { get; set; }
        [StringLength(50)]
        public string aoi_hw_top_reprocess { get; set; }
        [StringLength(50)]
        public string aoi_hw_bottom_reprocess { get; set; }
        [StringLength(50)]
        public string fvi_reprocess { get; set; }
        [StringLength(50)]
        public string oba_reprocess { get; set; }
        [StringLength(50)]
        public string remarks { get; set; }
        public DateTime upload_date { get; set; }
        [StringLength(50)]
        public string eppi_remarks { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? hold_date { get; set; }
        [StringLength(50)]
        public string hold_judge { get; set; }
    }
}
