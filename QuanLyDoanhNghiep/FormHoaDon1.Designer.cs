namespace QuanLyDoanhNghiep
{
    partial class FormHoaDon1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtTenKhach = new TextBox();
            txtTongTien = new TextBox();
            txtLoaiThanhToan = new TextBox();
            btnLoad = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            dtpNgayBan = new DateTimePicker();
            cmbNhanVien = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 341);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(676, 356);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 1;
            label1.Text = "IdHoaDon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 85);
            label2.Name = "label2";
            label2.Size = new Size(152, 30);
            label2.TabIndex = 2;
            label2.Text = "TenKhachHang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 140);
            label3.Name = "label3";
            label3.Size = new Size(134, 30);
            label3.TabIndex = 3;
            label3.Text = "TenNhanvien";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 190);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 4;
            label4.Text = "NgayBan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 246);
            label5.Name = "label5";
            label5.Size = new Size(97, 30);
            label5.TabIndex = 5;
            label5.Text = "TongTien";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 292);
            label6.Name = "label6";
            label6.Size = new Size(153, 30);
            label6.TabIndex = 6;
            label6.Text = "LoaiThanhToan";
            // 
            // txtId
            // 
            txtId.Location = new Point(259, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(175, 35);
            txtId.TabIndex = 7;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(259, 85);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(175, 35);
            txtTenKhach.TabIndex = 8;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(291, 243);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(175, 35);
            txtTongTien.TabIndex = 11;
            // 
            // txtLoaiThanhToan
            // 
            txtLoaiThanhToan.Location = new Point(291, 292);
            txtLoaiThanhToan.Name = "txtLoaiThanhToan";
            txtLoaiThanhToan.Size = new Size(175, 35);
            txtLoaiThanhToan.TabIndex = 12;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(813, 222);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(131, 40);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(818, 140);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 40);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(687, 60);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 15;
            btnThem.Text = "them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Location = new Point(259, 201);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(350, 35);
            dtpNgayBan.TabIndex = 16;
            // 
            // cmbNhanVien
            // 
            cmbNhanVien.FormattingEnabled = true;
            cmbNhanVien.Location = new Point(265, 140);
            cmbNhanVien.Name = "cmbNhanVien";
            cmbNhanVien.Size = new Size(212, 38);
            cmbNhanVien.TabIndex = 17;
            // 
            // FormHoaDon1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 696);
            Controls.Add(cmbNhanVien);
            Controls.Add(dtpNgayBan);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(btnLoad);
            Controls.Add(txtLoaiThanhToan);
            Controls.Add(txtTongTien);
            Controls.Add(txtTenKhach);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormHoaDon1";
            Text = "FormHoaDon1";
            Load += FormHoaDon1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtTenKhach;
        private TextBox txtTongTien;
        private TextBox txtLoaiThanhToan;
        private Button btnLoad;
        private Button btnThoat;
        private Button btnThem;
        private DateTimePicker dtpNgayBan;
        private ComboBox cmbNhanVien;
    }
}