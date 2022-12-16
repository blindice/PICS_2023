using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PICS_2023.Model
{
    [Table("tbl_m_DQCS_Notification")]
    public partial class tbl_m_DQCS_Notification
    {
        [Key]
        [StringLength(10)]
        public string UserId { get; set; }
        [Key]
        [StringLength(20)]
        public string ModelCode { get; set; }
    }
}
