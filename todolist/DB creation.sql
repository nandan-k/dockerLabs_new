create database Sample

USE [Sample]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 4/8/2020 6:14:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

INSERT INTO [dbo].[Product]
           ([Name])
     VALUES
           ('Phone')
		   go
INSERT INTO [dbo].[Product]
           ([Name])
     VALUES
           ('Laptop')
		   go
