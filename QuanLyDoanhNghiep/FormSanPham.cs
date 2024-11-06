using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyDoanhNghiep.Models;

namespace QuanLyDoanhNghiep
{
    public partial class FormSanPham : Form
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();

        public FormSanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load form thành công!");
            loadData();
        }

        private void loadData()
        {
            try
            {
                var data = (from p in db.SanPhams
                            select new
                            {
                                p.IdsanPham,
                                p.TenSanPham,
                                p.ChuLoai,
                                p.Gia,
                                p.SoLuongTonKho
                            }).ToList();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi hiển thị sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) ||
                    string.IsNullOrWhiteSpace(txtLoaiSanPham.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaSanPham.Text) ||
                    string.IsNullOrWhiteSpace(txtKho.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenSanPham = txtTenSanPham.Text.Trim();
                string loaiSanPham = txtLoaiSanPham.Text.Trim();
                string gia = txtGiaSanPham.Text.Trim();
                string kho = txtKho.Text.Trim();

                var sanPham = new SanPham
                {
                    TenSanPham = tenSanPham,
                    ChuLoai = loaiSanPham,
                    Gia = decimal.Parse(gia),
                    SoLuongTonKho = int.Parse(kho)
                };

                db.SanPhams.Add(sanPham);
                db.SaveChanges();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();

                txtTenSanPham.Clear();
                txtLoaiSanPham.Clear();
                txtGiaSanPham.Clear();
                txtKho.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá và số lượng phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Có lỗi khi lưu sản phẩm: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var cellId = dataGridView1.Rows[e.RowIndex].Cells["IdsanPham"].Value;
                    var cellName = dataGridView1.Rows[e.RowIndex].Cells["TenSanPham"].Value;
                    var cellLoai = dataGridView1.Rows[e.RowIndex].Cells["ChuLoai"].Value;
                    var cellGia = dataGridView1.Rows[e.RowIndex].Cells["Gia"].Value;
                    var cellKho = dataGridView1.Rows[e.RowIndex].Cells["SoLuongTonKho"].Value;

                    // Gán giá trị cho các điều khiển
                    txtId.Text = cellId != null ? cellId.ToString() : string.Empty;
                    txtTenSanPham.Text = cellName != null ? cellName.ToString() : string.Empty;
                    txtLoaiSanPham.Text = cellLoai != null ? cellLoai.ToString() : string.Empty;
                    txtGiaSanPham.Text = cellGia != null ? cellGia.ToString() : string.Empty;
                    txtKho.Text = cellKho != null ? cellKho.ToString() : string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn ID sản phẩm chưa
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID từ textbox
                int id = int.Parse(txtId.Text.Trim());
                var sanPham = db.SanPhams.Find(id);

                if (sanPham != null)
                {
                    // Lấy dữ liệu từ các trường nhập liệu
                    sanPham.TenSanPham = txtTenSanPham.Text.Trim();
                    sanPham.ChuLoai = txtLoaiSanPham.Text.Trim();
                    sanPham.Gia = decimal.Parse(txtGiaSanPham.Text.Trim());
                    sanPham.SoLuongTonKho = int.Parse(txtKho.Text.Trim());

                    // Cập nhật sản phẩm vào cơ sở dữ liệu
                    db.SaveChanges();
                    MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu để hiển thị
                    loadData();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá và số lượng phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DbUpdateException ex)
            {
                // Bắt lỗi khi cập nhật cơ sở dữ liệu
                MessageBox.Show($"Có lỗi khi sửa sản phẩm: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Kiểm tra xem đã chọn ID sản phẩm chưa
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID từ textbox
                int id = int.Parse(txtId.Text.Trim());
                var sanPham = db.SanPhams.Find(id);

                if (sanPham != null)
                {
                    db.SanPhams.Remove(sanPham);
                    db.SaveChanges();
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData(); // Tải lại dữ liệu sau khi xóa

                    // Xóa các trường nhập liệu sau khi xóa
                    txtId.Clear();
                    txtTenSanPham.Clear();
                    txtLoaiSanPham.Clear();
                    txtGiaSanPham.Clear();
                    txtKho.Clear();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
