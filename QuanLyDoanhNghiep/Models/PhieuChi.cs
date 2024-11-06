using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class PhieuChi
    {
        public int IdphieuChi { get; set; }
        public int? IdphieuNhap { get; set; }
        public DateTime? NgayChi { get; set; }
        public decimal? SoTien { get; set; }
        public string? LoaiThanhToan { get; set; }

        public virtual PhieuNhap? IdphieuNhapNavigation { get; set; }
    }
}
