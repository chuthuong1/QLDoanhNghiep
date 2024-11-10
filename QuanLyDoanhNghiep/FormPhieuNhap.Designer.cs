namespace QuanLyDoanhNghiep
{
    partial class FormPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpNgayNhap = new DateTimePicker();
            dataGridView1 = new DataGridView();
            cbNhanVien = new ComboBox();
            txtTongTien = new TextBox();
            cbNhaCungCap = new ComboBox();
            btnNhapHang = new Button();
            cbSanPham = new ComboBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 20);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 0;
            label1.Text = "IdPhieuNhap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 128);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 1;
            label2.Text = "Nhân viên nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 172);
            label3.Name = "label3";
            label3.Size = new Size(149, 30);
            label3.TabIndex = 2;
            label3.Text = "Nhà Cung Cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 243);
            label4.Name = "label4";
            label4.Size = new Size(115, 30);
            label4.TabIndex = 3;
            label4.Text = "Ngày nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 300);
            label5.Name = "label5";
            label5.Size = new Size(101, 30);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(270, 243);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(350, 35);
            dtpNgayNhap.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 460);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1266, 606);
            dataGridView1.TabIndex = 6;
            // 
            // cbNhanVien
            // 
            cbNhanVien.FormattingEnabled = true;
            cbNhanVien.Location = new Point(756, 128);
            cbNhanVien.Name = "cbNhanVien";
            cbNhanVien.Size = new Size(212, 38);
            cbNhanVien.TabIndex = 7;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(270, 300);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(175, 35);
            txtTongTien.TabIndex = 8;
            // 
            // cbNhaCungCap
            // 
            cbNhaCungCap.FormattingEnabled = true;
            cbNhaCungCap.Location = new Point(756, 172);
            cbNhaCungCap.Name = "cbNhaCungCap";
            cbNhaCungCap.Size = new Size(212, 38);
            cbNhaCungCap.TabIndex = 9;
            // 
            // btnNhapHang
            // 
            btnNhapHang.Location = new Point(1078, 101);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(131, 40);
            btnNhapHang.TabIndex = 10;
            btnNhapHang.Text = "Nhập Hàng";
            btnNhapHang.UseVisualStyleBackColor = true;
            btnNhapHang.Click += btnNhapHang_Click;
            // 
            // cbSanPham
            // 
            cbSanPham.FormattingEnabled = true;
            cbSanPham.Location = new Point(270, 64);
            cbSanPham.Name = "cbSanPham";
            cbSanPham.Size = new Size(212, 38);
            cbSanPham.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(270, 128);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(175, 35);
            txtSoLuong.TabIndex = 12;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(270, 175);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(175, 35);
            txtDonGia.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 75);
            label6.Name = "label6";
            label6.Size = new Size(106, 30);
            label6.TabIndex = 14;
            label6.Text = "Sản phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 131);
            label7.Name = "label7";
            label7.Size = new Size(94, 30);
            label7.TabIndex = 15;
            label7.Text = "số lượng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 187);
            label8.Name = "label8";
            label8.Size = new Size(84, 30);
            label8.TabIndex = 16;
            label8.Text = "đơn giá";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(1254, 101);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(131, 40);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1436, 101);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 40);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // FormPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 1175);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(cbSanPham);
            Controls.Add(btnNhapHang);
            Controls.Add(cbNhaCungCap);
            Controls.Add(txtTongTien);
            Controls.Add(cbNhanVien);
            Controls.Add(dataGridView1);
            Controls.Add(dtpNgayNhap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPhieuNhap";
            Text = "FormPhieuNhap";
            Load += FormPhieuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpNgayNhap;
        private DataGridView dataGridView1;
        private ComboBox cbNhanVien;
        private TextBox txtTongTien;
        private ComboBox cbNhaCungCap;
        private Button btnNhapHang;
        private ComboBox cbSanPham;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnLamMoi;
        private Button btnXoa;
    }
}