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
using System.Xml.Linq;

namespace QuanLyDoanhNghiep
{
    public partial class FormOrder : Form
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();

        private int idSanPham;
        public FormOrder(string tenSanPham, int soLuongConLai, decimal donGia, int idSanPham)
        {
            InitializeComponent();
            txtTenSanPham.Text = tenSanPham;
            txtSoLuong.Text = soLuongConLai.ToString();
            txtDonGia.Text = donGia.ToString("F2");
            this.idSanPham = idSanPham; 
            CalculateThanhTien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from form controls
                string tenKhachHang = txtTenkhachHang.Text;  // Customer name entered by user
                int soLuongMua = string.IsNullOrWhiteSpace(txtSoLuongMua.Text) ? 0 : int.Parse(txtSoLuongMua.Text);
                decimal donGia = string.IsNullOrWhiteSpace(txtDonGia.Text) ? 0 : decimal.Parse(txtDonGia.Text);
                decimal thanhTien = string.IsNullOrWhiteSpace(txtThanhTien.Text) ? 0 : decimal.Parse(txtThanhTien.Text);

                int idNhanVien = (int)cbNhanVienThanhToan.SelectedValue;  // Get selected employee ID from ComboBox
                string loaiThanhToan = cbLoaiThanhToan.SelectedItem.ToString();  // Get payment method from ComboBox
                DateTime ngayThanhToan = dtpNgayThanhToan.Value;  // Get payment date from DateTimePicker

                // Step 1: Check if the customer exists in the database, otherwise create a new one
                KhachHang khachHang = db.KhachHangs.FirstOrDefault(kh => kh.TenKhachHang == tenKhachHang);

                if (khachHang == null)
                {
                    // If the customer doesn't exist, create a new record
                    khachHang = new KhachHang()
                    {
                        TenKhachHang = tenKhachHang
                    };

                    db.KhachHangs.Add(khachHang);
                    db.SaveChanges();  // Save the new customer to get the IDKhachHang
                }

                // Step 2: Create a new HoaDonBan (Invoice)
                HoaDonBan hoaDon = new HoaDonBan()
                {
                    IdkhachHang = khachHang.IdkhachHang,  // Set the customer ID
                    IdnhanVien = idNhanVien,
                    NgayBan = ngayThanhToan,
                    TongTien = thanhTien,
                    LoaiThanhToan = loaiThanhToan
                };
                db.HoaDonBans.Add(hoaDon);
                db.SaveChanges();  // Save HoaDonBan to get the IDHoaDon

                // Step 3: Add details to ChiTietHoaDonBan
                ChiTietHoaDonBan chiTietHoaDon = new ChiTietHoaDonBan()
                {
                    IdhoaDon = hoaDon.IdhoaDon,  // Set the generated HoaDon ID
                    IdsanPham = this.idSanPham,  // Use actual product ID (replace 1 with dynamic product ID from UI)
                    SoLuong = soLuongMua,
                    DonGia = donGia,
                    ThanhTien = soLuongMua * donGia  // Calculate total price
                };

                db.ChiTietHoaDonBans.Add(chiTietHoaDon);
                db.SaveChanges();  // Save the details to ChiTietHoaDonBan

                MessageBox.Show("Thanh toán thành công và hóa đơn đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LoadComboBoxes()
        {

            try
            {
                cbLoaiThanhToan.Items.Clear();
                cbLoaiThanhToan.Items.Add("Tiền Mặt");
                cbLoaiThanhToan.Items.Add("Chuyển Khoản");
                cbLoaiThanhToan.Items.Add("Thẻ");
                cbLoaiThanhToan.SelectedIndex = 0;

                var nhanVien = db.NhanViens.ToList();
                cbNhanVienThanhToan.DataSource = nhanVien;
                cbNhanVienThanhToan.DisplayMember = "TenNhanVien";
                cbNhanVienThanhToan.ValueMember = "IdNhanVien";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có looixo khi truyền tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //auto load data
        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void txtSoLuongMua_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }
        private void CalculateThanhTien()
        {
            try
            {
                // Ensure txtSoLuong has a valid numeric value
                int soLuongMua = string.IsNullOrWhiteSpace(txtSoLuongMua.Text) ? 0 : int.Parse(txtSoLuongMua.Text);
                float donGia = string.IsNullOrWhiteSpace(txtDonGia.Text) ? 0 : float.Parse(txtDonGia.Text);

                float thanhTien = soLuongMua * donGia;
                txtThanhTien.Text = thanhTien.ToString("F2");  // Update the ThanhTien textbox
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số lượng và đơn giá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
