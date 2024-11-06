namespace QuanLyDoanhNghiep
{
    partial class FormNhanVien
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
            cbChucVu = new ComboBox();
            cbPhongBan = new ComboBox();
            txtDiaChi = new TextBox();
            txtDienthoai = new TextBox();
            txtTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 39);
            label1.Name = "label1";
            label1.Size = new Size(31, 30);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 82);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 1;
            label2.Text = "Ho Va Ten";
            // 
            // cbChucVu
            // 
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(179, 129);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(212, 38);
            cbChucVu.TabIndex = 2;
            // 
            // cbPhongBan
            // 
            cbPhongBan.FormattingEnabled = true;
            cbPhongBan.Location = new Point(179, 190);
            cbPhongBan.Name = "cbPhongBan";
            cbPhongBan.Size = new Size(212, 38);
            cbPhongBan.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(197, 243);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(175, 35);
            txtDiaChi.TabIndex = 4;
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(197, 310);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(175, 35);
            txtDienthoai.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(197, 83);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(175, 35);
            txtTen.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 129);
            label3.Name = "label3";
            label3.Size = new Size(90, 30);
            label3.TabIndex = 7;
            label3.Text = "Chuc Vu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 190);
            label4.Name = "label4";
            label4.Size = new Size(114, 30);
            label4.TabIndex = 8;
            label4.Text = "Phong Ban";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 243);
            label5.Name = "label5";
            label5.Size = new Size(80, 30);
            label5.TabIndex = 9;
            label5.Text = "Dia Chi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 299);
            label6.Name = "label6";
            label6.Size = new Size(113, 30);
            label6.TabIndex = 10;
            label6.Text = "Dien Thoai";
            // 
            // txtId
            // 
            txtId.Location = new Point(202, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 35);
            txtId.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 386);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(761, 262);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(498, 60);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 13;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(498, 126);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 40);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(498, 188);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 40);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(498, 241);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 40);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(498, 305);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(131, 40);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 685);
            Controls.Add(btnLoad);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTen);
            Controls.Add(txtDienthoai);
            Controls.Add(txtDiaChi);
            Controls.Add(cbPhongBan);
            Controls.Add(cbChucVu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNhanVien";
            Text = "NhanVien";
            Load += FormNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbChucVu;
        private ComboBox cbPhongBan;
        private TextBox txtDiaChi;
        private TextBox txtDienthoai;
        private TextBox txtTen;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnLoad;
    }
}