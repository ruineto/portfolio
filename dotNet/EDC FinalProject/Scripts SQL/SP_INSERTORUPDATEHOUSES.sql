
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertOrUpdateHouse]
	-- Add the parameters for the stored procedure here
	@userID uniqueidentifier,
	@houseID int
AS

If Exists(select UserId from Houses_Users where UserId = @userID)
begin
       Update Houses_Users  Set HouseId = @houseID where UserId = @userID
End
Else
Begin
       Insert Into Houses_Users (UserId, HouseId) Values (@userID, @houseID)
End

GO

