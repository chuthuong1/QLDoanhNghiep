using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class HoaDonBan
    {
        public HoaDonBan()
        {
            ChiTietHoaDonBans = new HashSet<ChiTietHoaDonBan>();
            PhieuThus = new HashSet<PhieuThu>();
        }

        public int IdhoaDon { get; set; }
        public int? IdkhachHang { get; set; }
        public int? IdnhanVien { get; set; }
        public DateTime? NgayBan { get; set; }
        public decimal? TongTien { get; set; }
        public string? LoaiThanhToan { get; set; }

        public virtual KhachHang? IdkhachHangNavigation { get; set; }
        public virtual NhanVien? IdnhanVienNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; }
        public virtual ICollection<PhieuThu> PhieuThus { get; set; }
    }
}
