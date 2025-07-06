CREATE TABLE KHACH (
    Id INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    DiaChi NVARCHAR(200),
    GioiTinh NVARCHAR(10)
);
GO

-- Bảng 2: CHUYENBAY (Thông tin chuyến bay)
CREATE TABLE CHUYENBAY (
    MaChuyen INT PRIMARY KEY IDENTITY(1,1),
    TenChuyenBay NVARCHAR(100) NOT NULL,
    SoChoNgoi INT NOT NULL
);
GO

-- Bảng 3: DATVE (Thông tin đặt vé)
CREATE TABLE DATVE (
    IdVe INT PRIMARY KEY IDENTITY(1,1),
    IdKhach INT NOT NULL,
    MaChuyen INT NOT NULL,
    GiaTien DECIMAL(18, 2),
    ThoiGianDatVe DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdKhach) REFERENCES KHACH(Id),
    FOREIGN KEY (MaChuyen) REFERENCES CHUYENBAY(MaChuyen)
);
GO

-- Bảng 4: NHANVIEN (Thông tin người quản lý hệ thống)
CREATE TABLE NHANVIEN (
    MaNV INT PRIMARY KEY IDENTITY(1,1),
    TenNV NVARCHAR(100) NOT NULL,
    Sodt NVARCHAR(20),
    Email NVARCHAR(100) NOT NULL UNIQUE,
    MatKhau NVARCHAR(50) NOT NULL,
    QuyenTruyCap NVARCHAR(20) -- Ví dụ: Admin, User
);
GO

-- Thêm khách hàng mẫu
INSERT INTO KHACH (HoTen, NgaySinh, DiaChi, GioiTinh)
VALUES 
(N'Nguyễn Văn An', '2000-01-01', N'Hà Nội', N'Nam'),
(N'Trần Lê Khả Tâm', '2005-07-26', N'PY', N'Nam'),
(N'Nguyễn Bình Phương Thảo', '2001-02-02', N'Hồ Chí Minh', N'Nữ');

-- Thêm chuyến bay mẫu
INSERT INTO CHUYENBAY (TenChuyenBay, SoChoNgoi)
VALUES 
(N'VN123 - Hà Nội -> Sài Gòn', 150),
(N'VN456 - Đà Nẵng -> Cần Thơ', 100);

-- Thêm nhân viên đăng nhập
INSERT INTO NHANVIEN (TenNV, Sodt, Email, MatKhau, QuyenTruyCap)
VALUES 

(N'Quản trị A', '0123456789', 'admin@myhoi.vn', '@123456', 'Admin'),
(N'Nhân viên B', '0987654321', 'user@myhoi.vn', '@user123', 'User');
