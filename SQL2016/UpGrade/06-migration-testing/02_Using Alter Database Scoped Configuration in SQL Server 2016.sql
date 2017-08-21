-- Using Database scoped T-SQL Commands in SQL Server 2016 
-- Glenn Berry
-- SQLskills.com


-- Get database scoped configuration values for current database 
SELECT configuration_id, [name], [value] AS [value_for_primary]
FROM sys.database_scoped_configurations WITH (NOLOCK) OPTION (RECOMPILE);

  
-- ALTER DATABASE SCOPED CONFIGURATION (Transact-SQL)
-- http://bit.ly/2sOH7nb

 

USE AdventureWorksLT2008R2
GO

-- Clear plan cache for current database 
ALTER DATABASE SCOPED CONFIGURATION CLEAR PROCEDURE_CACHE;
GO
 
-- Enable legacy Cardinality Estimation for Primary database
-- Equivalent to using TF 4136, except this is only for this database
ALTER DATABASE SCOPED CONFIGURATION 
SET LEGACY_CARDINALITY_ESTIMATION = ON;
GO

-- Set MAXDOP for Primary database
ALTER DATABASE SCOPED CONFIGURATION 
SET MAXDOP = 8;
GO

-- Get database scoped configuration values for current database 
SELECT configuration_id, [name], [value] AS [value_for_primary]
FROM sys.database_scoped_configurations WITH (NOLOCK) OPTION (RECOMPILE);

 


 

