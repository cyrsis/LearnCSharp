-- Stored Procedures

SELECT ProductID, SUM(OrderQty) Orders, AVG(UnitPrice) 'Avg Price', SUM(LineTotal) Total
FROM Sales.SalesOrderDetail
WHERE ProductID=776
GROUP BY ProductID


CREATE PROC ProdOrders
AS
SELECT ProductID, SUM(OrderQty) Orders, AVG(UnitPrice) 'Avg Price', SUM(LineTotal) Total
FROM Sales.SalesOrderDetail
WHERE ProductID=776
GROUP BY ProductID

EXEC ProdOrders

