using Microsoft.EntityFrameworkCore;
using QuanLyDoanhNghiep.internalinterface;
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
    public partial class FormNhanVien : Form, InterfaceData
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load form thành công!");
            ((InterfaceData)this).loadData();
            loadComboBoxData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                    string.IsNullOrWhiteSpace(cbChucVu.Text) ||
                    string.IsNullOrWhiteSpace(cbPhongBan.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtDienthoai.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string dienThoai = txtDienthoai.Text;
                var existingNhanVien = db.NhanViens.FirstOrDefault(nv => nv.DienThoai == dienThoai);
                if (existingNhanVien != null)
                {
                    MessageBox.Show("Số điện thoại không được trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var nhanVien = new NhanVien
                {
                    TenNhanVien = txtTen.Text.Trim(),
                    ChucVu = cbChucVu.Text.Trim(),
                    PhongBan = cbPhongBan.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    DienThoai = txtDienthoai.Text.Trim()
                };

                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((InterfaceData)this).loadData();

                // Xóa các trường nhập liệu
                txtTen.Clear();
                cbChucVu.SelectedIndex = -1; // Đặt lại ComboBox
                cbPhongBan.SelectedIndex = -1; // Đặt lại ComboBox
                txtDiaChi.Clear();
                txtDienthoai.Clear();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Có lỗi khi lưu nhân viên: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Kiểm tra xem đã chọn ID nhân viên chưa
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID từ textbox
                int id = int.Parse(txtId.Text.Trim());
                var nhanVien = db.NhanViens.Find(id);

                if (nhanVien != null)
                {
                    // Lấy dữ liệu từ các trường nhập liệu
                    nhanVien.TenNhanVien = txtTen.Text.Trim();
                    nhanVien.ChucVu = cbChucVu.Text.Trim();
                    nhanVien.PhongBan = cbPhongBan.Text.Trim();
                    nhanVien.DiaChi = txtDiaChi.Text.Trim();
                    nhanVien.DienThoai = txtDienthoai.Text.Trim();

                    // Cập nhật nhân viên vào cơ sở dữ liệu
                    db.SaveChanges();
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa data textbox
                    ((InterfaceData)this).ClearTextBoxes();
                    // Tải lại dữ liệu để hiển thị
                    ((InterfaceData)this).loadData();

                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException ex)
            {
                // Bắt lỗi khi cập nhật cơ sở dữ liệu
                MessageBox.Show($"Có lỗi khi sửa nhân viên: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Kiểm tra xem đã chọn ID nhân viên chưa
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID từ textbox
                int id = int.Parse(txtId.Text.Trim());
                var nhanVien = db.NhanViens.Find(id);

                if (nhanVien != null)
                {
                    db.NhanViens.Remove(nhanVien);
                    db.SaveChanges();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((InterfaceData)this).loadData(); // Tải lại dữ liệu sau khi xóa

                    // Xóa các trường nhập liệu sau khi xóa
                    ((InterfaceData)this).ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            ((InterfaceData)this).loadData();
            loadComboBoxData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra chỉ số hàng hợp lệ
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    var cellId = dataGridView1.Rows[e.RowIndex].Cells["IdnhanVien"].Value;
                    var cellName = dataGridView1.Rows[e.RowIndex].Cells["TenNhanVien"].Value;
                    var cellChucVu = dataGridView1.Rows[e.RowIndex].Cells["ChucVu"].Value;
                    var cellPhongBan = dataGridView1.Rows[e.RowIndex].Cells["PhongBan"].Value;
                    var cellDiaChi = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value;
                    var cellDienThoai = dataGridView1.Rows[e.RowIndex].Cells["DienThoai"].Value;

                    // Gán giá trị cho các điều khiển
                    txtId.Text = cellId != null ? cellId.ToString() : string.Empty;
                    txtTen.Text = cellName != null ? cellName.ToString() : string.Empty;
                    cbChucVu.SelectedItem = cellChucVu != null ? cellChucVu.ToString() : null; // Chọn mục trong ComboBox
                    cbPhongBan.SelectedItem = cellPhongBan != null ? cellPhongBan.ToString() : null; // Chọn mục trong ComboBox
                    txtDiaChi.Text = cellDiaChi != null ? cellDiaChi.ToString() : string.Empty;
                    txtDienthoai.Text = cellDienThoai != null ? cellDienThoai.ToString() : string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadComboBoxData()
        {
            // Lấy dữ liệu cho ComboBox Chức Vụ
            var chucVuList = db.NhanViens.Select(cv => cv.ChucVu).ToList();
            cbChucVu.DataSource = chucVuList;

            // Lấy dữ liệu cho ComboBox Phòng Ban
            var phongBanList = db.NhanViens.Select(pb => pb.PhongBan).ToList();
            cbPhongBan.DataSource = phongBanList;
        }


        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            ((InterfaceData)this).loadData();
            loadComboBoxData();
        }

        void InterfaceData.loadData()
        {
            try
            {
                var data = (from p in db.NhanViens
                            select new
                            {
                                p.IdnhanVien,
                                p.TenNhanVien,
                                p.ChucVu,
                                p.PhongBan,
                                p.DiaChi,
                                p.DienThoai
                            }).ToList();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi hiển thị nhan vien: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearTextBoxes()
        {
            // Xóa các trường nhập liệu sau khi thêm
            txtId.Clear();
            txtTen.Clear();
            cbChucVu.SelectedIndex = -1; // Đặt lại ComboBox
            cbPhongBan.SelectedIndex = -1; // Đặt lại ComboBox
            txtDiaChi.Clear();
            txtDienthoai.Clear();
        }
    }
}
