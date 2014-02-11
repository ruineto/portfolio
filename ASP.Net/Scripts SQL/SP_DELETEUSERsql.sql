USE [HOUSESDB_52c7d682bb354e82a7b468ea6da62900]
GO

/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 11-12-2013 16:59:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteUser]
	@userID uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM [dbo].Houses_Users WHERE [dbo].Houses_Users.UserId = @userID;
	DELETE FROM [dbo].Users_Roles WHERE [dbo].Users_Roles.idUser = @userID;
	DELETE FROM [dbo].Users WHERE [dbo].Users.UserId = @userID;
	DELETE FROM [aspnet-FinalProject-20131128135829].[dbo].Memberships WHERE [aspnet-FinalProject-20131128135829].[dbo].Memberships.UserId = @userID
	DELETE FROM [aspnet-FinalProject-20131128135829].[dbo].UsersInRoles WHERE [aspnet-FinalProject-20131128135829].[dbo].UsersInRoles.UserId = @userID
	DELETE FROM [aspnet-FinalProject-20131128135829].[dbo].Users WHERE [aspnet-FinalProject-20131128135829].[dbo].Users.UserId = @userID
END

GO


