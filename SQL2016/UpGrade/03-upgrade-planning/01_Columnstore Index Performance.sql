-- Testing a Clustered Columnstore Index
-- Glenn Berry
-- SQLskills.com

-- Columnstore Indexes Guide
-- http://bit.ly/1djYOCW

-- Using Clustered Columnstore Indexes
-- http://bit.ly/2qXzglX


-- Switch to correct database
USE AdventureWorks2014;
GO

-- Two new tables have been added to the AdventureWorks2014 database
-- dbo.bigTransactionHistoryPageCompressed  - Uses Row store PAGE data compression
-- dbo.bigTransactionHistoryCCSI			- Uses a clustered columnstore index

-- Each table has identical data and a row count of 62.5 million rows

-- You can use any large table for similar testing

-- Turn on Graphical Execution Plan (Ctrl + M)

-- Collect I/O statistics
SET STATISTICS IO ON;

SET NOCOUNT ON;

-- Flush dirty pages to disk
CHECKPOINT;

-- Flush buffer pool (don't do this in Production)
-- This will force SQL Server to do physical reads
DBCC DROPCLEANBUFFERS;



-- Query 1 *******************************
DECLARE @StartTime datetime = GETDATE();

-- Force a clustered index scan from row store index with PAGE compression
SELECT COUNT(*) AS [Row Count]
FROM dbo.bigTransactionHistoryPageCompressed WITH (INDEX(0));

DECLARE @EndTime datetime = GETDATE();
DECLARE @ElapsedTime int = DATEDIFF(ms, @StartTime, @EndTime);
SELECT @ElapsedTime AS [Query 1 Elapsed Time in ms]
PRINT 'Query 1 Done';
PRINT ' ';

-- Query 2 ********************************
SET @StartTime = GETDATE();

-- Force an index scan from clustered columnstore index 
SELECT COUNT(*) AS [Row Count]
FROM dbo.bigTransactionHistoryCCSI WITH (INDEX(0));

SET @EndTime = GETDATE();
SET @ElapsedTime = DATEDIFF(ms, @StartTime, @EndTime);
SELECT @ElapsedTime AS [Query 2 Elapsed Time in ms]
PRINT 'Query 2 Done';
PRINT ' ';




-- Query 1 Elapsed time 17156ms, 98% of batch cost  
-- Table 'bigTransactionHistoryPageCompressed'. Scan count 8, logical reads 121437, physical reads 1, read-ahead reads 120753, lob logical reads 0, lob physical reads 0, lob read-ahead reads 0.

-- Query 2 Elapsed time 344ms, 2% of batch cost
-- Table 'bigTransactionHistoryCCSI'. Scan count 8, logical reads 0, physical reads 0, read-ahead reads 0, lob logical reads 425, lob physical reads 2, lob read-ahead reads 3.
-- Table 'bigTransactionHistoryCCSI'. Segment reads 63, segment skipped 0.
-- Table 'Worktable'. Scan count 0, logical reads 0, physical reads 0, read-ahead reads 0, lob logical reads 0, lob physical reads 0, lob read-ahead reads 0.