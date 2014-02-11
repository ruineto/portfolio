USE [HOUSESDB_52c7d682bb354e82a7b468ea6da62900]
GO

/****** Object:  Table [dbo].[Houses]    Script Date: 07-12-2013 21:56:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Houses](
	[HouseID] [int] IDENTITY(1,1) NOT NULL,
	[HouseName] [nvarchar](100) NOT NULL,
	[HouseDescription] [nvarchar](max) NOT NULL,
	[docID] [int] NOT NULL, 

	CONSTRAINT fk_docID_idxml
	FOREIGN KEY (docID)  -- here you specify the field(s) to reference from in the aircraft table
	REFERENCES XMLDoc (id),  -- here you specify the field(s) to reference to in the model table
	
	CONSTRAINT [PK_dbo.Houses] PRIMARY KEY CLUSTERED 
	(
	[HouseID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
	

GO