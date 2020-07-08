namespace CSDL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarParking_CSDL : DbContext
    {
        public CarParking_CSDL()
            : base("name=CarParking_CSDL")
        {
        }

        public virtual DbSet<BaiGiuXe> BaiGiuXes { get; set; }
        public virtual DbSet<ChoGiuXe> ChoGiuXes { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TheRFID> TheRFIDs { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }
        public virtual DbSet<Xe_TaiKhoan> Xe_TaiKhoan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiGiuXe>()
                .HasMany(e => e.ChoGiuXes)
                .WithOptional(e => e.BaiGiuXe)
                .HasForeignKey(e => e.BGX_ID);

            modelBuilder.Entity<ChoGiuXe>()
                .Property(e => e.ViTri)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChoGiuXe>()
                .HasMany(e => e.Xe_TaiKhoan)
                .WithOptional(e => e.ChoGiuXe)
                .HasForeignKey(e => e.ID_Vitri);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.DangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.Xes)
                .WithOptional(e => e.TaiKhoan1)
                .HasForeignKey(e => e.TaiKhoan);

            modelBuilder.Entity<TheRFID>()
                .Property(e => e.MaCode)
                .IsUnicode(false);

            modelBuilder.Entity<TheRFID>()
                .Property(e => e.BienSoXe)
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.BienSoXe)
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.CodeLayXe)
                .IsUnicode(false);

            modelBuilder.Entity<Xe_TaiKhoan>()
                .Property(e => e.BienSoXe)
                .IsUnicode(false);

            modelBuilder.Entity<Xe_TaiKhoan>()
                .Property(e => e.DangNhap)
                .IsUnicode(false);
        }
    }
}
