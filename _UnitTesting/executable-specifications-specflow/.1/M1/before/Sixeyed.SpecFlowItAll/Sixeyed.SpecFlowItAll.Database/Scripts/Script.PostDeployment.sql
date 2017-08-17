
--static data:

USE [Sixeyed.SpecFlowItAll.Database]
GO

INSERT INTO [dbo].[Suppliers] ([Name], [ReorderType], [ReorderAddress])     
VALUES  ('Great big enterprise supplier', 1, '.\private$\outgoing-supplier-order');

INSERT INTO [dbo].[Suppliers] ([Name], [ReorderType], [ReorderAddress])     
VALUES  ('Medium-sized quite modern supplier', 2, 'net.pipe://localhost/Sixeyed.SpecFlowItAll.Stubs.WcfService/OrderService.svc');

INSERT INTO [dbo].[Suppliers] ([Name], [ReorderType], [ReorderAddress])     
VALUES  ('Small old-fashioned supplier', 3, 'bigjim@oldfashionedsupplier.com');

INSERT INTO [dbo].[Products]([SupplierId], [Code], [Name], [StockCount], [IsAvailable])
VALUES (1, 'dahon-vitesse-sprocket', 'Sprocket for Nexus (6-speed hub gear)', 20, 1);

INSERT INTO [dbo].[Products]([SupplierId], [Code], [Name], [StockCount], [IsAvailable])
VALUES (1, 'brooks-b17', 'Brooks B17 saddle', 80, 1);


INSERT INTO [dbo].[Products]([SupplierId], [Code], [Name], [StockCount], [IsAvailable])
VALUES (2, 'self-raising', 'Self-raising flour (1Kg)', 600, 1);

INSERT INTO [dbo].[Products]([SupplierId], [Code], [Name], [StockCount], [IsAvailable])
VALUES (2, 'chocolate-sprinkles', 'Chocolate sprinkles', 2000, 1);


INSERT INTO [dbo].[Products]([SupplierId], [Code], [Name], [StockCount], [IsAvailable])
VALUES (3, 'fish-heads', 'Fish heads (bucket)', 3, 1);

INSERT INTO [dbo].[Products]([SupplierId], [Code], [Name], [StockCount], [IsAvailable])
VALUES (3, 'cat-biscuits', 'Cat biscuits (3Kg)', 150, 1);