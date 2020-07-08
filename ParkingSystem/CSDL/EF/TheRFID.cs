namespace CSDL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheRFID")]
    public partial class TheRFID
    {
        [Key]
        [StringLength(30)]
        public string MaCode { get; set; }

        [StringLength(15)]
        public string BienSoXe { get; set; }

        public int? TrangThai { get; set; }

        public DateTime? ThoiGianBatDau { get; set; }

        public DateTime? ThoiGianKetThuc { get; set; }
    }
}
