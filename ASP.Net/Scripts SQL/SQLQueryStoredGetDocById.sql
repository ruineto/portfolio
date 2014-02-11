CREATE PROCEDURE XMLDoc_byUserID
(
@userID uniqueidentifier
)
AS
BEGIN
SELECT dbo.XMLDoc.theDoc 
FROM dbo.XMLDoc INNER JOIN (SELECT dbo.Houses.docID FROM dbo.Houses_Users INNER JOIN dbo.Houses ON 
Houses_Users.UserId=@userID AND Houses_Users.HouseId=Houses.HouseID) as HOUSE
ON HOUSE.docID = dbo.XMLDoc.id
END



