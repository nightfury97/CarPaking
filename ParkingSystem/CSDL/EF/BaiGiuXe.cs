namespace CSDL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiGiuXe")]
    public partial class BaiGiuXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiGiuXe()
        {
            ChoGiuXes = new HashSet<ChoGiuXe>();
        }

        public int ID { get; set; }

        [StringLength(120)]
        public string Ten { get; set; }

        public int? TongSoCho { get; set; }

        public int? DaCoXe { get; set; }

        public int? DatTruoc { get; set; }

        [StringLength(120)]
        public string DiaDiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChoGiuXe> ChoGiuXes { get; set; }
    }
}
