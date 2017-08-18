-- Migrating with Database Mirroring
-- Glenn Berry
-- SQLskills.com

-- LABDB02 is legacy instance, running SQL Server 2012
-- LABDB01 is new instance, running SQL Server 2016

-- AdventureWorks database has already been mirrored from LABDB02 to LABDB01

-- Must enable SQLCMD mode from Query menu

-- Editing SQLCMD Scripts in the Transact-SQL Editor
-- http://bit.ly/2sLW21J

-- Check mirroring status (we want to be in asynchronous mode)
:CONNECT LABDB02 -U sa -P 1994Acura#
SELECT @@SERVERNAME AS [Server Name], DB_NAME(Database_id) AS [Database Name], mirroring_role_desc, 
       mirroring_state_desc, mirroring_safety_level_desc, mirroring_partner_name, mirroring_witness_name,
	   mirroring_witness_state_desc, mirroring_failover_lsn, mirroring_connection_timeout
FROM sys.database_mirroring
WHERE mirroring_guid IS NOT NULL;
GO

-- Generate some log activity
:CONNECT LABDB02 -U sa -P 1994Acura#
USE [AdventureWorks]
GO
ALTER INDEX [PK_TransactionHistory_TransactionID] 
ON [Production].[TransactionHistory] REORGANIZE  WITH (LOB_COMPACTION = ON);
GO

-- Change database mirroring to synchronous mode 
:CONNECT LABDB02 -U sa -P 1994Acura#
ALTER DATABASE AdventureWorks SET SAFETY FULL;
GO

-- Check mirroring status (make sure we are synchronized)
:CONNECT LABDB02 -U sa -P 1994Acura#
SELECT @@SERVERNAME AS [Server Name], DB_NAME(Database_id) AS [Database Name], mirroring_role_desc, 
       mirroring_state_desc, mirroring_safety_level_desc, mirroring_partner_name, mirroring_witness_name,
	   mirroring_witness_state_desc, mirroring_failover_lsn, mirroring_connection_timeout
FROM sys.database_mirroring
WHERE mirroring_guid IS NOT NULL;
GO


-- Production fail over (one-time, one-way trip)
:CONNECT LABDB02 -U sa -P 1994Acura#
-- Initiate a manual failover of database (must do from Principal side)
USE master;
GO
ALTER DATABASE AdventureWorks SET PARTNER FAILOVER;

-- Connect to new server
:CONNECT LABDB01 -U sa -P 1994Acura#
USE AdventureWorks;
GO
-- See if we can access any data
SELECT Title, BirthDate
FROM HumanResources.Employee;