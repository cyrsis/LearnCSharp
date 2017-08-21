-- Detach and Attach
-- Glenn Berry
-- SQLskills.com

-- Database Detach and Attach (SQL Server)
-- http://bit.ly/2sOta8Z

-- Cannot detach a database that is a replication publisher
-- Cannot detach a database that is a mirrored database
-- Cannot detach a database that has any database snapshots

-- Detach AdventureWorks2014 database
-- Make sure you are logged in as sa instead of your Windows login,
-- so that file permissions of the database files don't get changed
USE [master]
GO
ALTER DATABASE AdventureWorks2014 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
EXEC master.dbo.sp_detach_db @dbname = N'AdventureWorks2014';
GO

-- Copy all database files to new location

-- Attach AdventureWorks2014 database in new location
CREATE DATABASE AdventureWorks2014 ON 
(FILENAME = N'T:\SQL2016Data\AdventureWorks2014_Data.mdf'),
(FILENAME = N'T:\SQL2016Logs\AdventureWorks2014_Log.ldf')
 FOR ATTACH;
GO
