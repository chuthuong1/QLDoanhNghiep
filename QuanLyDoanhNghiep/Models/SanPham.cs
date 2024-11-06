using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietHoaDonBans = new HashSet<ChiTietHoaDonBan>();
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
            KiemKeHangHoas = new HashSet<KiemKeHangHoa>();
        }

        public int IdsanPham { get; set; }
        public string? TenSanPham { get; set; }
        public string? ChuLoai { get; set; }
        public decimal? Gia { get; set; }
        public int? SoLuongTonKho { get; set; }

        public virtual ICollection<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; }
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual ICollection<KiemKeHangHoa> KiemKeHangHoas { get; set; }
    }
}
