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
    public partial class Order : Form
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();
        public Order()
        {
            InitializeComponent();
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

        private void Order_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
