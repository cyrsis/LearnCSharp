-- Using Backup Compression
-- Glenn Berry
-- SQLskills.com

-- Full database backup without using backup compression
BACKUP DATABASE [AdventureWorks2014] 
TO  DISK = N'T:\SQLBackups\AdventureWorks2014FullNonCompressed.bak' WITH NOFORMAT, INIT,  
NAME = N'AdventureWorks2014-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, NO_COMPRESSION,  STATS = 1, CHECKSUM;
GO
-- BACKUP DATABASE successfully processed 949114 pages in 47.397 seconds (156.443 MB/sec).


-- Full database backup using backup compression
BACKUP DATABASE [AdventureWorks2014] 
TO  DISK = N'T:\SQLBackups\AdventureWorks2014FullCompressed.bak' WITH NOFORMAT, INIT,  
NAME = N'AdventureWorks2014-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, COMPRESSION,  STATS = 1, CHECKSUM;
GO
-- BACKUP DATABASE successfully processed 949114 pages in 27.288 seconds (271.729 MB/sec).

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
