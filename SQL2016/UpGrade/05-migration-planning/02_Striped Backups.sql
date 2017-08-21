-- Using Striped Backups
-- Glenn Berry
-- SQLskills.com

-- Full database backup to check read throughput from data and log files 
BACKUP DATABASE [AdventureWorks2014] TO  DISK = 'NUL:' WITH STATS = 1;
-- BACKUP DATABASE successfully processed 949114 pages in 17.377 seconds (426.710 MB/sec). 


-- Full database backup using backup compression
BACKUP DATABASE [AdventureWorks2014] 
TO  DISK = N'T:\SQLBackups\AdventureWorks2014FullCompressed.bak' WITH NOFORMAT, INIT,  
NAME = N'AdventureWorks2014-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, COMPRESSION,  STATS = 1, CHECKSUM;
GO
-- BACKUP DATABASE successfully processed 949114 pages in 21.511 seconds (344.704 MB/sec).


-- Full striped database backup to two files using backup compression
BACKUP DATABASE [AdventureWorks2014] 
TO  DISK = N'T:\SQLBackups\AdventureWorks2014FullStripedA.bak',  
DISK = N'L:\SQLBackups\AdventureWorks2014FullStripedB.bak' WITH NOFORMAT, INIT,  
NAME = N'AdventureWorks2014-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, COMPRESSION,  STATS = 1, CHECKSUM;
GO
-- BACKUP DATABASE successfully processed 949114 pages in 17.528 seconds (423.034 MB/sec).



-- Look at recent Full backups for the current database 
SELECT TOP (30) bs.machine_name, bs.server_name, bs.database_name AS [Database Name], bs.recovery_model,
CONVERT (BIGINT, bs.backup_size / 1048576 ) AS [Uncompressed Backup Size (MB)],
CONVERT (BIGINT, bs.compressed_backup_size / 1048576 ) AS [Compressed Backup Size (MB)],
CONVERT (NUMERIC (20,2), (CONVERT (FLOAT, bs.backup_size) /
CONVERT (FLOAT, bs.compressed_backup_size))) AS [Compression Ratio], bs.has_backup_checksums, 
bs.is_copy_only, bs.encryptor_type,
DATEDIFF (SECOND, bs.backup_start_date, bs.backup_finish_date) AS [Backup Elapsed Time (sec)],
bs.backup_finish_date AS [Backup Finish Date], bmf.physical_device_name AS [Backup Location], 
bmf.physical_block_size
FROM msdb.dbo.backupset AS bs WITH (NOLOCK)
INNER JOIN msdb.dbo.backupmediafamily AS bmf WITH (NOLOCK)
ON bs.media_set_id = bmf.media_set_id  
WHERE bs.database_name = DB_NAME(DB_ID())
AND bs.[type] = 'D' -- Change to L if you want Log backups
ORDER BY bs.backup_finish_date DESC OPTION (RECOMPILE);
