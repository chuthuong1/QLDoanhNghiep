namespace QuanLyDoanhNghiep
{
    partial class FormSanPham
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            txtId = new TextBox();
            txtTenSanPham = new TextBox();
            txtLoaiSanPham = new TextBox();
            txtGiaSanPham = new TextBox();
            txtKho = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(490, 70);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(248, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Them San Pham";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 42);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 1;
            label1.Text = "IdSanPham";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 94);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 2;
            label2.Text = "Ten San Pham";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 145);
            label3.Name = "label3";
            label3.Size = new Size(51, 30);
            label3.TabIndex = 3;
            label3.Text = "Loai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 219);
            label4.Name = "label4";
            label4.Size = new Size(43, 30);
            label4.TabIndex = 4;
            label4.Text = "Gia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 277);
            label5.Name = "label5";
            label5.Size = new Size(88, 30);
            label5.TabIndex = 5;
            label5.Text = "Ton Kho";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(75, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(915, 362);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(214, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(175, 35);
            txtId.TabIndex = 7;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(214, 103);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(175, 35);
            txtTenSanPham.TabIndex = 8;
            // 
            // txtLoaiSanPham
            // 
            txtLoaiSanPham.Location = new Point(158, 172);
            txtLoaiSanPham.Name = "txtLoaiSanPham";
            txtLoaiSanPham.Size = new Size(175, 35);
            txtLoaiSanPham.TabIndex = 9;
            // 
            // txtGiaSanPham
            // 
            txtGiaSanPham.Location = new Point(193, 235);
            txtGiaSanPham.Name = "txtGiaSanPham";
            txtGiaSanPham.Size = new Size(175, 35);
            txtGiaSanPham.TabIndex = 10;
            // 
            // txtKho
            // 
            txtKho.Location = new Point(186, 291);
            txtKho.Name = "txtKho";
            txtKho.Size = new Size(175, 35);
            txtKho.TabIndex = 11;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(490, 135);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 40);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(490, 181);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 40);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(490, 233);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 40);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(490, 289);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(131, 40);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 755);
            Controls.Add(btnLoad);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(txtKho);
            Controls.Add(txtGiaSanPham);
            Controls.Add(txtLoaiSanPham);
            Controls.Add(txtTenSanPham);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox txtId;
        private TextBox txtTenSanPham;
        private TextBox txtLoaiSanPham;
        private TextBox txtGiaSanPham;
        private TextBox txtKho;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnLoad;
    }
}