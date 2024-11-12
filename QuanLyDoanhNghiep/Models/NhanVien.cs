using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDonBans = new HashSet<HoaDonBan>();
            PhieuChis = new HashSet<PhieuChi>();
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        public int IdnhanVien { get; set; }
        public string? TenNhanVien { get; set; }
        public string? ChucVu { get; set; }
        public string? PhongBan { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }

        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
        public virtual ICollection<PhieuChi> PhieuChis { get; set; }
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
