using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLyDoanhNghiep.Models
{
    public partial class QLDoanhNghiepContext : DbContext
    {
        public QLDoanhNghiepContext()
        {
        }

        public QLDoanhNghiepContext(DbContextOptions<QLDoanhNghiepContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; } = null!;
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; } = null!;
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KiemKeHangHoa> KiemKeHangHoas { get; set; } = null!;
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<PhieuChi> PhieuChis { get; set; } = null!;
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; } = null!;
        public virtual DbSet<PhieuThu> PhieuThus { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-B10O0BS\\THUONG;Database=QLDoanhNghiep;User Id=sa;Password=123;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDonBan>(entity =>
            {
                entity.HasKey(e => e.IdchiTietHdban)
                    .HasName("PK__ChiTietH__22D29C05560A4F77");

                entity.ToTable("ChiTietHoaDonBan");

                entity.Property(e => e.IdchiTietHdban).HasColumnName("IDChiTietHDBan");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdhoaDon).HasColumnName("IDHoaDon");

                entity.Property(e => e.IdsanPham).HasColumnName("IDSanPham");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(29, 2)")
                    .HasComputedColumnSql("([SoLuong]*[DonGia])", false);

                entity.HasOne(d => d.IdhoaDonNavigation)
                    .WithMany(p => p.ChiTietHoaDonBans)
                    .HasForeignKey(d => d.IdhoaDon)
                    .HasConstraintName("FK__ChiTietHo__IDHoa__00200768");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.ChiTietHoaDonBans)
                    .HasForeignKey(d => d.IdsanPham)
                    .HasConstraintName("FK__ChiTietHo__IDSan__01142BA1");
            });

            modelBuilder.Entity<ChiTietPhieuNhap>(entity =>
            {
                entity.HasKey(e => e.IdchiTietPhieuNhap)
                    .HasName("PK__ChiTietP__334DEECB1618BFA5");

                entity.ToTable("ChiTietPhieuNhap");

                entity.Property(e => e.IdchiTietPhieuNhap).HasColumnName("IDChiTietPhieuNhap");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IdphieuNhap).HasColumnName("IDPhieuNhap");

                entity.Property(e => e.IdsanPham).HasColumnName("IDSanPham");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(29, 2)")
                    .HasComputedColumnSql("([SoLuong]*[DonGia])", false);

                entity.HasOne(d => d.IdphieuNhapNavigation)
                    .WithMany(p => p.ChiTietPhieuNhaps)
                    .HasForeignKey(d => d.IdphieuNhap)
                    .HasConstraintName("FK__ChiTietPh__IDPhi__09A971A2");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.ChiTietPhieuNhaps)
                    .HasForeignKey(d => d.IdsanPham)
                    .HasConstraintName("FK__ChiTietPh__IDSan__0A9D95DB");
            });

            modelBuilder.Entity<HoaDonBan>(entity =>
            {
                entity.HasKey(e => e.IdhoaDon)
                    .HasName("PK__HoaDonBa__5B896F496E0EAB75");

                entity.ToTable("HoaDonBan");

                entity.Property(e => e.IdhoaDon).HasColumnName("IDHoaDon");

                entity.Property(e => e.IdkhachHang).HasColumnName("IDKhachHang");

                entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");

                entity.Property(e => e.LoaiThanhToan).HasMaxLength(50);

                entity.Property(e => e.NgayBan).HasColumnType("date");

                entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdkhachHangNavigation)
                    .WithMany(p => p.HoaDonBans)
                    .HasForeignKey(d => d.IdkhachHang)
                    .HasConstraintName("FK__HoaDonBan__IDKha__7C4F7684");

                entity.HasOne(d => d.IdnhanVienNavigation)
                    .WithMany(p => p.HoaDonBans)
                    .HasForeignKey(d => d.IdnhanVien)
                    .HasConstraintName("FK__HoaDonBan__IDNha__7D439ABD");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.IdkhachHang)
                    .HasName("PK__KhachHan__5A7167B55F1FC69C");

                entity.ToTable("KhachHang");

                entity.Property(e => e.IdkhachHang).HasColumnName("IDKhachHang");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.DienThoai).HasMaxLength(15);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.LoaiKhachHang).HasMaxLength(50);

                entity.Property(e => e.TenKhachHang).HasMaxLength(100);
            });

            modelBuilder.Entity<KiemKeHangHoa>(entity =>
            {
                entity.HasKey(e => e.IdkiemKe)
                    .HasName("PK__KiemKeHa__FC949D152AA777F0");

                entity.ToTable("KiemKeHangHoa");

                entity.Property(e => e.IdkiemKe).HasColumnName("IDKiemKe");

                entity.Property(e => e.IdsanPham).HasColumnName("IDSanPham");

                entity.Property(e => e.NgayKiemKe).HasColumnType("date");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.KiemKeHangHoas)
                    .HasForeignKey(d => d.IdsanPham)
                    .HasConstraintName("FK__KiemKeHan__IDSan__0D7A0286");
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.IdnhaCungCap)
                    .HasName("PK__NhaCungC__47B484CD7E509581");

                entity.ToTable("NhaCungCap");

                entity.Property(e => e.IdnhaCungCap).HasColumnName("IDNhaCungCap");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.DienThoai).HasMaxLength(15);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.TenNhaCungCap).HasMaxLength(100);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdnhanVien)
                    .HasName("PK__NhanVien__7AC2D9F7E5904DD2");

                entity.ToTable("NhanVien");

                entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");

                entity.Property(e => e.ChucVu).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.DienThoai).HasMaxLength(15);

                entity.Property(e => e.PhongBan).HasMaxLength(50);

                entity.Property(e => e.TenNhanVien).HasMaxLength(100);
            });

            modelBuilder.Entity<PhieuChi>(entity =>
            {
                entity.HasKey(e => e.IdphieuChi)
                    .HasName("PK__PhieuChi__41A551EBD473260D");

                entity.ToTable("PhieuChi");

                entity.Property(e => e.IdphieuChi).HasColumnName("IDPhieuChi");

                entity.Property(e => e.IdphieuNhap).HasColumnName("IDPhieuNhap");

                entity.Property(e => e.LoaiThanhToan).HasMaxLength(50);

                entity.Property(e => e.NgayChi).HasColumnType("date");

                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdphieuNhapNavigation)
                    .WithMany(p => p.PhieuChis)
                    .HasForeignKey(d => d.IdphieuNhap)
                    .HasConstraintName("FK__PhieuChi__IDPhie__1332DBDC");
            });

            modelBuilder.Entity<PhieuNhap>(entity =>
            {
                entity.HasKey(e => e.IdphieuNhap)
                    .HasName("PK__PhieuNha__4A581F6D23A9455B");

                entity.ToTable("PhieuNhap");

                entity.Property(e => e.IdphieuNhap).HasColumnName("IDPhieuNhap");

                entity.Property(e => e.IdnhaCungCap).HasColumnName("IDNhaCungCap");

                entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");

                entity.Property(e => e.NgayNhap).HasColumnType("date");

                entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdnhaCungCapNavigation)
                    .WithMany(p => p.PhieuNhaps)
                    .HasForeignKey(d => d.IdnhaCungCap)
                    .HasConstraintName("FK__PhieuNhap__IDNha__05D8E0BE");

                entity.HasOne(d => d.IdnhanVienNavigation)
                    .WithMany(p => p.PhieuNhaps)
                    .HasForeignKey(d => d.IdnhanVien)
                    .HasConstraintName("FK__PhieuNhap__IDNha__06CD04F7");
            });

            modelBuilder.Entity<PhieuThu>(entity =>
            {
                entity.HasKey(e => e.IdphieuThu)
                    .HasName("PK__PhieuThu__4AAF5481584BFED5");

                entity.ToTable("PhieuThu");

                entity.Property(e => e.IdphieuThu).HasColumnName("IDPhieuThu");

                entity.Property(e => e.IdhoaDon).HasColumnName("IDHoaDon");

                entity.Property(e => e.LoaiThanhToan).HasMaxLength(50);

                entity.Property(e => e.NgayThu).HasColumnType("date");

                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdhoaDonNavigation)
                    .WithMany(p => p.PhieuThus)
                    .HasForeignKey(d => d.IdhoaDon)
                    .HasConstraintName("FK__PhieuThu__IDHoaD__10566F31");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.IdsanPham)
                    .HasName("PK__SanPham__9D45E58A552D1127");

                entity.ToTable("SanPham");

                entity.Property(e => e.IdsanPham).HasColumnName("IDSanPham");

                entity.Property(e => e.ChuLoai).HasMaxLength(50);

                entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TenSanPham).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
