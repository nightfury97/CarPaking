namespace CSDL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Xe_TaiKhoan
    {
        public int ID { get; set; }

        [StringLength(9)]
        public string BienSoXe { get; set; }

        [StringLength(30)]
        public string DangNhap { get; set; }

        public int? TrangThai { get; set; }

        public DateTime? ThoiGianDatCho { get; set; }

        public int? ID_Vitri { get; set; }

        public virtual ChoGiuXe ChoGiuXe { get; set; }
    }
}
