using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDonBans = new HashSet<HoaDonBan>();
        }

        public int IdkhachHang { get; set; }
        public string? TenKhachHang { get; set; }
        public string? LoaiKhachHang { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}
