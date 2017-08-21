-- Query Store Plan Forcing
-- Glenn Berry
-- SQLskills.com

SET NOCOUNT ON;

SET STATISTICS IO ON;

USE [AdventureWorks2014];
GO

-- Take a look at the data
SELECT ProductID, COUNT(*) AS [Production Count]
FROM Production.TransactionHistoryArchive
GROUP BY ProductID
ORDER BY COUNT(*) DESC;

-- Clear the Query Store for AdventureWorks2014
ALTER DATABASE AdventureWorks2014 SET QUERY_STORE CLEAR;

-- Run two parameterized queries in a single batch

-- Flush the plan cache for this database
ALTER DATABASE SCOPED CONFIGURATION CLEAR PROCEDURE_CACHE;
GO
-- Query 1
EXEC sp_executesql
@stmt = N'SELECT p.name AS [Product Name], a.TransactionType,
         a.TransactionDate, a.Quantity, a.ActualCost
FROM Production.Product AS p
INNER JOIN Production.TransactionHistoryArchive AS a
ON p.ProductID = a.ProductID
WHERE p.ProductID = @productID', 
@params = N'@productID INT',
@productID = 475;

PRINT N'Query 1 Complete';

-- Flush the plan cache for this database
ALTER DATABASE SCOPED CONFIGURATION CLEAR PROCEDURE_CACHE;
-- Query 2
EXEC sp_executesql
@stmt = N'SELECT p.name AS [Product Name], a.TransactionType,
         a.TransactionDate, a.Quantity, a.ActualCost
FROM Production.Product AS p
INNER JOIN Production.TransactionHistoryArchive AS a
ON p.ProductID = a.ProductID
WHERE p.ProductID = @productID', 
@params = N'@productID INT',
@productID = 712;


-- Look at information in the Query Store
SELECT qt.query_sql_text, p.plan_id, p.query_id, 
       rs.last_duration, rs.last_logical_io_reads,
       CAST(p.query_plan AS XML) AS [Execution Plan]   
FROM sys.query_store_query AS q
INNER JOIN sys.query_store_plan AS p
ON q.query_id = p.query_id
INNER JOIN sys.query_store_query_text AS qt
ON q.query_text_id = qt.query_text_id
INNER JOIN sys.query_store_runtime_stats AS rs WITH (NOLOCK)
ON rs.plan_id = p.plan_id
ORDER BY p.plan_id;


-- Force a query plan
EXEC sp_query_store_force_plan 1, 1;


-- Run two parameterized queries in a single batch
EXEC sp_executesql
@stmt = N'SELECT p.name AS [Product Name], a.TransactionType,
         a.TransactionDate, a.Quantity, a.ActualCost
FROM Production.Product AS p
INNER JOIN Production.TransactionHistoryArchive AS a
ON p.ProductID = a.ProductID
WHERE p.ProductID = @productID', 
@params = N'@productID INT',
@productID = 475;

PRINT N'Query 1 Complete';

EXEC sp_executesql
@stmt = N'SELECT p.name AS [Product Name], a.TransactionType,
         a.TransactionDate, a.Quantity, a.ActualCost
FROM Production.Product AS p
INNER JOIN Production.TransactionHistoryArchive AS a
ON p.ProductID = a.ProductID
WHERE p.ProductID = @productID', 
@params = N'@productID INT',
@productID = 712;


-- Unforce a query plan
EXEC sp_query_store_unforce_plan 2, 2; 



