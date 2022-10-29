USE Tournaments;
GO
-- Truncate the log by changing the database recovery model to SIMPLE.
ALTER DATABASE Tournaments
SET RECOVERY SIMPLE;
GO
-- Shrink the truncated log file to 1 MB.
DBCC SHRINKFILE (Tournaments_Log, 1);
GO
-- Reset the database recovery model.
ALTER DATABASE Tournaments
SET RECOVERY FULL;
GO