USE [HOUSESDB_52c7d682bb354e82a7b468ea6da62900]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateUserRole]
	@userID uniqueidentifier,
	@roleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE [dbo].Users_Roles SET idRole = @roleID WHERE Users_Roles.idUser = @userID
    
END
GO
