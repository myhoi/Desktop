CREATE DATABASE QLThuVien;
GO
USE QLThuVien;

CREATE TABLE SACH (
    MaSach NVARCHAR(10) PRIMARY KEY,
    Tensach NVARCHAR(100),
    Tacgia NVARCHAR(100),
    Namxuatban INT,
    Nhaxuatban NVARCHAR(100),
    Trigia MONEY,
    NgayNhap DATE
);

CREATE TABLE PHIEUMUONSACH (
    MaPhieuMuon NVARCHAR(10) PRIMARY KEY,
    NgayMuon DATE,
    NgayTra DATE
);

CREATE TABLE THONGTINMUONSACH (
    MaSach NVARCHAR(10),
    MaPhieuMuon NVARCHAR(10),
    PRIMARY KEY (MaSach, MaPhieuMuon),
    FOREIGN KEY (MaSach) REFERENCES SACH(MaSach),
    FOREIGN KEY (MaPhieuMuon) REFERENCES PHIEUMUONSACH(MaPhieuMuon)
);

CREATE TABLE TAIKHOAN (
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50)
);

INSERT INTO SACH (MaSach, TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap)
VALUES 
('S01', 'Lap trinh C#', 'Nguyen Van A', 2020, 'NXB Tri', 120000, '2024-01-15'),
('S02', 'Cau truc du lieu', 'Tran Thi B', 2021, 'NXB Giao Duc', 95000, '2024-02-01'),
('S03', 'Co so du lieu', 'Le Van C', 2019, 'NXB Thong Ke', 110000, '2024-03-10'),
('S04', 'Tin hoc van phong', 'Pham Minh D', 2022, 'NXB Lao Dong', 80000, '2024-04-05');

INSERT INTO PHIEUMUONSACH (MaPhieuMuon, NgayMuon, NgayTra)
VALUES 
('PM01', '2024-06-01', '2024-06-10'),
('PM02', '2024-06-05', '2024-06-25'), -- quá h?n
('PM03', '2024-06-10', '2024-06-22'),
('PM04', '2024-06-15', '2024-07-05'); -- quá h?n

INSERT INTO THONGTINMUONSACH (MaSach, MaPhieuMuon)
VALUES 
('S01', 'PM01'),
('S02', 'PM02'),
('S03', 'PM03'),
('S04', 'PM04');

INSERT INTO TAIKHOAN (TenDangNhap, MatKhau)
VALUES 
(N'admin', N'@123456'),
(N'user1', N'@abc123');
