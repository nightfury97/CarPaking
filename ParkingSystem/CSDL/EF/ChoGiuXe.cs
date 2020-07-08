namespace CSDL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChoGiuXe")]
    public partial class ChoGiuXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChoGiuXe()
        {
            Xe_TaiKhoan = new HashSet<Xe_TaiKhoan>();
        }

        public int ID { get; set; }

        public int? BGX_ID { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(4)]
        public string ViTri { get; set; }

        public virtual BaiGiuXe BaiGiuXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xe_TaiKhoan> Xe_TaiKhoan { get; set; }
    }
}
