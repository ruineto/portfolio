USE [MYSTORE_f0c09aed25694345ab4c5d52383674b9]
GO

/****** Object:  Table [dbo].[XMLDoc]    Script Date: 06-12-2013 19:54:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[XMLDoc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[theDoc] [xml] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

