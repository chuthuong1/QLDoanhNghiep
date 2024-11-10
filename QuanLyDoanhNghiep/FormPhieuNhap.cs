using QuanLyDoanhNghiep.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep
{
    public partial class FormPhieuNhap : Form
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo phiếu nhập mới
                var phieuNhap = new PhieuNhap
                {
                    NgayNhap = dtpNgayNhap.Value,
                    IdnhaCungCap = db.NhaCungCaps.FirstOrDefault(ncc => ncc.TenNhaCungCap == cbNhaCungCap.Text).IdnhaCungCap,
                    IdnhanVien = db.NhanViens.FirstOrDefault(nv => nv.TenNhanVien == cbNhanVien.Text).IdnhanVien,
                    TongTien = 0 // Cập nhật sau
                };
                db.PhieuNhaps.Add(phieuNhap);
                db.SaveChanges();

                // Tạo chi tiết phiếu nhập
                var chiTiet = new ChiTietPhieuNhap
                {
                    IdphieuNhap = phieuNhap.IdphieuNhap,
                    IdsanPham = db.SanPhams.FirstOrDefault(sp => sp.TenSanPham == cbSanPham.Text).IdsanPham,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    DonGia = decimal.Parse(txtDonGia.Text),
                    ThanhTien = int.Parse(txtSoLuong.Text) * decimal.Parse(txtDonGia.Text)
                };
                db.ChiTietPhieuNhaps.Add(chiTiet);

                // Cập nhật tổng tiền trong phiếu nhập
                phieuNhap.TongTien = chiTiet.ThanhTien;
                db.SaveChanges();

                // Tải lại dữ liệu lên DataGridView
                loadData();
                MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi nhập hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            loadData();
            loadComboBoxData();
        }
        private void loadComboBoxData()
        {
            // Lấy dữ liệu cho ComboBox Nha Cung Cấp
            var nhaCungCapList = db.NhaCungCaps.Select(cc => cc.TenNhaCungCap).ToList();
            cbNhaCungCap.DataSource = nhaCungCapList; ;

            // Lấy dữ liệu cho ComboBox Nhân Viên
            var nhanVienList = db.NhanViens.Select(nv => nv.TenNhanVien).ToList();
            cbNhanVien.DataSource = nhanVienList;
            // sản phẩm
            var sanPhamList = db.SanPhams.Select(sp =>  sp.TenSanPham).ToList();
            cbSanPham.DataSource = sanPhamList; 
        }
        private void loadData()
        {
            try
            {
                var data = (from p in db.PhieuNhaps
                            join c in db.ChiTietPhieuNhaps on p.IdphieuNhap equals c.IdphieuNhap
                            join ncc in db.NhaCungCaps on p.IdnhaCungCap equals ncc.IdnhaCungCap
                            join nv in db.NhanViens on p.IdnhanVien equals nv.IdnhanVien
                            
                            select new
                            {
                                p.NgayNhap,
                                p.IdphieuNhap,
                                nv.TenNhanVien,
                                NhaCungCapTen = ncc.TenNhaCungCap,
                                c.SoLuong,
                                c.DonGia,
                                c.ThanhTien,
                                p.TongTien,
                            }).ToList();

                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi hiển thị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
