using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class ChiTietPhieuNhap
    {
        public int IdchiTietPhieuNhap { get; set; }
        public int? IdphieuNhap { get; set; }
        public int? IdsanPham { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }

        public virtual PhieuNhap? IdphieuNhapNavigation { get; set; }
        public virtual SanPham? IdsanPhamNavigation { get; set; }
    }
}
