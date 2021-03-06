USE [atm]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2021-01-06 12:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountID] [char](10) NOT NULL,
	[AccountName] [nvarchar](50) NOT NULL,
	[AccountBank] [int] NOT NULL,
	[AccountType] [bit] NOT NULL,
	[Balance] [float] NOT NULL,
	[Grade] [int] NOT NULL,
	[UserID] [char](10) NOT NULL,
	[Flow] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authority]    Script Date: 2021-01-06 12:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authority](
	[ID] [int] NOT NULL,
	[Draw] [float] NOT NULL,
	[Loan] [float] NOT NULL,
	[Upgrade] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 2021-01-06 12:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 2021-01-06 12:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2021-01-06 12:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [char](10) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([AccountID], [AccountName], [AccountBank], [AccountType], [Balance], [Grade], [UserID], [Flow]) VALUES (N'1608122415', N'测试账户银行', 3, 1, 479, 1, N'0000000000', 719)
INSERT [dbo].[Account] ([AccountID], [AccountName], [AccountBank], [AccountType], [Balance], [Grade], [UserID], [Flow]) VALUES (N'1608122520', N'管理员账户', 5, 1, 70, 1, N'0000000000', 170)
INSERT [dbo].[Account] ([AccountID], [AccountName], [AccountBank], [AccountType], [Balance], [Grade], [UserID], [Flow]) VALUES (N'1609871228', N'4343434', 3, 1, 50, 1, N'1582978976', 150)
GO
INSERT [dbo].[Authority] ([ID], [Draw], [Loan], [Upgrade]) VALUES (0, 1000, 0, 0)
INSERT [dbo].[Authority] ([ID], [Draw], [Loan], [Upgrade]) VALUES (1, 2000, 1000, 10000)
INSERT [dbo].[Authority] ([ID], [Draw], [Loan], [Upgrade]) VALUES (2, 5000, 2000, 20000)
INSERT [dbo].[Authority] ([ID], [Draw], [Loan], [Upgrade]) VALUES (3, 10000, 5000, 50000)
INSERT [dbo].[Authority] ([ID], [Draw], [Loan], [Upgrade]) VALUES (4, 20000, 10000, 100000)
INSERT [dbo].[Authority] ([ID], [Draw], [Loan], [Upgrade]) VALUES (5, 50000, 20000, 200000)
GO
INSERT [dbo].[Bank] ([Id], [Name]) VALUES (0, N'中国人民银行')
INSERT [dbo].[Bank] ([Id], [Name]) VALUES (1, N'中国工商银行')
INSERT [dbo].[Bank] ([Id], [Name]) VALUES (2, N'中国建设银行')
INSERT [dbo].[Bank] ([Id], [Name]) VALUES (3, N'中国招商银行')
INSERT [dbo].[Bank] ([Id], [Name]) VALUES (4, N'中国农业银行')
INSERT [dbo].[Bank] ([Id], [Name]) VALUES (5, N'中国银行')
INSERT [dbo].[Bank] ([Id], [Name]) VALUES (6, N'中国发展银行')
INSERT [dbo].[Bank] ([Id], [Name]) VALUES (7, N'光大银行')
INSERT [dbo].[Bank] ([Id], [Name]) VALUES (8, N'广发银行')
GO
INSERT [dbo].[Grade] ([Id], [Name]) VALUES (0, N'普通存储用户')
INSERT [dbo].[Grade] ([Id], [Name]) VALUES (1, N'普通信用用户')
INSERT [dbo].[Grade] ([Id], [Name]) VALUES (2, N'青铜用户')
INSERT [dbo].[Grade] ([Id], [Name]) VALUES (3, N'白银用户')
INSERT [dbo].[Grade] ([Id], [Name]) VALUES (4, N'黄金用户')
INSERT [dbo].[Grade] ([Id], [Name]) VALUES (5, N'钻石用户')
GO
INSERT [dbo].[User] ([UserID], [UserName], [PassWord]) VALUES (N'0000000000', N'admin', N'root')
INSERT [dbo].[User] ([UserID], [UserName], [PassWord]) VALUES (N'1582978976', N'test', N'test')
INSERT [dbo].[User] ([UserID], [UserName], [PassWord]) VALUES (N'1603369376', N'李四', N'lisi')
INSERT [dbo].[User] ([UserID], [UserName], [PassWord]) VALUES (N'1608122287', N'Didnelpsun', N'0824')
GO
ALTER TABLE [dbo].[Authority] ADD  DEFAULT ((0)) FOR [ID]
GO
ALTER TABLE [dbo].[Authority] ADD  DEFAULT ((0)) FOR [Draw]
GO
ALTER TABLE [dbo].[Authority] ADD  DEFAULT ((0)) FOR [Loan]
GO
ALTER TABLE [dbo].[Authority] ADD  DEFAULT ((0)) FOR [Upgrade]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_AccountBank_ToBankID] FOREIGN KEY([AccountBank])
REFERENCES [dbo].[Bank] ([Id])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_AccountBank_ToBankID]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Grade_ToGradeID] FOREIGN KEY([Grade])
REFERENCES [dbo].[Grade] ([Id])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Grade_ToGradeID]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_UserID_ToUserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_UserID_ToUserID]
GO
