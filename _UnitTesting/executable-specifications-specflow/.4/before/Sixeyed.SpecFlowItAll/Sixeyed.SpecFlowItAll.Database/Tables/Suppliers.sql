CREATE TABLE [dbo].[Suppliers]
(
	[SupplierId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(250) NOT NULL, 
    [ReorderType] INT NOT NULL, 
    [ReorderAddress] NVARCHAR(100) NULL
)
