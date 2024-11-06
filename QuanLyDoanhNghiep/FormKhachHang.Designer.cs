namespace QuanLyDoanhNghiep
{
    partial class FormKhachHang
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
            lable1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtTen = new TextBox();
            txtLoai = new TextBox();
            txtDiaChi = new TextBox();
            txtDienthoai = new TextBox();
            txtEmail = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(111, 31);
            lable1.Name = "lable1";
            lable1.Size = new Size(31, 30);
            lable1.TabIndex = 0;
            lable1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 74);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 1;
            label2.Text = "Ten khach";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 126);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 2;
            label3.Text = "Loai khach";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 167);
            label4.Name = "label4";
            label4.Size = new Size(77, 30);
            label4.TabIndex = 3;
            label4.Text = "Dia chi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 210);
            label5.Name = "label5";
            label5.Size = new Size(113, 30);
            label5.TabIndex = 4;
            label5.Text = "Dien Thoai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 259);
            label6.Name = "label6";
            label6.Size = new Size(63, 30);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // txtId
            // 
            txtId.Location = new Point(289, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(175, 35);
            txtId.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(289, 74);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(175, 35);
            txtTen.TabIndex = 7;
            // 
            // txtLoai
            // 
            txtLoai.Location = new Point(280, 126);
            txtLoai.Name = "txtLoai";
            txtLoai.Size = new Size(175, 35);
            txtLoai.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(289, 167);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(175, 35);
            txtDiaChi.TabIndex = 9;
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(280, 210);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(175, 35);
            txtDienthoai.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(280, 259);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 35);
            txtEmail.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(538, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 12;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(585, 109);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 40);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(587, 170);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 40);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(608, 226);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 40);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(589, 273);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(131, 40);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 364);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(733, 271);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 656);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoad);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtEmail);
            Controls.Add(txtDienthoai);
            Controls.Add(txtDiaChi);
            Controls.Add(txtLoai);
            Controls.Add(txtTen);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lable1);
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            Load += FormKhachHang_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtTen;
        private TextBox txtLoai;
        private TextBox txtDiaChi;
        private TextBox txtDienthoai;
        private TextBox txtEmail;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnLoad;
        private DataGridView dataGridView1;
    }
}