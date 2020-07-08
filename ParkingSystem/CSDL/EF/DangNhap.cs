namespace CSDL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangNhap")]
    public partial class DangNhap
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string TaiKhoan { get; set; }

        [StringLength(30)]
        public string MatKhau { get; set; }
    }
}
