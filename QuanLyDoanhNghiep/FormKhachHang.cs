using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyDoanhNghiep.Models;

namespace QuanLyDoanhNghiep
{
    public partial class FormKhachHang : Form
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load form thành công!");
            loadData();
        }

        private void loadData()
        {
            try
            {
                var data = (from kh in db.KhachHangs
                            select new
                            {
                                kh.IdkhachHang,
                                kh.TenKhachHang,
                                kh.LoaiKhachHang,
                                kh.DiaChi,
                                kh.DienThoai,
                                kh.Email
                            }).ToList();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi hiển thị khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                    string.IsNullOrWhiteSpace(txtLoai.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtDienthoai.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenKhachHang = txtTen.Text.Trim();
                string loaiKhachHang = txtLoai.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string dienThoai = txtDienthoai.Text.Trim();
                string email = txtEmail.Text.Trim();

                var khachHang = new KhachHang
                {
                    TenKhachHang = tenKhachHang,
                    LoaiKhachHang = loaiKhachHang,
                    DiaChi = diaChi,
                    DienThoai = dienThoai,
                    Email = email
                };

                db.KhachHangs.Add(khachHang);
                db.SaveChanges();
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();

                // Xóa các trường nhập liệu
                txtTen.Clear();
                txtLoai.Clear();
                txtDiaChi.Clear();
                txtDienthoai.Clear();
                txtEmail.Clear();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Có lỗi khi lưu khách hàng: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra chỉ số hàng hợp lệ
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    var cellId = dataGridView1.Rows[e.RowIndex].Cells["IdkhachHang"].Value;
                    var cellName = dataGridView1.Rows[e.RowIndex].Cells["TenKhachHang"].Value;
                    var cellLoai = dataGridView1.Rows[e.RowIndex].Cells["LoaiKhachHang"].Value;
                    var cellDiaChi = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value;
                    var cellDienThoai = dataGridView1.Rows[e.RowIndex].Cells["DienThoai"].Value;
                    var cellEmail = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value;

                    // Gán giá trị cho các điều khiển
                    txtId.Text = cellId != null ? cellId.ToString() : string.Empty;
                    txtTen.Text = cellName != null ? cellName.ToString() : string.Empty;
                    txtLoai.Text = cellLoai != null ? cellLoai.ToString() : string.Empty;
                    txtDiaChi.Text = cellDiaChi != null ? cellDiaChi.ToString() : string.Empty;
                    txtDienthoai.Text = cellDienThoai != null ? cellDienThoai.ToString() : string.Empty;
                    txtEmail.Text = cellEmail != null ? cellEmail.ToString() : string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn ID khách hàng chưa
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID từ textbox
                int id = int.Parse(txtId.Text.Trim());
                var khachHang = db.KhachHangs.Find(id);

                if (khachHang != null)
                {
                    // Lấy dữ liệu từ các trường nhập liệu
                    khachHang.TenKhachHang = txtTen.Text.Trim();
                    khachHang.LoaiKhachHang = txtLoai.Text.Trim();
                    khachHang.DiaChi = txtDiaChi.Text.Trim();
                    khachHang.DienThoai = txtDienthoai.Text.Trim();
                    khachHang.Email = txtEmail.Text.Trim();

                    // Cập nhật khách hàng vào cơ sở dữ liệu
                    db.SaveChanges();
                    MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu để hiển thị
                    loadData();
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID khách hàng phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Có lỗi khi sửa khách hàng: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn ID khách hàng chưa
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID từ textbox
                int id = int.Parse(txtId.Text.Trim());
                var khachHang = db.KhachHangs.Find(id);

                if (khachHang != null)
                {
                    db.KhachHangs.Remove(khachHang);
                    db.SaveChanges();
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData(); // Tải lại dữ liệu sau khi xóa

                    // Xóa các trường nhập liệu sau khi xóa
                    txtId.Clear();
                    txtTen.Clear();
                    txtLoai.Clear();
                    txtDiaChi.Clear();
                    txtDienthoai.Clear();
                    txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }

        private void FormKhachHang_Load_1(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
