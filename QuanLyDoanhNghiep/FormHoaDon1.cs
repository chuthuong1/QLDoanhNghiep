using QuanLyDoanhNghiep.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep
{
    public partial class FormHoaDon1 : Form
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();

        public FormHoaDon1()
        {
            InitializeComponent();
        }

        private void FormHoaDon1_Load(object sender, EventArgs e)
        {
            loadNhanVien(); // Nạp danh sách nhân viên khi form được mở
            loadData(); // Nạp dữ liệu hóa đơn
        }

        private void loadData()
        {
            try
            {
                var data = (from hd in db.HoaDonBans
                            join cthd in db.ChiTietHoaDonBans on hd.IdhoaDon equals cthd.IdhoaDon
                            select new
                            {
                                hd.IdhoaDon,
                                TenKhachHang = hd.IdkhachHangNavigation.TenKhachHang,
                                TenNhanVien = hd.IdnhanVienNavigation.TenNhanVien,
                                hd.NgayBan,
                                hd.TongTien,
                                hd.LoaiThanhToan,
                                IdSanPham = cthd.IdsanPham,
                                SoLuong = cthd.SoLuong,
                                DonGia = cthd.DonGia,
                                ThanhTien = cthd.ThanhTien
                            }).ToList();

                // Bind the data to DataGridView
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadNhanVien()
        {
            try
            {
                var employees = db.NhanViens.Select(nv => new
                {
                    nv.IdnhanVien,
                    nv.TenNhanVien
                }).ToList();

                cmbNhanVien.DataSource = employees;
                cmbNhanVien.DisplayMember = "TenNhanVien"; // Tên hiển thị trong ComboBox
                cmbNhanVien.ValueMember = "IdnhanVien";    // Giá trị tương ứng với nhân viên
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNhanVien.SelectedItem != null)
            {
                // Lấy thông tin nhân viên đã chọn
                var selectedEmployee = (dynamic)cmbNhanVien.SelectedItem;
                cmbNhanVien.Text = selectedEmployee.TenNhanVien; // Hiển thị tên nhân viên trong TextBox
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = dataGridView1.Rows[e.RowIndex];

                    txtId.Text = selectedRow.Cells["IdhoaDon"].Value.ToString();
                    txtTenKhach.Text = selectedRow.Cells["TenKhachHang"].Value.ToString();
                    cmbNhanVien.Text = selectedRow.Cells["TenNhanVien"].Value.ToString();
                    dtpNgayBan.Value = Convert.ToDateTime(selectedRow.Cells["NgayBan"].Value); // Sử dụng Value
                    txtTongTien.Text = selectedRow.Cells["TongTien"].Value.ToString();
                    txtLoaiThanhToan.Text = selectedRow.Cells["LoaiThanhToan"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if values are valid
                if (string.IsNullOrWhiteSpace(txtTongTien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng hóa đơn mới
                HoaDonBan newInvoice = new HoaDonBan
                {
                    IdkhachHang = int.Parse(txtId.Text), // ID khách hàng có thể nhập mới
                    IdnhanVien = (int)cmbNhanVien.SelectedValue, // Lấy ID nhân viên từ ComboBox
                    NgayBan = dtpNgayBan.Value, // Ngày bán từ DateTimePicker
                    TongTien = decimal.Parse(txtTongTien.Text),
                    LoaiThanhToan = txtLoaiThanhToan.Text
                };

                // Thêm hóa đơn vào cơ sở dữ liệu
                db.HoaDonBans.Add(newInvoice);
                db.SaveChanges();

                // Tải lại dữ liệu để hiển thị hóa đơn mới
                loadData();

                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"Vui lòng nhập số tiền hợp lệ: {fe.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi thêm hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormHoaDon1_Load_1(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
