using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class PhieuNhap
    {
        public PhieuNhap()
        {
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
            PhieuChis = new HashSet<PhieuChi>();
        }

        public int IdphieuNhap { get; set; }
        public int? IdnhaCungCap { get; set; }
        public int? IdnhanVien { get; set; }
        public DateTime? NgayNhap { get; set; }
        public decimal? TongTien { get; set; }

        public virtual NhaCungCap? IdnhaCungCapNavigation { get; set; }
        public virtual NhanVien? IdnhanVienNavigation { get; set; }
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual ICollection<PhieuChi> PhieuChis { get; set; }
    }
}
