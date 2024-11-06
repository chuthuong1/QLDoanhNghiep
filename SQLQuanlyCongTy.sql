CREATE TABLE Khach_Hang (
    ID_KhachHang INT PRIMARY KEY,
    Ten_KhachHang NVARCHAR(100),
    Loai_KhachHang NVARCHAR(50),
    DiaChi NVARCHAR(200),
    DienThoai NVARCHAR(15),
    Email NVARCHAR(100)
);

CREATE TABLE Nhan_Vien (
    ID_NhanVien INT PRIMARY KEY,
    Ten_NhanVien NVARCHAR(100),
    ChucVu NVARCHAR(50),
    PhongBan NVARCHAR(50),
    DiaChi NVARCHAR(200),
    DienThoai NVARCHAR(15)
);

CREATE TABLE San_Pham (
    ID_SanPham INT PRIMARY KEY,
    Ten_SanPham NVARCHAR(100),
    ChuLoai NVARCHAR(50),
    Gia DECIMAL(18, 2),
    SoLuong_TonKho INT
);

CREATE TABLE Hoa_Don_Ban (
    ID_HoaDon INT PRIMARY KEY,
    ID_KhachHang INT,
    ID_NhanVien INT,
    Ngay_Ban DATE,
    Tong_Tien DECIMAL(18, 2),
    Loai_ThanhToan NVARCHAR(50),
    FOREIGN KEY (ID_KhachHang) REFERENCES Khach_Hang(ID_KhachHang),
    FOREIGN KEY (ID_NhanVien) REFERENCES Nhan_Vien(ID_NhanVien)
);

CREATE TABLE Chi_Tiet_Hoa_Don_Ban (
    ID_ChiTietHD_Ban INT PRIMARY KEY,
    ID_HoaDon INT,
    ID_SanPham INT,
    SoLuong INT,
    DonGia DECIMAL(18, 2),
    ThanhTien AS (SoLuong * DonGia),
    FOREIGN KEY (ID_HoaDon) REFERENCES Hoa_Don_Ban(ID_HoaDon),
    FOREIGN KEY (ID_SanPham) REFERENCES San_Pham(ID_SanPham)
);

CREATE TABLE Nha_Cung_Cap (
    ID_NhaCungCap INT PRIMARY KEY,
    Ten_NhaCungCap NVARCHAR(100),
    DiaChi NVARCHAR(200),
    DienThoai NVARCHAR(15),
    Email NVARCHAR(100)
);

CREATE TABLE Phieu_Nhap (
    ID_PhieuNhap INT PRIMARY KEY,
    ID_NhaCungCap INT,
    ID_NhanVien INT,
    NgayNhap DATE,
    Tong_Tien DECIMAL(18, 2),
    FOREIGN KEY (ID_NhaCungCap) REFERENCES Nha_Cung_Cap(ID_NhaCungCap),
    FOREIGN KEY (ID_NhanVien) REFERENCES Nhan_Vien(ID_NhanVien)
);

CREATE TABLE Chi_Tiet_Phieu_Nhap (
    ID_ChiTiet_PhieuNhap INT PRIMARY KEY,
    ID_PhieuNhap INT,
    ID_SanPham INT,
    SoLuong INT,
    DonGia DECIMAL(18, 2),
    ThanhTien AS (SoLuong * DonGia),
    FOREIGN KEY (ID_PhieuNhap) REFERENCES Phieu_Nhap(ID_PhieuNhap),
    FOREIGN KEY (ID_SanPham) REFERENCES San_Pham(ID_SanPham)
);

CREATE TABLE Kiem_Ke_Hang_Hoa (
    ID_KiemKe INT PRIMARY KEY,
    ID_SanPham INT,
    SoLuong_TonKho INT,
    Ngay_KiemKe DATE,
    FOREIGN KEY (ID_SanPham) REFERENCES San_Pham(ID_SanPham)
);

CREATE TABLE Phieu_Thu (
    ID_PhieuThu INT PRIMARY KEY,
    ID_HoaDon INT,
    NgayThu DATE,
    SoTien DECIMAL(18, 2),
    Loai_ThanhToan NVARCHAR(50),
    FOREIGN KEY (ID_HoaDon) REFERENCES Hoa_Don_Ban(ID_HoaDon)
);

