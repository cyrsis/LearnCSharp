CREATE TABLE [dbo].[Products]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SupplierId] INT NOT NULL, 
	    [Code] NVARCHAR(50) NOT NULL, 
    [Name] NVARCHAR(250) NOT NULL, 
    [StockCount] INT NOT NULL DEFAULT 0, 
    [IsAvailable] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY (SupplierId) REFERENCES Suppliers(SupplierId)
)

GO

CREATE INDEX [IX_Products_Code] ON [dbo].[Products] ([Code])
