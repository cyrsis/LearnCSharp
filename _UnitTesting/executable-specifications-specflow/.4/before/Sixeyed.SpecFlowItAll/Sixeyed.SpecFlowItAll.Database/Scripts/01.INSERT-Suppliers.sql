
USE [Sixeyed.SpecFlowItAll.Database]
GO

DELETE Suppliers;

SET IDENTITY_INSERT Suppliers ON

INSERT INTO [dbo].[Suppliers] ([SupplierId], [Name], [ReorderType], [ReorderAddress])     
VALUES  (1, 'Great big enterprise supplier', 1, '.\private$\outgoing-supplier-order');

INSERT INTO [dbo].[Suppliers] ([SupplierId], [Name], [ReorderType], [ReorderAddress])     
VALUES  (2, 'Medium-sized quite modern supplier', 2, 'net.pipe://localhost/Sixeyed.SpecFlowItAll.Stubs.WcfService/OrderService.svc');

INSERT INTO [dbo].[Suppliers] ([SupplierId], [Name], [ReorderType], [ReorderAddress])     
VALUES  (3, 'Small old-fashioned supplier', 3, 'bigjim@oldfashionedsupplier.com');

SET IDENTITY_INSERT Suppliers OFF
