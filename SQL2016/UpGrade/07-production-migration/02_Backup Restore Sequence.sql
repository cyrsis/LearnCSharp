-- Backup and Restore
-- Glenn Berry
-- SQLskills.com

-- LABDB02 is legacy instance, running SQL Server 2012
-- LABDB01 is new instance, running SQL Server 2016

-- Must enable SQLCMD mode from Query menu

-- Editing SQLCMD Scripts in the Transact-SQL Editor
-- http://bit.ly/2sLW21J

-- Connect to legacy instance, using SQL Server authentication
:CONNECT LABDB02 -U sa -P 1994Acura#
-- Full database backup from legacy server to UNC file share on new instance
-- Make sure SQL Server Service Account has read/write access to file share
BACKUP DATABASE AdventureWorks 
TO  DISK = N'\\LABDB01\SQLBackups\AdventureWorksTest.bak' WITH NOFORMAT, INIT,  
NAME = N'AdventureWorks-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, COMPRESSION,  STATS = 1, CHECKSUM;
GO

-- Depending on the size of the database, and how long the full backup takes,
-- you may need to also run one or more transaction log backups

-- Connect to new instance, using SQL Server authentication
:CONNECT LABDB01 -U sa -P 1994Acura#

-- Restore database on new SQL Server 2016 instance, with no recovery
USE [master]
RESTORE DATABASE AdventureWorks 
FROM  DISK = N'M:\SQLBackups\AdventureWorksTest.bak' WITH  FILE = 1, NORECOVERY, NOUNLOAD,  REPLACE,  STATS = 1;
GO

-- Depending on the size of the database, and how long the full backup takes,
-- you may need to restore one or more transaction log backups

-- Connect to new instance, using SQL Server authentication
:CONNECT LABDB01 -U sa -P 1994Acura#
-- Recover the database (if you are done restoring log backups)
RESTORE DATABASE AdventureWorks WITH RECOVERY;





