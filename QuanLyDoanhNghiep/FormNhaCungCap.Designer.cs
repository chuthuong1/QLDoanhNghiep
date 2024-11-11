namespace QuanLyDoanhNghiep
{
    partial class FormNhaCungCap
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
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTen = new TextBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            txtEmail = new TextBox();
            dataGridView1 = new DataGridView();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(718, 77);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(718, 125);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(718, 177);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(131, 40);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 57);
            label1.Name = "label1";
            label1.Size = new Size(34, 30);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(243, 57);
            txtId.Name = "txtId";
            txtId.Size = new Size(259, 35);
            txtId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 125);
            label2.Name = "label2";
            label2.Size = new Size(177, 30);
            label2.TabIndex = 5;
            label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 182);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 6;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 238);
            label4.Name = "label4";
            label4.Size = new Size(135, 30);
            label4.TabIndex = 7;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 295);
            label5.Name = "label5";
            label5.Size = new Size(63, 30);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(243, 122);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(259, 35);
            txtTen.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(243, 188);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(259, 35);
            txtDiaChi.TabIndex = 10;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(243, 235);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(259, 35);
            txtDienThoai.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(243, 292);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 35);
            txtEmail.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 390);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(871, 285);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(718, 233);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 40);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 698);
            Controls.Add(btnThoat);
            Controls.Add(dataGridView1);
            Controls.Add(txtEmail);
            Controls.Add(txtDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "FormNhaCungCap";
            Text = "FormNhaCungCap";
            Load += FormNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTen;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private DataGridView dataGridView1;
        private Button btnThoat;
    }
}