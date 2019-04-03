CREATE PROCEDURE GetAllSites 
AS
BEGIN
	SET NOCOUNT ON;

	SELECT s.SiteId, s.SiteName
	FROM Sites s
END
GO

CREATE PROCEDURE GetAllDocTypes
AS
BEGIN
	SET NOCOUNT ON;

	SELECT d.DocTypeId, d.DocType
	FROM Doc_Types d
END
GO

CREATE PROCEDURE UpdateSite
	@SiteId		varchar(10),
	@SiteName	varchar(150)
AS

UPDATE Sites
	SET SiteName = @SiteName
WHERE SiteId = @SiteId
GO

CREATE PROCEDURE UpdateDocType
	@DocTypeId		int,
	@DocTypeName	VARCHAR(150)
AS

UPDATE Doc_Types
	SET DocType = @DocTypeName
WHERE DocTypeId = @DocTypeId
GO