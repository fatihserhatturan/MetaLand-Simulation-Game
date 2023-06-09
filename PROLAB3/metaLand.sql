USE [metaLand]
GO
/****** Object:  Table [dbo].[alan_info]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alan_info](
	[alan_no] [int] NULL,
	[alan_türü] [nvarchar](50) NULL,
	[alan_sahibi] [nvarchar](50) NULL,
	[alan_harita] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[basvuru_info]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basvuru_info](
	[basvuru_no] [int] NULL,
	[basvuru_isim] [nvarchar](50) NULL,
	[basvuru_saat] [int] NULL,
	[basvuru_ucret] [int] NULL,
	[basvuru_alan_sahip] [nvarchar](50) NULL,
	[basvuru_alan_no] [int] NULL,
	[basvuru_alan_harita] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[calısan_info]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calısan_info](
	[calısan_ad] [nvarchar](50) NULL,
	[calısan_harita] [nvarchar](50) NULL,
	[calısan_alan_no] [int] NULL,
	[calısan_saat] [int] NULL,
	[calısan_ucret] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emlak]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emlak](
	[emlak_no] [int] NULL,
	[emlak_komisyon] [int] NULL,
	[emlak_islem] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[harita_info]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[harita_info](
	[harita_id] [nvarchar](50) NULL,
	[harita_boyut] [int] NULL,
	[harita_tarih] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[isletme]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[isletme](
	[isletme_yiyecek_gideri] [int] NULL,
	[isletme_esya_gideri] [int] NULL,
	[isletme_para_gideri] [int] NULL,
	[isletme_türü] [nchar](10) NULL,
	[isletme_sahibi] [nchar](10) NULL,
	[isletme_no] [int] NULL,
	[isletme_yönetici_ücreti] [int] NULL,
	[isletme_kullanıcı_ücreti] [int] NULL,
	[isletme_seviyesi] [int] NULL,
	[isletme_kapasitesi] [int] NULL,
	[isletme_calısan_sayısı] [int] NULL,
	[isletme_fiyatı] [int] NULL,
	[isletme_kiralık_fiyatı] [int] NULL,
	[isletme_sabit_gelir] [int] NULL,
	[isletme_sabit_oranı] [int] NULL,
	[isletme_seviye_baslangıc_tarih] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kira]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kira](
	[kira_no] [int] NULL,
	[kira_sure] [int] NULL,
	[kira_baslangıc_tarih] [nchar](10) NULL,
	[kira_bitis_tarih] [nchar](10) NULL,
	[kira_islem_kodu] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanıcı_baslangıc_info]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanıcı_baslangıc_info](
	[kullanıcı_no] [int] NULL,
	[kullanıcı_baslangıc_yemek] [int] NULL,
	[kullanıcı_baslangıc_esya] [int] NULL,
	[kullanıcı_baslangıc_para] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanıcı_info]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanıcı_info](
	[kullanıcı_no] [int] NULL,
	[kullanıcı_adı] [nvarchar](50) NULL,
	[kullanıcı_soyadı] [nvarchar](50) NULL,
	[kullanıcı_sifresi] [nvarchar](50) NULL,
	[yemek_miktarı] [int] NULL,
	[esya_miktarı] [int] NULL,
	[para_miktarı] [int] NULL,
	[kullanıcı_harita] [nvarchar](50) NULL,
	[kullanıcı_kayıt_tarih] [nvarchar](50) NULL,
	[kullanıcı_meslek] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[magaza]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[magaza](
	[magaza_no] [int] NULL,
	[magaza_harita] [nvarchar](50) NULL,
	[magaza_ücret] [int] NULL,
	[magaza_seviye] [int] NULL,
	[magaza_kapasite] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[market]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[market](
	[market_no] [int] NULL,
	[market_harita] [nvarchar](50) NULL,
	[market_ücret] [int] NULL,
	[market_seviye] [int] NULL,
	[market_kapasite] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oyun_info]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oyun_info](
	[oyun_no] [int] NULL,
	[oyun_tarih] [nvarchar](50) NULL,
	[oyun_boyut] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ürün_info]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ürün_info](
	[ürün_ID] [int] NULL,
	[ürün_türü] [nvarchar](50) NULL,
	[ürün_sahibi] [nvarchar](50) NULL,
	[ürün_fiyat] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yönetici_info]    Script Date: 28.05.2023 12:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yönetici_info](
	[yönetici_ad] [nvarchar](50) NULL,
	[yönetici_sifre] [nvarchar](50) NULL,
	[yönetici_para] [int] NULL,
	[yönetici_esya] [int] NULL,
	[yönetici_yemek] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (1, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (2, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (3, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (4, N'arsa', N'a', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (5, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (6, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (7, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (8, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (9, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (10, N'market', N'a', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (11, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (12, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (13, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (14, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (15, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (16, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (17, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (18, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (19, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (20, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (21, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (22, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (23, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (24, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (25, N'arsa', N'fatti', N'3')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (NULL, NULL, N'fatti', NULL)
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (0, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (1, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (2, N'magaza', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (3, N'market', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (4, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (5, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (6, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (7, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (8, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (9, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (10, N'magaza', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (11, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (12, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (13, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (14, N'arsa', N'a', N'98')
INSERT [dbo].[alan_info] ([alan_no], [alan_türü], [alan_sahibi], [alan_harita]) VALUES (15, N'arsa', N'a', N'98')
GO
INSERT [dbo].[basvuru_info] ([basvuru_no], [basvuru_isim], [basvuru_saat], [basvuru_ucret], [basvuru_alan_sahip], [basvuru_alan_no], [basvuru_alan_harita]) VALUES (9317, N'a', 9, 60, N'a', 3, N'98')
INSERT [dbo].[basvuru_info] ([basvuru_no], [basvuru_isim], [basvuru_saat], [basvuru_ucret], [basvuru_alan_sahip], [basvuru_alan_no], [basvuru_alan_harita]) VALUES (6601, N'muko', 10, 50, N'a', 3, N'98')
GO
INSERT [dbo].[calısan_info] ([calısan_ad], [calısan_harita], [calısan_alan_no], [calısan_saat], [calısan_ucret]) VALUES (N'a', N'98', 3, 7, 50)
GO
INSERT [dbo].[harita_info] ([harita_id], [harita_boyut], [harita_tarih]) VALUES (N'2', 5, CAST(N'2023-05-24T14:30:00.000' AS DateTime))
INSERT [dbo].[harita_info] ([harita_id], [harita_boyut], [harita_tarih]) VALUES (N'4', 4, CAST(N'2023-05-24T14:30:00.000' AS DateTime))
INSERT [dbo].[harita_info] ([harita_id], [harita_boyut], [harita_tarih]) VALUES (N'78', 2, CAST(N'2023-05-24T14:30:00.000' AS DateTime))
INSERT [dbo].[harita_info] ([harita_id], [harita_boyut], [harita_tarih]) VALUES (N'9', 3, CAST(N'2023-05-24T14:30:00.000' AS DateTime))
INSERT [dbo].[harita_info] ([harita_id], [harita_boyut], [harita_tarih]) VALUES (N'98', 4, CAST(N'2023-06-01T14:30:00.000' AS DateTime))
INSERT [dbo].[harita_info] ([harita_id], [harita_boyut], [harita_tarih]) VALUES (NULL, NULL, CAST(N'2023-05-24T14:30:00.000' AS DateTime))
GO
INSERT [dbo].[kullanıcı_info] ([kullanıcı_no], [kullanıcı_adı], [kullanıcı_soyadı], [kullanıcı_sifresi], [yemek_miktarı], [esya_miktarı], [para_miktarı], [kullanıcı_harita], [kullanıcı_kayıt_tarih], [kullanıcı_meslek]) VALUES (NULL, N'a', N'b', N'c', NULL, NULL, NULL, NULL, NULL, N'magaza')
INSERT [dbo].[kullanıcı_info] ([kullanıcı_no], [kullanıcı_adı], [kullanıcı_soyadı], [kullanıcı_sifresi], [yemek_miktarı], [esya_miktarı], [para_miktarı], [kullanıcı_harita], [kullanıcı_kayıt_tarih], [kullanıcı_meslek]) VALUES (NULL, N'fatih', N'turan', N'2002Fsm.', NULL, NULL, NULL, NULL, NULL, N'arsa')
INSERT [dbo].[kullanıcı_info] ([kullanıcı_no], [kullanıcı_adı], [kullanıcı_soyadı], [kullanıcı_sifresi], [yemek_miktarı], [esya_miktarı], [para_miktarı], [kullanıcı_harita], [kullanıcı_kayıt_tarih], [kullanıcı_meslek]) VALUES (90507, N'a', N'b', N'c', 100, 70, 970, N'78', NULL, N'market')
INSERT [dbo].[kullanıcı_info] ([kullanıcı_no], [kullanıcı_adı], [kullanıcı_soyadı], [kullanıcı_sifresi], [yemek_miktarı], [esya_miktarı], [para_miktarı], [kullanıcı_harita], [kullanıcı_kayıt_tarih], [kullanıcı_meslek]) VALUES (98150, N'mustafa', N'surmeli', N'2002Fsm.', 60, 100, 960, N'98', N'May 25 2023  7:13PM', N'magaza')
INSERT [dbo].[kullanıcı_info] ([kullanıcı_no], [kullanıcı_adı], [kullanıcı_soyadı], [kullanıcı_sifresi], [yemek_miktarı], [esya_miktarı], [para_miktarı], [kullanıcı_harita], [kullanıcı_kayıt_tarih], [kullanıcı_meslek]) VALUES (86731, N'', N'', N'', 90, 100, 990, NULL, N'May 25 2023  7:36PM', N'magaza')
INSERT [dbo].[kullanıcı_info] ([kullanıcı_no], [kullanıcı_adı], [kullanıcı_soyadı], [kullanıcı_sifresi], [yemek_miktarı], [esya_miktarı], [para_miktarı], [kullanıcı_harita], [kullanıcı_kayıt_tarih], [kullanıcı_meslek]) VALUES (44916, N'', N'', N'', 100, 70, 970, NULL, N'May 25 2023  7:41PM', N'market')
INSERT [dbo].[kullanıcı_info] ([kullanıcı_no], [kullanıcı_adı], [kullanıcı_soyadı], [kullanıcı_sifresi], [yemek_miktarı], [esya_miktarı], [para_miktarı], [kullanıcı_harita], [kullanıcı_kayıt_tarih], [kullanıcı_meslek]) VALUES (49649, N'muko', N'turan', N'20022002', 48, 70, 910, N'98', N'May 25 2023  7:49PM', N'arsa')
INSERT [dbo].[kullanıcı_info] ([kullanıcı_no], [kullanıcı_adı], [kullanıcı_soyadı], [kullanıcı_sifresi], [yemek_miktarı], [esya_miktarı], [para_miktarı], [kullanıcı_harita], [kullanıcı_kayıt_tarih], [kullanıcı_meslek]) VALUES (69897, N'', N'', N'', 70, 70, 970, NULL, N'May 25 2023  7:42PM', N'arsa')
INSERT [dbo].[kullanıcı_info] ([kullanıcı_no], [kullanıcı_adı], [kullanıcı_soyadı], [kullanıcı_sifresi], [yemek_miktarı], [esya_miktarı], [para_miktarı], [kullanıcı_harita], [kullanıcı_kayıt_tarih], [kullanıcı_meslek]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'magaza')
GO
INSERT [dbo].[magaza] ([magaza_no], [magaza_harita], [magaza_ücret], [magaza_seviye], [magaza_kapasite]) VALUES (2, N'98', 5, 1, 3)
GO
INSERT [dbo].[market] ([market_no], [market_harita], [market_ücret], [market_seviye], [market_kapasite]) VALUES (3, N'98', 5, 1, 3)
GO
INSERT [dbo].[ürün_info] ([ürün_ID], [ürün_türü], [ürün_sahibi], [ürün_fiyat]) VALUES (5, N'arsa', N'fatti', 890)
INSERT [dbo].[ürün_info] ([ürün_ID], [ürün_türü], [ürün_sahibi], [ürün_fiyat]) VALUES (8, N'arsa', N'fatti', 1450)
GO
INSERT [dbo].[yönetici_info] ([yönetici_ad], [yönetici_sifre], [yönetici_para], [yönetici_esya], [yönetici_yemek]) VALUES (N'fatti', N'fsm2002.', 6700, 10000, 10000)
INSERT [dbo].[yönetici_info] ([yönetici_ad], [yönetici_sifre], [yönetici_para], [yönetici_esya], [yönetici_yemek]) VALUES (N'a', N'b', 990, 1012, 80)
GO
