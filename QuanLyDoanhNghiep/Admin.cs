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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một instance của FormNhanVien
            FormNhanVien formNhanVien = new FormNhanVien();
            // Hiển thị FormNhanVien
            formNhanVien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSanPham fsp = new FormSanPham();
            fsp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormKhachHang fkh = new FormKhachHang();
            fkh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormHoaDon1 fhd = new FormHoaDon1();
            fhd.Show();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            FormPhieuNhap fpn = new FormPhieuNhap();
            fpn.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormNhaCungCap ncc = new FormNhaCungCap();
            ncc.Show();
        }
    }
}
