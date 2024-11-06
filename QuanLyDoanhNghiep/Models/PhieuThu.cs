using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class PhieuThu
    {
        public int IdphieuThu { get; set; }
        public int? IdhoaDon { get; set; }
        public DateTime? NgayThu { get; set; }
        public decimal? SoTien { get; set; }
        public string? LoaiThanhToan { get; set; }

        public virtual HoaDonBan? IdhoaDonNavigation { get; set; }
    }
}
