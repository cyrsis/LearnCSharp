-- Migrating with Log Shipping
-- Glenn Berry
-- SQLskills.com

-- LABDB02 is legacy instance, running SQL Server 2012
-- LABDB01 is new instance, running SQL Server 2016

-- Must enable SQLCMD mode from Query menu

-- Editing SQLCMD Scripts in the Transact-SQL Editor
-- http://bit.ly/2sLW21J

-- Connect to legacy instance, using SQL Server authentication
:CONNECT LABDB02 -U sa -P 1994Acura#
-- Check version, edition, and build number on Principal instance
SELECT @@SERVERNAME AS [Server Name], @@VERSION AS [SQL Server and OS Version Info];

:CONNECT LABDB02 -U sa -P 1994Acura#
-- Run log shipping transaction log backup job
EXEC msdb.dbo.sp_start_job N'LSBackup_AdventureWorks';
GO

:CONNECT LABDB02 -U sa -P 1994Acura#
-- Check log shipping monitor on primary (legacy instance)
EXEC master.dbo.sp_help_log_shipping_monitor;


-- Switch to secondary(new) server/instance ********************************************

-- Connect to new instance, using SQL Server authentication
:CONNECT LABDB01 -U sa -P 1994Acura#
-- Check version, edition, and build number on Principal instance
SELECT @@SERVERNAME AS [Server Name], @@VERSION AS [SQL Server and OS Version Info];

:CONNECT LABDB01 -U sa -P 1994Acura#
-- Run log shipping log backup file copy job
EXEC msdb.dbo.sp_start_job N'LSCopy_LABDB02_AdventureWorks';
GO

:CONNECT LABDB01 -U sa -P 1994Acura#
-- Run log shipping transaction log restore job
EXEC msdb.dbo.sp_start_job N'LSRestore_LABDB02_AdventureWorks';
GO

:CONNECT LABDB01 -U sa -P 1994Acura#
-- Check log shipping monitor on secondary (new instance)
EXEC master.dbo.sp_help_log_shipping_monitor;
GO

:CONNECT LABDB01 -U sa -P 1994Acura#
-- Check history for most recent LSRestore job runs
SELECT TOP (20) h.server, j.name AS [JobName], msdb.dbo.agent_datetime(run_date, run_time) AS [RunDateTime], 
       h.run_status, h.step_name
FROM msdb.dbo.sysjobs AS j 
INNER JOIN msdb.dbo.sysjobhistory AS h 
ON j.job_id = h.job_id 
WHERE j.name = N'LSRestore_LABDB02_AdventureWorks'
AND h.step_name = N'(Job outcome)' 
ORDER BY JobName, RunDateTime DESC;


-- Recover database on new instance
:CONNECT LABDB01 -U sa -P 1994Acura#
RESTORE DATABASE AdventureWorks WITH RECOVERY;

