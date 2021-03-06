USE [master]
GO
/****** Object:  Database [PE_PRN_Sum21]    Script Date: 04/07/2021 11:15:58 SA ******/
CREATE DATABASE [PE_PRN_Sum21]
GO
USE [PE_PRN_Sum21]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 04/07/2021 11:15:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contract](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[SignedDate] [date] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 04/07/2021 11:15:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Male] [bit] NOT NULL,
	[DOB] [date] NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 04/07/2021 11:15:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NOT NULL,
	[Male] [bit] NOT NULL,
	[Salary] [real] NOT NULL,
	[Phone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Contract] ON 

GO
INSERT [dbo].[Contract] ([Id], [Code], [CustomerId], [EmployeeId], [SignedDate], [Type]) VALUES (1, N'HD01-08/21/1', 1, 1, CAST(N'2021-01-04' AS Date), N'Consultation')
GO
INSERT [dbo].[Contract] ([Id], [Code], [CustomerId], [EmployeeId], [SignedDate], [Type]) VALUES (2, N'HD02-09/21/1', 1, 2, CAST(N'2021-02-05' AS Date), N'Consultation')
GO
INSERT [dbo].[Contract] ([Id], [Code], [CustomerId], [EmployeeId], [SignedDate], [Type]) VALUES (4, N'HD03-09/21/7', 2, 1, CAST(N'2020-01-12' AS Date), N'Deployment')
GO
INSERT [dbo].[Contract] ([Id], [Code], [CustomerId], [EmployeeId], [SignedDate], [Type]) VALUES (5, N'HD04-09/21/1', 2, 2, CAST(N'2020-06-12' AS Date), N'Deployment')
GO
INSERT [dbo].[Contract] ([Id], [Code], [CustomerId], [EmployeeId], [SignedDate], [Type]) VALUES (6, N'HD05-09/21/3', 2, 3, CAST(N'2019-12-07' AS Date), N'Consultation')
GO
INSERT [dbo].[Contract] ([Id], [Code], [CustomerId], [EmployeeId], [SignedDate], [Type]) VALUES (7, N'HD06-09/20/1', 1, 3, CAST(N'2021-04-15' AS Date), N'Deployment')
GO
INSERT [dbo].[Contract] ([Id], [Code], [CustomerId], [EmployeeId], [SignedDate], [Type]) VALUES (8, N'HD07-10/21/1', 3, 1, CAST(N'2020-03-30' AS Date), N'Deployment')
GO
SET IDENTITY_INSERT [dbo].[Contract] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Male], [DOB], [Address]) VALUES (1, N'Nguyen Bao Trung', 1, CAST(N'1980-12-12' AS Date), N'Cau Giay - Ha Noi')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Male], [DOB], [Address]) VALUES (2, N'Nguyen Phuong Thao', 0, CAST(N'1982-09-08' AS Date), N'Ba Dinh - Ha Noi')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Male], [DOB], [Address]) VALUES (3, N'Tran Thu Nga', 0, CAST(N'1990-01-25' AS Date), N'Nguyen Van Cu - Gia Lam - Ha Noi')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

GO
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Male], [Salary], [Phone]) VALUES (1, N'Nguyen Bao Trung', 1, 1100, N'097-7200-300')
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Male], [Salary], [Phone]) VALUES (2, N'Nguyen Phuong Thao', 0, 1050, N'098-7264-300')
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [Male], [Salary], [Phone]) VALUES (3, N'Tran Thu Nga', 0, 1320, N'096-6278-890')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_Contract_Customer]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_Contract_Employee]
GO
USE [master]
GO
ALTER DATABASE [PE_PRN_Sum21] SET  READ_WRITE 
GO
