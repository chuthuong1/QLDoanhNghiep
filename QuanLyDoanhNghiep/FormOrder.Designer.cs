namespace QuanLyDoanhNghiep
{
    partial class FormOrder
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
            txtTenSanPham = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            txtThanhTien = new TextBox();
            txtTenkhachHang = new TextBox();
            txtDiaChi = new TextBox();
            cbNhanVienThanhToan = new ComboBox();
            button1 = new Button();
            dtpNgayThanhToan = new DateTimePicker();
            label10 = new Label();
            cbLoaiThanhToan = new ComboBox();
            label11 = new Label();
            txtSoLuongMua = new TextBox();
            SuspendLayout();
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(323, 90);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(175, 35);
            txtTenSanPham.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 81);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 1;
            label1.Text = "Tên Sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 156);
            label2.Name = "label2";
            label2.Size = new Size(192, 30);
            label2.TabIndex = 2;
            label2.Text = "Số lượng trong kho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 270);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 3;
            label3.Text = "Thành tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 213);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 4;
            label4.Text = "đơn giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 325);
            label5.Name = "label5";
            label5.Size = new Size(161, 30);
            label5.TabIndex = 5;
            label5.Text = "Tên Khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 374);
            label6.Name = "label6";
            label6.Size = new Size(77, 30);
            label6.TabIndex = 6;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 422);
            label7.Name = "label7";
            label7.Size = new Size(159, 30);
            label7.TabIndex = 7;
            label7.Text = "Loại thanh toán";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(268, 621);
            label8.Name = "label8";
            label8.Size = new Size(0, 30);
            label8.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 497);
            label9.Name = "label9";
            label9.Size = new Size(216, 30);
            label9.TabIndex = 9;
            label9.Text = "Nhân viên thanh toán";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(323, 165);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(175, 35);
            txtSoLuong.TabIndex = 10;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(323, 222);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(175, 35);
            txtDonGia.TabIndex = 11;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(323, 279);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(175, 35);
            txtThanhTien.TabIndex = 12;
            // 
            // txtTenkhachHang
            // 
            txtTenkhachHang.Location = new Point(330, 343);
            txtTenkhachHang.Name = "txtTenkhachHang";
            txtTenkhachHang.Size = new Size(175, 35);
            txtTenkhachHang.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(330, 383);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(175, 35);
            txtDiaChi.TabIndex = 14;
            // 
            // cbNhanVienThanhToan
            // 
            cbNhanVienThanhToan.FormattingEnabled = true;
            cbNhanVienThanhToan.Location = new Point(323, 509);
            cbNhanVienThanhToan.Name = "cbNhanVienThanhToan";
            cbNhanVienThanhToan.Size = new Size(212, 38);
            cbNhanVienThanhToan.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(454, 684);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 17;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpNgayThanhToan
            // 
            dtpNgayThanhToan.Location = new Point(349, 571);
            dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            dtpNgayThanhToan.Size = new Size(350, 35);
            dtpNgayThanhToan.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(66, 571);
            label10.Name = "label10";
            label10.Size = new Size(170, 30);
            label10.TabIndex = 19;
            label10.Text = "Ngày thanh toán";
            // 
            // cbLoaiThanhToan
            // 
            cbLoaiThanhToan.FormattingEnabled = true;
            cbLoaiThanhToan.Location = new Point(331, 436);
            cbLoaiThanhToan.Name = "cbLoaiThanhToan";
            cbLoaiThanhToan.Size = new Size(212, 38);
            cbLoaiThanhToan.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(641, 95);
            label11.Name = "label11";
            label11.Size = new Size(143, 30);
            label11.TabIndex = 21;
            label11.Text = "Số lượng mua";
            // 
            // txtSoLuongMua
            // 
            txtSoLuongMua.Location = new Point(821, 95);
            txtSoLuongMua.Name = "txtSoLuongMua";
            txtSoLuongMua.Size = new Size(175, 35);
            txtSoLuongMua.TabIndex = 22;
            txtSoLuongMua.TextChanged += txtSoLuongMua_TextChanged;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 839);
            Controls.Add(txtSoLuongMua);
            Controls.Add(label11);
            Controls.Add(cbLoaiThanhToan);
            Controls.Add(label10);
            Controls.Add(dtpNgayThanhToan);
            Controls.Add(button1);
            Controls.Add(cbNhanVienThanhToan);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenkhachHang);
            Controls.Add(txtThanhTien);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenSanPham);
            Name = "FormOrder";
            Text = "FormOrder";
            Load += FormOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenSanPham;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private TextBox txtThanhTien;
        private TextBox txtTenkhachHang;
        private TextBox txtDiaChi;
        private ComboBox cbNhanVienThanhToan;
        private Button button1;
        private DateTimePicker dtpNgayThanhToan;
        private Label label10;
        private ComboBox cbLoaiThanhToan;
        private Label label11;
        private TextBox txtSoLuongMua;
    }
}