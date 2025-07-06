CREATE DATABASE QLThuvien;
GO

USE QLThuvien;
GO

CREATE TABLE SACH (
    MaSach VARCHAR(10) PRIMARY KEY,
    TenSach NVARCHAR(200) NOT NULL,
    TacGia NVARCHAR(100),
    NamXuatBan INT,
    NhaXuatBan NVARCHAR(100),
    TriGia DECIMAL(10,2),
    SoLuong INT DEFAULT 0
);

CREATE TABLE THONGTINMUONSACH (
    MaPhieuMuon VARCHAR(10) PRIMARY KEY,
    MaSach VARCHAR(10),
    NgayMuon DATE,
    NgayTra DATE,
    SoLuongMuon INT,
    FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
);

CREATE TABLE PhieuMuonSach (
    MaPhieuMuon VARCHAR(10) PRIMARY KEY,
    NgayMuon DATE,
    NgayTra DATE,
    MaSach VARCHAR(10),
    SoLuongMuon INT,
    TrangThai NVARCHAR(20) DEFAULT N'Đang mượn',
    FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
);

CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(100) NOT NULL,
    LoaiTaiKhoan NVARCHAR(20) DEFAULT N'User'
);

INSERT INTO SACH (MaSach, TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, SoLuong) VALUES
('S001', N'Lập trình C# cơ bản', N'Nguyễn Văn A', 2020, N'NXB Thông tin', 150000, 10),
('S002', N'Cấu trúc dữ liệu và thuật toán', N'Trần Thị B', 2019, N'NXB Giáo dục', 200000, 8),
('S003', N'Cơ sở dữ liệu SQL Server', N'Lê Văn C', 2021, N'NXB Khoa học', 180000, 12),
('S004', N'Phát triển ứng dụng Web', N'Phạm Thị D', 2020, N'NXB Thông tin', 220000, 6),
('S005', N'Mạng máy tính', N'Hoàng Văn E', 2018, N'NXB Đại học', 190000, 15);

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan) VALUES
('admin', '123456', N'Admin'),
('user1', '123456', N'User'),
('user2', '123456', N'User');

INSERT INTO PhieuMuonSach (MaPhieuMuon, NgayMuon, NgayTra, MaSach, SoLuongMuon, TrangThai) VALUES
('PM001', '2024-01-15', '2024-01-30', 'S001', 1, N'Đã trả'),
('PM002', '2024-02-10', '2024-02-25', 'S002', 2, N'Đã trả'),
('PM003', '2024-03-05', '2024-03-20', 'S003', 1, N'Đang mượn'),
('PM004', '2024-03-10', '2024-03-25', 'S001', 1, N'Đang mượn'),
('PM005', '2024-03-15', '2024-03-30', 'S004', 1, N'Quá hạn');