-- Database scoped T-SQL Commands in SQL Server 2016 
-- Glenn Berry
-- SQLskills.com

USE [WideWorldImporters]
GO

-- ALTER DATABASE SCOPED CONFIGURATION (Transact-SQL)
-- http://bit.ly/2pRz5uw



-- Get database scoped configuration values for current database 
SELECT configuration_id, name, [value] AS [value_for_primary], value_for_secondary
FROM sys.database_scoped_configurations WITH (NOLOCK) OPTION (RECOMPILE);

  
-- Enable legacy Cardinality Estimation for Primary database
-- Equivalent to using TF 4136, except this is only for this database
ALTER DATABASE SCOPED CONFIGURATION 
SET LEGACY_CARDINALITY_ESTIMATION = ON;
GO


-- Disable parameter sniffing for Primary database
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = OFF;
GO

-- Enable query optimizer fixes for Primary database
-- Equivalent to using TF 4199, except this is only for this database
ALTER DATABASE SCOPED CONFIGURATION 
SET QUERY_OPTIMIZER_HOTFIXES = ON;
GO
 
-- Set MAXDOP for Primary database
ALTER DATABASE SCOPED CONFIGURATION 
SET MAXDOP = 4;
GO

-- Clear plan cache for current database (only possible for Primary database)
ALTER DATABASE SCOPED CONFIGURATION CLEAR PROCEDURE_CACHE;
GO


-- Get database scoped configuration values for current database 
SELECT configuration_id, name, [value] AS [value_for_primary], value_for_secondary
FROM sys.database_scoped_configurations WITH (NOLOCK) OPTION (RECOMPILE);

-- The commands for the secondary database affect ALL secondary databases in an AlwaysOn AG