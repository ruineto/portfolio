USE [HOUSESDB_52c7d682bb354e82a7b468ea6da62900]
GO

/****** Object:  Table [dbo].[Houses_Users]    Script Date: 08-12-2013 02:21:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Houses_Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[HouseId] [int] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Houses_Users]  WITH CHECK ADD  CONSTRAINT [fk_houseID] FOREIGN KEY([HouseId])
REFERENCES [dbo].[Houses] ([HouseID])
GO

ALTER TABLE [dbo].[Houses_Users] CHECK CONSTRAINT [fk_houseID]
GO

ALTER TABLE [dbo].[Houses_Users]  WITH CHECK ADD  CONSTRAINT [fk_userID] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO

ALTER TABLE [dbo].[Houses_Users] CHECK CONSTRAINT [fk_userID]
GO


