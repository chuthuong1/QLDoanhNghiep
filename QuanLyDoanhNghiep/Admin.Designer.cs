namespace QuanLyDoanhNghiep
{
    partial class Admin
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnPhieuNhap = new Button();
            button5 = new Button();
            btnPhieuChi = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(57, 58);
            button1.Name = "button1";
            button1.Size = new Size(231, 40);
            button1.TabIndex = 0;
            button1.Text = "QuanLyNhanVien";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(57, 126);
            button2.Name = "button2";
            button2.Size = new Size(245, 40);
            button2.TabIndex = 1;
            button2.Text = "QuanLySanPham";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(57, 188);
            button3.Name = "button3";
            button3.Size = new Size(258, 40);
            button3.TabIndex = 2;
            button3.Text = "QuanLyKhachHang";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(57, 243);
            button4.Name = "button4";
            button4.Size = new Size(266, 40);
            button4.TabIndex = 3;
            button4.Text = "HoadDon";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.Location = new Point(65, 305);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Size = new Size(131, 40);
            btnPhieuNhap.TabIndex = 4;
            btnPhieuNhap.Text = "Nhập Hàng";
            btnPhieuNhap.UseVisualStyleBackColor = true;
            btnPhieuNhap.Click += btnPhieuNhap_Click;
            // 
            // button5
            // 
            button5.Location = new Point(69, 378);
            button5.Name = "button5";
            button5.Size = new Size(254, 40);
            button5.TabIndex = 5;
            button5.Text = "Quản Lý nhà cung cấp";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnPhieuChi
            // 
            btnPhieuChi.Location = new Point(81, 455);
            btnPhieuChi.Name = "btnPhieuChi";
            btnPhieuChi.Size = new Size(131, 40);
            btnPhieuChi.TabIndex = 6;
            btnPhieuChi.Text = "Phiếu Chi";
            btnPhieuChi.UseVisualStyleBackColor = true;
            btnPhieuChi.Click += btnPhieuChi_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 586);
            Controls.Add(btnPhieuChi);
            Controls.Add(button5);
            Controls.Add(btnPhieuNhap);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnPhieuNhap;
        private Button button5;
        private Button btnPhieuChi;
    }
}