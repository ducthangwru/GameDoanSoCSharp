USE [QLDiem]
GO
/****** Object:  Table [dbo].[NhatKyDiem]    Script Date: 03/24/2017 11:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhatKyDiem](
	[CheDo] [nvarchar](20) NULL,
	[Ten] [nvarchar](50) NULL,
	[Diem] [int] NULL,
	[ThoiGian] [datetime] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[NhatKyDiem] ([CheDo], [Ten], [Diem], [ThoiGian]) VALUES (N'Chế độ Dễ', N'Thắng', 1000, CAST(0x0000A72B00B85894 AS DateTime))
INSERT [dbo].[NhatKyDiem] ([CheDo], [Ten], [Diem], [ThoiGian]) VALUES (N'Chế độ Khó', N'Thắng', 0, CAST(0x0000A74000C7E444 AS DateTime))
