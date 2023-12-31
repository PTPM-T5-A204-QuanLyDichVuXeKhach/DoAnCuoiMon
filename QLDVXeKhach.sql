USE [QLDVXeKhach]
GO
/****** Object:  Table [dbo].[ChuyenXe]    Script Date: 11/1/2023 10:22:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenXe](
	[MaCX] [nchar](5) NOT NULL,
	[DiemDi] [nvarchar](50) NOT NULL,
	[DiemDen] [nvarchar](50) NOT NULL,
	[NgayDi] [date] NULL,
	[GiaVe] [money] NULL,
	[MaNV] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiaDiem]    Script Date: 11/1/2023 10:22:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaDiem](
	[ThanhPho] [nvarchar](50) NOT NULL,
	[BenXe] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ThanhPho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/1/2023 10:22:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[TenKH] [nvarchar](50) NOT NULL,
	[Sdt] [nchar](10) NULL,
	[MaVX] [nchar](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/1/2023 10:22:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[Email] [nchar](30) NULL,
	[CCCD] [nchar](12) NULL,
	[ChucVu] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/1/2023 10:22:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nchar](30) NOT NULL,
	[MatKhau] [nchar](100) NOT NULL,
	[MaCV] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeXe]    Script Date: 11/1/2023 10:22:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeXe](
	[MaVX] [nchar](5) NOT NULL,
	[SoGheNgoi] [nchar](5) NULL,
	[NgayDatVe] [date] NULL,
	[MaXe] [nchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 11/1/2023 10:22:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [nchar](5) NOT NULL,
	[Tentx] [nvarchar](50) NOT NULL,
	[BienSX] [nvarchar](50) NOT NULL,
	[SoGhe] [int] NULL,
	[SoGheDaDat] [int] NULL,
	[TinhTrang] [nvarchar](20) NULL,
	[GioKhoiHanh] [datetime] NULL,
	[MaCX] [nchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChuyenXe] ([MaCX], [DiemDi], [DiemDen], [NgayDi], [GiaVe], [MaNV]) VALUES (N'CX025', N'Cần Thơ', N'Nha Trang', CAST(N'2023-10-29' AS Date), 700000.0000, N'QL1234    ')
INSERT [dbo].[ChuyenXe] ([MaCX], [DiemDi], [DiemDen], [NgayDi], [GiaVe], [MaNV]) VALUES (N'CX153', N'Hồ Chí Minh (Sài Gòn)', N'Đà Nẵng', CAST(N'2023-11-04' AS Date), 1560000.0000, N'QL1234    ')
INSERT [dbo].[ChuyenXe] ([MaCX], [DiemDi], [DiemDen], [NgayDi], [GiaVe], [MaNV]) VALUES (N'CX417', N'Nha Trang', N'Đà Nẵng', CAST(N'2023-11-16' AS Date), 1750000.0000, N'QL1234    ')
GO
INSERT [dbo].[DiaDiem] ([ThanhPho], [BenXe]) VALUES (N'Cần Thơ', N'Bến xe Cần Thơ')
INSERT [dbo].[DiaDiem] ([ThanhPho], [BenXe]) VALUES (N'Đà Nẵng', N'Bến xe trung tâm Đà Nẵng')
INSERT [dbo].[DiaDiem] ([ThanhPho], [BenXe]) VALUES (N'Hà Nội', N'Bến xe Giáp Bát')
INSERT [dbo].[DiaDiem] ([ThanhPho], [BenXe]) VALUES (N'Hải Phòng', N'Bến xe Cầu Rào 2')
INSERT [dbo].[DiaDiem] ([ThanhPho], [BenXe]) VALUES (N'Hồ Chí Minh (Sài Gòn)', N'Bến xe Miền Đông')
INSERT [dbo].[DiaDiem] ([ThanhPho], [BenXe]) VALUES (N'Huế', N'Bến xe Huế')
INSERT [dbo].[DiaDiem] ([ThanhPho], [BenXe]) VALUES (N'Nha Trang', N'Bến xe Nha Trang')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Email], [CCCD], [ChucVu]) VALUES (N'NV1234    ', N'Trần Bảo', N'tb123@gmail.com               ', N'098765432178', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Email], [CCCD], [ChucVu]) VALUES (N'NV3905    ', N'Nguyễn Văn Hoàng', N'nvh@gmail.com                 ', N'123456789056', N'Nhân Viên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Email], [CCCD], [ChucVu]) VALUES (N'NV4777    ', N'Phan Hòa', N'ph123@gmail.com               ', N'098765432123', N'Nhân Viên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Email], [CCCD], [ChucVu]) VALUES (N'QL1234    ', N'Nguyên Bảo', N'nb123@gmail.com               ', N'123456789012', N'Quản lý')
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [MaCV]) VALUES (N'dfsdfsd                       ', N'@Df123                                                                                              ', N'NV1234    ')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [MaCV]) VALUES (N'nb123                         ', N'@Nb123                                                                                              ', N'QL1234    ')
GO
INSERT [dbo].[Xe] ([MaXe], [Tentx], [BienSX], [SoGhe], [SoGheDaDat], [TinhTrang], [GioKhoiHanh], [MaCX]) VALUES (N'X639 ', N'Nguyễn A', N'NA1-67890', 16, 0, N'Còn ghế', CAST(N'2023-11-01T15:00:00.000' AS DateTime), N'CX025')
INSERT [dbo].[Xe] ([MaXe], [Tentx], [BienSX], [SoGhe], [SoGheDaDat], [TinhTrang], [GioKhoiHanh], [MaCX]) VALUES (N'X787 ', N'Huy Toàn', N'ED1-12345', 16, 0, N'Còn ghế', CAST(N'2023-11-01T08:00:00.000' AS DateTime), N'CX025')
INSERT [dbo].[Xe] ([MaXe], [Tentx], [BienSX], [SoGhe], [SoGheDaDat], [TinhTrang], [GioKhoiHanh], [MaCX]) VALUES (N'X906 ', N'Phan Hoàng', N'AB1-09876', 30, 0, N'Còn ghế', CAST(N'2023-11-01T07:00:00.000' AS DateTime), N'CX025')
GO
ALTER TABLE [dbo].[ChuyenXe]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaVX])
REFERENCES [dbo].[VeXe] ([MaVX])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[VeXe]  WITH CHECK ADD FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD FOREIGN KEY([MaCX])
REFERENCES [dbo].[ChuyenXe] ([MaCX])
GO
