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
    public partial class FormNhaCungCap : Form, InterfaceData
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();

        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            // Gọi phương thức loadData thông qua InterfaceData
            ((InterfaceData)this).loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                    string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                     string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nhaCungCap = new NhaCungCap
                {
                    TenNhaCungCap = txtTen.Text.Trim(),
                    DienThoai = txtDienThoai.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim()

                };
                db.NhaCungCaps.Add(nhaCungCap);
                db.SaveChanges();
                MessageBox.Show("Thêm Nhà cung cấp thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((InterfaceData)this).ClearTextBoxes();
                ((InterfaceData)this).loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ((InterfaceData)this).ClearTextBoxes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra chỉ số hàng hợp lệ
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    var cellId = dataGridView1.Rows[e.RowIndex].Cells["IDNhaCungCap"].Value;
                    var cellTen = dataGridView1.Rows[e.RowIndex].Cells["TenNhaCungCap"].Value;
                    var cellDiaChi = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value;
                    var cellDienThoai = dataGridView1.Rows[e.RowIndex].Cells["DienThoai"].Value;
                    var cellEmail = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value;

                    // Gán giá trị cho các điều khiển
                    txtId.Text = cellId != null ? cellId.ToString() : string.Empty;
                    txtTen.Text = cellTen != null ? cellTen.ToString() : string.Empty;
                    txtDiaChi.Text = cellDiaChi != null ? cellDiaChi.ToString() : string.Empty;
                    txtDienThoai.Text = cellDienThoai != null ? cellDienThoai.ToString() : string.Empty;
                    txtEmail.Text = cellEmail != null ? cellEmail.ToString() : string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void InterfaceData.loadData()
        {
            try
            {
                var data = (from ncc in db.NhaCungCaps
                            select new
                            {
                                ncc.IdnhaCungCap,
                                ncc.TenNhaCungCap,
                                ncc.DiaChi,
                                ncc.Email,
                                ncc.DienThoai
                            }).ToList();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Interface data function clear text
        void InterfaceData.ClearTextBoxes()
        {
            txtTen.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
        }
    }

}
