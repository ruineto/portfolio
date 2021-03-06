USE [aspnet-FinalProject-20131128135829]
GO
/****** Object:  Trigger [dbo].[Trg_Users]    Script Date: 11-12-2013 16:36:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[Trg_Users]
   ON  [dbo].[Users] 
   AFTER INSERT
AS 
BEGIN
   
      INSERT INTO [HOUSESDB_52c7d682bb354e82a7b468ea6da62900].dbo.Users(Users.UserId, Users.UserName, Users.IsAnonymous, Users.ApplicationId, Users.LastActivityDate)
      SELECT INSERTED.UserId AS UserId, INSERTED.UserName AS UserName, INSERTED.IsAnonymous AS IsAnonymous,INSERTED.ApplicationId AS ApplicationId, INSERTED.LastActivityDate AS LastActivityDate
      FROM INSERTED

	  INSERT INTO [HOUSESDB_52c7d682bb354e82a7b468ea6da62900].dbo.Users_Roles(idUser,idRole)
	  SELECT INSERTED.UserId AS UserIdInserted, 1 AS idRole
	  FROM INSERTED
END