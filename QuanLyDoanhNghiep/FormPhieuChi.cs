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
    public partial class FormPhieuChi : Form, InterfaceData
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();

        public FormPhieuChi()
        {
            InitializeComponent();
        }

        private void FormPhieuChi_Load(object sender, EventArgs e)
        {
            try
            {
                // Load employee names into cbNhanVien
                var employees = db.NhanViens.Select(nv => new { nv.IdnhanVien, nv.TenNhanVien }).ToList();
                cbNhanVienChi.DisplayMember = "TenNhanVien";
                cbNhanVienChi.ValueMember = "IdnhanVien";
                cbNhanVienChi.DataSource = employees;

                // Set fixed payment types for cbThanhToan
                cbThanhToan.Items.Clear();
                cbThanhToan.Items.Add("Tiền mặt");
                cbThanhToan.Items.Add("Chuyển khoản");
                cbThanhToan.Items.Add("Quẹt thẻ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    var row = dataGridView1.Rows[e.RowIndex];
                    txtIdPhieuChi.Text = row.Cells["IdphieuChi"].Value.ToString();
                    txtIdPhieuNhap.Text = row.Cells["IdphieuNhap"].Value.ToString();
                    txtSoTien.Text = row.Cells["SoTien"].Value.ToString();
                    dateTimePicker1.Value = DateTime.Parse(row.Cells["NgayChi"].Value.ToString());
                    cbNhanVienChi.Text = row.Cells["TenNhanVien"].Value.ToString();
                    cbThanhToan.Text = row.Cells["LoaiThanhToan"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSoTien.Text) ||
                    string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                    cbNhanVienChi.SelectedIndex == -1 ||
                    cbThanhToan.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new Phiếu Chi entry
                var newPhieuChi = new PhieuChi
                {
                    IdphieuChi = int.Parse(txtIdPhieuChi.Text),
                    IdphieuNhap = int.Parse(txtIdPhieuNhap.Text),
                    SoTien = decimal.Parse(txtSoTien.Text),
                    NgayChi = dateTimePicker1.Value,
                    IdnhanVien = (int)cbNhanVienChi.SelectedValue,
                    LoaiThanhToan = cbThanhToan.Text
                };

                db.PhieuChis.Add(newPhieuChi);
                db.SaveChanges();
                MessageBox.Show("Entry added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void loadData()
        {
            try
            {
                var data = (from pc in db.PhieuChis
                            join n in db.PhieuNhaps on pc.IdphieuNhap equals n.IdphieuNhap
                            join cn in db.ChiTietPhieuNhaps on n.IdphieuNhap equals cn.IdphieuNhap
                            join nv in db.NhanViens on cn.IdphieuNhap equals nv.IdnhanVien

                            select new
                            {
                                pc.IdphieuNhap,
                                pc.IdphieuChi,
                                pc.NgayChi,
                                pc.SoTien,
                                nv.TenNhanVien,
                                nv.PhongBan
                            }).ToList();

                dataGridView1.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi hiển thị : {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearTextBoxes()
        {
            txtIdPhieuChi.Clear();
            txtIdPhieuNhap.Clear();
            txtIdPhieuChi.Clear();
            txtSoTien.Clear();
            cbThanhToan.Items.Clear();
        }
    }
}
