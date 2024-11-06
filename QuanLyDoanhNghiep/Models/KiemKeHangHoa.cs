using System;
using System.Collections.Generic;

namespace QuanLyDoanhNghiep.Models
{
    public partial class KiemKeHangHoa
    {
        public int IdkiemKe { get; set; }
        public int? IdsanPham { get; set; }
        public int? SoLuongTonKho { get; set; }
        public DateTime? NgayKiemKe { get; set; }

        public virtual SanPham? IdsanPhamNavigation { get; set; }
    }
}
