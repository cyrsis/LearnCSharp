
-- Post Migration Tasks
-- Glenn Berry
-- SQLskills.com


-- Switch to 130 compatibility level
USE [master]
GO
ALTER DATABASE [AdventureWorks] SET COMPATIBILITY_LEVEL = 130;
GO

-- Enable Query Store for this database
ALTER DATABASE [AdventureWorks] SET QUERY_STORE = ON;
GO
ALTER DATABASE [AdventureWorks] SET QUERY_STORE (OPERATION_MODE = READ_WRITE);
GO

-- Change a database scoped configuration property (if necessary)
USE [AdventureWorks]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO


-- Run sp_updatestats
-- You may want to do a more complete job later
EXEC sp_updatestats;


-- Take a full database backup
BACKUP DATABASE [AdventureWorks] 
TO  DISK = N'M:\SQLBackups\AdventureWorksFullCompressed.bak' WITH NOFORMAT, INIT,  
NAME = N'AdventureWorks-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, COMPRESSION,  STATS = 1, CHECKSUM;
GO

-- Check the AdventureWorks database with MAXDOP = 4    
DBCC CHECKDB (AdventureWorks) WITH MAXDOP = 4;    
GO   


