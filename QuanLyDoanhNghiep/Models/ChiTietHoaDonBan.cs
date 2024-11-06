using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class ChiTietHoaDonBan
    {
        public int IdchiTietHdban { get; set; }
        public int? IdhoaDon { get; set; }
        public int? IdsanPham { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }

        public virtual HoaDonBan? IdhoaDonNavigation { get; set; }
        public virtual SanPham? IdsanPhamNavigation { get; set; }
    }
}
