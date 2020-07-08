namespace CSDL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        public int ID { get; set; }

        [StringLength(9)]
        public string BienSoXe { get; set; }

        public DateTime? ThoiGianBatDau { get; set; }

        public DateTime? ThoiGianKetThuc { get; set; }

        [StringLength(30)]
        public string TaiKhoan { get; set; }

        public int? Phi { get; set; }

        [StringLength(30)]
        public string CodeLayXe { get; set; }

        public int? TrangThai { get; set; }

        public virtual TaiKhoan TaiKhoan1 { get; set; }
    }
}
