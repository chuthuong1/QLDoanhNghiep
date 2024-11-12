using QuanLyDoanhNghiep.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep
{
    public partial class FormPhieuNhap : Form
    {
        QLDoanhNghiepContext db = new QLDoanhNghiepContext();
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo phiếu nhập mới
                var phieuNhap = new PhieuNhap
                {
                    NgayNhap = dtpNgayNhap.Value,
                    IdnhaCungCap = db.NhaCungCaps.FirstOrDefault(ncc => ncc.TenNhaCungCap == cbNhaCungCap.Text).IdnhaCungCap,
                    IdnhanVien = db.NhanViens.FirstOrDefault(nv => nv.TenNhanVien == cbNhanVien.Text).IdnhanVien,
                    TongTien = 0 // Cập nhật sau
                };
                db.PhieuNhaps.Add(phieuNhap);
                db.SaveChanges();

                // Kiểm tra xem sản phẩm đã tồn tại trong bảng SanPham chưa
                var sanPham = db.SanPhams.FirstOrDefault(sp => sp.TenSanPham == cbSanPham.Text);

                // Nếu sản phẩm chưa có, thêm mới sản phẩm
                if (sanPham == null)
                {
                    sanPham = new SanPham
                    {
                        TenSanPham = cbSanPham.Text,
                        Gia = decimal.Parse(txtDonGia.Text), // Giả sử giá nhập vào là giá sản phẩm
                        SoLuongTonKho = int.Parse(txtSoLuong.Text) // Số lượng nhập vào là số lượng tồn kho
                    };

                    db.SanPhams.Add(sanPham);
                    db.SaveChanges();
                }
                else
                {
                    // Nếu sản phẩm đã có, cập nhật lại số lượng tồn kho
                    sanPham.SoLuongTonKho += int.Parse(txtSoLuong.Text);
                    db.SaveChanges();
                }

                // Tạo chi tiết phiếu nhập
                var chiTiet = new ChiTietPhieuNhap
                {
                    IdphieuNhap = phieuNhap.IdphieuNhap,
                    IdsanPham = sanPham.IdsanPham, // Sử dụng Id của sản phẩm vừa tìm thấy hoặc vừa tạo mới
                    SoLuong = int.Parse(txtSoLuong.Text),
                    DonGia = decimal.Parse(txtDonGia.Text),
                    ThanhTien = int.Parse(txtSoLuong.Text) * decimal.Parse(txtDonGia.Text)
                };
                db.ChiTietPhieuNhaps.Add(chiTiet);

                // Cập nhật tổng tiền trong phiếu nhập
                phieuNhap.TongTien = chiTiet.ThanhTien;
                db.SaveChanges();

                // Tải lại dữ liệu lên DataGridView
                loadData();
                MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi nhập hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            loadData();
            loadComboBoxData();
            AddPrintButtonColumn();
        }

        // in phiếu
        private void AddPrintButtonColumn()
        {
            DataGridViewButtonColumn printButtonColumn = new DataGridViewButtonColumn();
            printButtonColumn.Name = "PrintColumn";
            printButtonColumn.HeaderText = "Print";
            printButtonColumn.Text = "In";
            printButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(printButtonColumn);
        }

        private void loadComboBoxData()
        {
            // Lấy dữ liệu cho ComboBox Nha Cung Cấp
            var nhaCungCapList = db.NhaCungCaps.Select(cc => cc.TenNhaCungCap).ToList();
            cbNhaCungCap.DataSource = nhaCungCapList; ;

            // Lấy dữ liệu cho ComboBox Nhân Viên
            var nhanVienList = db.NhanViens.Select(nv => nv.TenNhanVien).ToList();
            cbNhanVien.DataSource = nhanVienList;
            // sản phẩm
            var sanPhamList = db.SanPhams.Select(sp => sp.TenSanPham).ToList();
            cbSanPham.DataSource = sanPhamList;
        }
        private void loadData()
        {
            try
            {
                var data = (from p in db.PhieuNhaps
                            join c in db.ChiTietPhieuNhaps on p.IdphieuNhap equals c.IdphieuNhap
                            join ncc in db.NhaCungCaps on p.IdnhaCungCap equals ncc.IdnhaCungCap
                            join nv in db.NhanViens on p.IdnhanVien equals nv.IdnhanVien
                            join sp in db.SanPhams on c.IdsanPham equals sp.IdsanPham
                            select new
                            {
                                sp.TenSanPham,
                                p.NgayNhap,
                                p.IdphieuNhap,
                                nv.TenNhanVien,
                                NhaCungCapTen = ncc.TenNhaCungCap,
                                c.SoLuong,
                                c.DonGia,
                                c.ThanhTien,
                                p.TongTien,
                            }).ToList();

                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi hiển thị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra nếu người dùng đã click vào một dòng hợp lệ
                if (e.RowIndex >= 0)
                {
                    // Lấy các giá trị từ các ô trong dòng đã chọn
                    var row = dataGridView1.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox và ComboBox
                    cbNhaCungCap.SelectedItem = row.Cells["NhaCungCapTen"].Value.ToString();
                    cbNhanVien.SelectedItem = row.Cells["TenNhanVien"].Value.ToString();
                    cbSanPham.SelectedItem = row.Cells["TenSanPham"].Value.ToString();
                    txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                    txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                    txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                }
                if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "PrintColumn")
                {
                    // Get data from the selected row
                    var row = dataGridView1.Rows[e.RowIndex];

                    // Create a print document with data from the selected row
                    var printDocument = new PrintDocument();
                    printDocument.PrintPage += (sender, args) => PrintReceipt(args);

                    // Show print preview
                    PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                    previewDialog.Document = printDocument;
                    previewDialog.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi chọn dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrintReceipt(PrintPageEventArgs e)
        {
            float yPosition = e.MarginBounds.Top;
            int rowHeight = 30; // Điều chỉnh chiều cao dòng để tránh đè chữ
            Brush brush = Brushes.Black;

            // Fonts for different sections
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);
            Font redFont = new Font("Arial", 12, FontStyle.Bold);
            Brush redBrush = Brushes.Red;
           
            // Header with logo and title
            e.Graphics.DrawString("Cửa hàng xxx - Thái Nguyên", bodyFont, brush, 200, yPosition);
            yPosition += 20;
            e.Graphics.DrawString("1444 Đường 3/2, Sông Công, TP.Thái Nguyên", bodyFont, brush, 200, yPosition);
            yPosition += 20;
            e.Graphics.DrawString("Tel: 09812345678 - www.cuahangxxx.com", bodyFont, brush, 200, yPosition);
            yPosition += 50;

            // Title "PHIẾU NHẬP KHO"
            e.Graphics.DrawString("PHIẾU NHẬP KHO", titleFont, redBrush, e.MarginBounds.Left + 250, yPosition);
            yPosition += 40;
            // Table headers (formatted in a tabular way)
            e.Graphics.DrawString("Số phiếu", headerFont, brush, e.MarginBounds.Left, yPosition);
            e.Graphics.DrawString("Tên nhân viên", headerFont, brush, e.MarginBounds.Left + 100, yPosition);
            e.Graphics.DrawString("Ngày nhập", headerFont, brush, e.MarginBounds.Left + 250, yPosition);
            e.Graphics.DrawString("Tên sản phẩm", headerFont, brush, e.MarginBounds.Left + 400, yPosition);
            e.Graphics.DrawString("Số lượng", headerFont, brush, e.MarginBounds.Left + 550, yPosition);
            e.Graphics.DrawString("Đơn giá", headerFont, brush, e.MarginBounds.Left + 650, yPosition);
            e.Graphics.DrawString("Thành tiền", headerFont, brush, e.MarginBounds.Left + 750, yPosition);

            yPosition += rowHeight;
            // Initialize total amount
            decimal totalAmount = 0;
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if (selectedRow != null)
            {
                // Other details such as Đơn vị and Số phiếu
                // e.Graphics.DrawString("Nhà cung cấp: " + selectedRow.Cells["NhaCungCapTen"].Value.ToString(), headerFont, brush, e.MarginBounds.Left, yPosition);
                // e.Graphics.DrawString("Id phiếu nhập: " + selectedRow.Cells["IDPhieuNhap"].Value.ToString(), headerFont, brush, e.MarginBounds.Left + 400, yPosition);
                // yPosition += 20;
                // In thông tin của dòng được chọn
                // Print data in a row-by-row manner
                e.Graphics.DrawString(selectedRow.Cells["IdphieuNhap"].Value.ToString(), bodyFont, brush, e.MarginBounds.Left, yPosition);
                e.Graphics.DrawString(selectedRow.Cells["TenNhanVien"].Value.ToString(), bodyFont, brush, e.MarginBounds.Left + 100, yPosition);
                e.Graphics.DrawString(Convert.ToDateTime(selectedRow.Cells["NgayNhap"].Value).ToString("dd/MM/yyyy"), bodyFont, brush, e.MarginBounds.Left + 250, yPosition);
                e.Graphics.DrawString(selectedRow.Cells["TenSanPham"].Value.ToString(), bodyFont, brush, e.MarginBounds.Left + 400, yPosition);
                e.Graphics.DrawString(selectedRow.Cells["SoLuong"].Value.ToString(), bodyFont, brush, e.MarginBounds.Left + 550, yPosition);
                e.Graphics.DrawString(selectedRow.Cells["DonGia"].Value.ToString(), bodyFont, brush, e.MarginBounds.Left + 650, yPosition);
                e.Graphics.DrawString(selectedRow.Cells["ThanhTien"].Value.ToString(), bodyFont, brush, e.MarginBounds.Left + 750, yPosition);

                yPosition += rowHeight;

                totalAmount += Convert.ToDecimal(selectedRow.Cells["ThanhTien"].Value);

            }

            // Footer with totals
            yPosition += 20;
            e.Graphics.DrawString("Cộng tiền hàng: ", redFont, redBrush, e.MarginBounds.Left, yPosition);
            e.Graphics.DrawString(totalAmount.ToString("N0"), redFont, redBrush, e.MarginBounds.Left + 500, yPosition);
            yPosition += rowHeight;

            // Calculate and display VAT and grand total
            decimal vat = totalAmount * 0.1m; // 10% VAT
            decimal grandTotal = totalAmount + vat;

            e.Graphics.DrawString("Thuế VAT:", headerFont, brush, e.MarginBounds.Left, yPosition);
            e.Graphics.DrawString(vat.ToString("N0"), headerFont, brush, e.MarginBounds.Left + 500, yPosition);
            yPosition += rowHeight;
            e.Graphics.DrawString("Tổng cộng:", headerFont, brush, e.MarginBounds.Left, yPosition);
            e.Graphics.DrawString(grandTotal.ToString("N0"), headerFont, brush, e.MarginBounds.Left + 500, yPosition);
            yPosition += rowHeight;

            // Convert grand total to words and display it
            string amountInWords = ConvertAmountToWords(grandTotal);
            // Total amount in words and signature fields
            e.Graphics.DrawString("Tổng tiền hàng viết bằng chữ: ", bodyFont, brush, e.MarginBounds.Left, yPosition);
            e.Graphics.DrawString(amountInWords, redFont, redBrush, e.MarginBounds.Left + 210, yPosition);  // Điều chỉnh vị trí sao cho đẹp mắt

            yPosition += 40;
            e.Graphics.DrawString("Duyệt nhập kho", bodyFont, brush, e.MarginBounds.Left, yPosition + 60);
            e.Graphics.DrawString("Người giao hàng", bodyFont, brush, e.MarginBounds.Left + 200, yPosition + 60);
            e.Graphics.DrawString("Lập phiếu", bodyFont, brush, e.MarginBounds.Left + 400, yPosition + 60);
        }

        public static string ConvertAmountToWords(decimal amount)
        {
            // Mảng số đơn vị, chục, trăm
            string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] hundreds = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
            string[] largeUnits = { "", "nghìn", "triệu", "tỷ" }; // Các đơn vị lớn (nghìn, triệu, tỷ)

            try
            {
                if (amount == 0)
                    return "Không đồng";

                int intAmount = (int)amount; // Lấy phần nguyên của số
                string result = "";
                int unitIndex = 0; // Để đếm đơn vị (nghìn, triệu, tỷ)

                // Xử lý phần nghìn, triệu, tỷ
                while (intAmount > 0)
                {
                    int part = intAmount % 1000; // Lấy phần 3 chữ số cuối
                    if (part > 0)
                    {
                        result = ConvertThreeDigitsToWords(part, ones, tens, hundreds) + " " + largeUnits[unitIndex] + " " + result;
                    }
                    intAmount /= 1000; // Chuyển sang phần tiếp theo (triệu, tỷ)
                    unitIndex++;
                }

                result = result.Trim();

                //// Xử lý phần thập phân (nếu có)
                //int decimalPart = (int)((amount - (int)amount) * 100); // Phần thập phân (2 chữ số sau dấu phẩy)
                //if (decimalPart > 0)
                //{
                //    result += " và " + ones[decimalPart / 10] + " " + ones[decimalPart % 10] + " xu";
                //}

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi chọn dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        // Hàm để chuyển đổi 3 chữ số (đơn vị, chục, trăm)
        private static string ConvertThreeDigitsToWords(int part, string[] ones, string[] tens, string[] hundreds)
        {
            string result = "";

            int hundredsPart = part / 100;
            if (hundredsPart > 0)
            {
                result += hundreds[hundredsPart] + " ";
                part %= 100;
            }

            if (part >= 20)
            {
                int tensPart = part / 10;
                result += tens[tensPart] + " ";
                part %= 10;
            }
            else if (part >= 10)
            {
                result += "mười ";
                part %= 10;
            }

            if (part > 0)
            {
                result += ones[part] + " ";
            }

            return result.Trim();
        }



    }
}
