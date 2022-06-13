/****** Object:  Database [PRUEBAS]    Script Date: 1/05/2022 12:32:07 a. m. ******/
CREATE DATABASE [ExperienzaDB]

GO


USE [ExperienzaDB]
GO

/****** Object:  Table [dbo].[Authors]    Script Date: 1/05/2022 12:20:45 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Authors](
	[ID] [uniqueidentifier] not NULL,
	[FullName] [varchar](50) not NULL,
	[DateBirth] [datetime] NULL,
	[City] [varchar](20) NULL,
	[Gmail] [varchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Authors]
ADD CONSTRAINT PK_Authors_ID PRIMARY KEY CLUSTERED (ID);


/****** Object:  Table [dbo].[Publisher]    Script Date: 1/05/2022 12:24:06 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Publisher](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](20)NOT NULL,
	[Address] [varchar](30) NULL,
	[PhoneNumber] [varchar](10) NULL,
	[MaxiBooks] [varchar](3) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Publisher]
ADD CONSTRAINT PK_Publisher_ID PRIMARY KEY CLUSTERED (ID);

/****** Object:  Table [dbo].[Books]    Script Date:  ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books](
	[Id] [uniqueidentifier] NOT NULL,	
	[Title] VARCHAR (55) NOT NULL,
	[Year] [varchar](5) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[NumberPages] [int] NULL,
	[Publisher] [uniqueidentifier] NOT NULL,
	[Authors] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([Authors])
REFERENCES [dbo].[Authors] ([ID])
GO

ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO

ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publisher] FOREIGN KEY([Publisher])
REFERENCES [dbo].[Publisher] ([ID])
GO

ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publisher]
GO


/****** Object:  Table [dbo].[Books]   
Scaffold-DbContext "Server=.\DESKTOP-4NS4PAE\SQLEXPRESS;Database=ExperienzaDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

 Script Date:  ******/

