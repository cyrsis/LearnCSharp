-- Instant File Initialization
-- Glenn Berry
-- SQLskills.com


-- Returns status of instant file initialization (SQL Server 2014 SP2 or later)
EXEC sys.xp_readerrorlog 0, 1, N'Database Instant File Initialization';


-- SQL Server Services information 
SELECT servicename, process_id, startup_type_desc, status_desc, 
last_startup_time, service_account
FROM sys.dm_server_services;