CREATE PROCEDURE [dbo].[UpdateXmlDoc]
(
@Original_id int,
@thedoc xml
)
AS
BEGIN
SET NOCOUNT OFF;
UPDATE [XMLDoc] set thedoc = @thedoc WHERE (([id] = @Original_id))
END
GO