CREATE TABLE Phieu_Chi (
    ID_PhieuChi INT PRIMARY KEY,
    ID_PhieuNhap INT,
    NgayChi DATE,
    SoTien DECIMAL(18, 2),
    Loai_ThanhToan NVARCHAR(50),
    FOREIGN KEY (ID_PhieuNhap) REFERENCES Phieu_Nhap(ID_PhieuNhap)
);
-- Dữ liệu mẫu cho bảng Khach_Hang
INSERT INTO Khach_Hang (ID_KhachHang, Ten_KhachHang, Loai_KhachHang, DiaChi, DienThoai, Email) 
VALUES (1, N'Nguyễn Văn A', N'Khách vãng lai', N'Hà Nội', '0123456789', 'nva@gmail.com'),
       (2, N'Trần Thị B', N'Khách doanh nghiệp', N'Hải Phòng', '0987654321', 'ttb@company.com'),
       (3, N'Lê Văn C', N'Khách vãng lai', N'Đà Nẵng', '0234567890', 'lvc@gmail.com'),
       (4, N'Phạm Thị D', N'Khách doanh nghiệp', N'TP. Hồ Chí Minh', '0345678901', 'ptd@company.vn'),
       (5, N'Hoàng Văn E', N'Khách vãng lai', N'Cần Thơ', '0456789012', 'hve@gmail.com');

-- Dữ liệu mẫu cho bảng Nhan_Vien
INSERT INTO Nhan_Vien (ID_NhanVien, Ten_NhanVien, ChucVu, PhongBan, DiaChi, DienThoai) 
VALUES (1, N'Phạm Quang H', N'Nhân viên bán hàng', N'Bán hàng', N'Hà Nội', '0567890123'),
       (2, N'Trần Thanh M', N'Trưởng phòng', N'Kho', N'TP. Hồ Chí Minh', '0678901234'),
       (3, N'Ngô Phương L', N'Nhân viên nhập hàng', N'Kho', N'Hải Phòng', '0789012345'),
       (4, N'Võ Văn K', N'Kế toán', N'Tài chính', N'Da Nang', '0890123456'),
       (5, N'Bùi Thu N', N'Nhân viên bán hàng', N'Bán hàng', N'TP. Hồ Chí Minh', '0901234567');

-- Dữ liệu mẫu cho bảng San_Pham
INSERT INTO San_Pham (ID_SanPham, Ten_SanPham, ChuLoai, Gia, SoLuong_TonKho) 
VALUES (1, N'Sản phẩm A', N'Loại 1', 100000, 50),
       (2, N'Sản phẩm B', N'Loại 2', 200000, 30),
       (3, N'Sản phẩm C', N'Loại 1', 150000, 40),
       (4, N'Sản phẩm D', N'Loại 3', 300000, 20),
       (5, N'Sản phẩm E', N'Loại 2', 250000, 25);

-- Dữ liệu mẫu cho bảng Nha_Cung_Cap
INSERT INTO Nha_Cung_Cap (ID_NhaCungCap, Ten_NhaCungCap, DiaChi, DienThoai, Email) 
VALUES (1, N'Công ty XNK ABC', N'Hà Nội', '0111222333', 'abc@export.vn'),
       (2, N'Công ty TM XYZ', N'Hải Phòng', '0222333444', 'xyz@trading.com'),
       (3, N'DNTN Hoàng Hà', N'TP. Hồ Chí Minh', '0333444555', 'hoangha@gmail.com'),
       (4, N'Công ty CP Duy Tân', N'Đà Nẵng', '0444555666', 'duytan@company.vn'),
       (5, N'Công ty TNHH Phương Nam', N'Cần Thơ', '0555666777', 'phuongnam@gmail.com');

-- Dữ liệu mẫu cho bảng Hoa_Don_Ban
INSERT INTO Hoa_Don_Ban (ID_HoaDon, ID_KhachHang, ID_NhanVien, Ngay_Ban, Tong_Tien, Loai_ThanhToan) 
VALUES (1, 1, 1, '2024-10-01', 150000, N'Tiền mặt'),
       (2, 2, 2, '2024-10-05', 300000, N'Thẻ tín dụng'),
       (3, 3, 1, '2024-10-10', 100000, N'Tiền mặt'),
       (4, 4, 3, '2024-10-15', 250000, N'Chuyển khoản'),
       (5, 5, 2, '2024-10-20', 200000, N'Tiền mặt');
