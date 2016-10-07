USE [WindXinZ-UserDb]
GO

/****** Object:  Table [dbo].[OrmModel]    Script Date: 2016/10/3 12:23:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserModel](
	[Id] [nvarchar](128) NOT NULL,
	[Version] [int] NOT NULL,
	[CreateStamp] [float] NOT NULL,
	[DeleteStamp] [float] NULL,
	[IsDelete] [bit] NOT NULL,
	[ModifyStamp] [float] NOT NULL,
	[Name] [nvarchar](32) NULL,
	[IdCardNo] [nvarchar](32) NULL,
	[Password] [nvarchar](64) NULL,
	[UserName] [nvarchar](32) NULL,
	[NickName] [nvarchar](32) NULL,
	[HeadPic] [nvarchar](32) NULL,
	[PhoneNo] [nvarchar](32) NULL,
	[Sex] [int] NOT NULL,
	[UserType] [int] NOT NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_dbo.UserModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[UserLoginHistoryModel](
	[Id] [nvarchar](128) NOT NULL,
	[Version] [int] NOT NULL,
	[CreateStamp] [float] NOT NULL,
	[DeleteStamp] [float] NULL,
	[IsDelete] [bit] NOT NULL,
	[ModifyStamp] [float] NOT NULL,
	[UserId] [nvarchar](32) NOT NULL,
	[UserName] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.UserLoginHistoryModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


