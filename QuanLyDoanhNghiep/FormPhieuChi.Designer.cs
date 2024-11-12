namespace QuanLyDoanhNghiep
{
    partial class FormPhieuChi
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
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            txtIdPhieuChi = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbThanhToan = new ComboBox();
            txtSoTien = new TextBox();
            txtIdPhieuNhap = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            cbNhanVienChi = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 86);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 0;
            label1.Text = "Id Phiếu chi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 478);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(1185, 453);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(740, 86);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtIdPhieuChi
            // 
            txtIdPhieuChi.Location = new Point(254, 86);
            txtIdPhieuChi.Name = "txtIdPhieuChi";
            txtIdPhieuChi.Size = new Size(175, 35);
            txtIdPhieuChi.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(237, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 35);
            dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 145);
            label2.Name = "label2";
            label2.Size = new Size(149, 30);
            label2.TabIndex = 6;
            label2.Text = "ID Phiếu Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 194);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 7;
            label3.Text = "Ngày Chi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 252);
            label4.Name = "label4";
            label4.Size = new Size(77, 30);
            label4.TabIndex = 8;
            label4.Text = "Số tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 312);
            label5.Name = "label5";
            label5.Size = new Size(158, 30);
            label5.TabIndex = 9;
            label5.Text = "loại Thanh toán";
            // 
            // cbThanhToan
            // 
            cbThanhToan.FormattingEnabled = true;
            cbThanhToan.Location = new Point(237, 312);
            cbThanhToan.Name = "cbThanhToan";
            cbThanhToan.Size = new Size(212, 38);
            cbThanhToan.TabIndex = 10;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(237, 249);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(175, 35);
            txtSoTien.TabIndex = 11;
            // 
            // txtIdPhieuNhap
            // 
            txtIdPhieuNhap.Location = new Point(254, 145);
            txtIdPhieuNhap.Name = "txtIdPhieuNhap";
            txtIdPhieuNhap.Size = new Size(175, 35);
            txtIdPhieuNhap.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(678, 218);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(976, 368);
            button3.Name = "button3";
            button3.Size = new Size(131, 40);
            button3.TabIndex = 14;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(834, 289);
            button4.Name = "button4";
            button4.Size = new Size(131, 40);
            button4.TabIndex = 15;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 378);
            label6.Name = "label6";
            label6.Size = new Size(141, 30);
            label6.TabIndex = 16;
            label6.Text = "Nhân viên chi";
            // 
            // cbNhanVienChi
            // 
            cbNhanVienChi.FormattingEnabled = true;
            cbNhanVienChi.Location = new Point(237, 378);
            cbNhanVienChi.Name = "cbNhanVienChi";
            cbNhanVienChi.Size = new Size(212, 38);
            cbNhanVienChi.TabIndex = 17;
            // 
            // FormPhieuChi
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 979);
            Controls.Add(cbNhanVienChi);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtIdPhieuNhap);
            Controls.Add(txtSoTien);
            Controls.Add(cbThanhToan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtIdPhieuChi);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FormPhieuChi";
            Text = "FormPhieuChi";
            Load += FormPhieuChi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnThem;
        private TextBox txtIdPhieuChi;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbThanhToan;
        private TextBox txtSoTien;
        private TextBox txtIdPhieuNhap;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label6;
        private ComboBox cbNhanVienChi;
    }
}