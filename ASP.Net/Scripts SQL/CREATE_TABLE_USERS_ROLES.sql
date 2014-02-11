USE [HOUSESDB_52c7d682bb354e82a7b468ea6da62900]
GO

/****** Object:  Table [dbo].[Users_Roles]    Script Date: 10-12-2013 17:02:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users_Roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUser] [uniqueidentifier] NULL,
	[idRole] [int] NULL
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[Users_Roles]  WITH CHECK ADD  CONSTRAINT [fk_users_role_userID] FOREIGN KEY([idUser])
REFERENCES [dbo].[Users] ([UserId])
GO

ALTER TABLE [dbo].[Users_Roles]  WITH CHECK ADD  CONSTRAINT [fk_users_role_roleID] FOREIGN KEY([idRole])
REFERENCES [dbo].[UserRoles] ([id])
GO