-- Creating a View

Use AdventureWorks2012

SELECT * FROM Sales.SalesOrderDetail

CREATE VIEW vOrders
AS
SELECT SalesOrderID, OrderQty, ProductID, LineTotal
FROM Sales.SalesOrderDetail

SELECT * FROM vOrders