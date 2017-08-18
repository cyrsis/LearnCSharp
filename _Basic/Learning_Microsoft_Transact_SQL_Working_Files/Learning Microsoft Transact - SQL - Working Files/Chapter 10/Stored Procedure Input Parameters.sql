-- Stored Procedures
-- Input Parameters

SELECT ProductID, SUM(OrderQty) Orders, AVG(UnitPrice) 'Avg Price', SUM(LineTotal) Total
FROM Sales.SalesOrderDetail
WHERE ProductID=776 -- We need to change the ProductID when we call the procedure
GROUP BY ProductID

-- Here's the original procedure
CREATE PROC ProdOrders
AS
SELECT ProductID, SUM(OrderQty) Orders, AVG(UnitPrice) 'Avg Price', SUM(LineTotal) Total
FROM Sales.SalesOrderDetail
WHERE ProductID=776
GROUP BY ProductID


-- Here's the new procedure that accepts input parameters
CREATE PROC ProdOrdersIP
@ID int
AS
SELECT ProductID, SUM(OrderQty) Orders, AVG(UnitPrice) 'Avg Price', SUM(LineTotal) Total
FROM Sales.SalesOrderDetail
WHERE ProductID=@ID
GROUP BY ProductID

EXEC ProdOrdersIP 778

