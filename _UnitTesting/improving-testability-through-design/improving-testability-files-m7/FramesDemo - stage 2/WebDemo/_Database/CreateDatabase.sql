USE master
GO

IF NOT EXISTS (SELECT * FROM dbo.syslogins WHERE name='frameAdmin')
	CREATE LOGIN frameAdmin WITH PASSWORD = 'insecure'
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name='frames')
	CREATE DATABASE frames
GO

USE frames
GO

IF NOT EXISTS (SELECT * FROM dbo.sysusers WHERE name='frameAdmin') 
	CREATE USER frameAdmin FOR LOGIN frameAdmin
GO

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name='geometry')
	EXEC ('CREATE SCHEMA [geometry]')
GO

GRANT SELECT ON SCHEMA :: [geometry] TO [frameAdmin];

IF OBJECT_ID('[geometry].[Frames]') IS NULL
	CREATE TABLE [geometry].[Frames]
	(
		[FrameID] INT PRIMARY KEY IDENTITY,
		[Length] MONEY NOT NULL,
		[Width] MONEY NOT NULL
	)
GO

IF OBJECT_ID('[geometry].[Circles]') IS NULL
	CREATE TABLE [geometry].[Circles]
	  (
		  [CircleID] INT PRIMARY KEY IDENTITY,
		  [X] MONEY NOT NULL,
		  [Y] MONEY NOT NULL,
		  [Radius] MONEY NOT NULL,
		  [FrameID] INT NOT NULL,
		  CONSTRAINT [fk_CircleFrame] FOREIGN KEY ([FrameID])
		  REFERENCES [geometry].[Frames]([FrameID])
	  )
GO

IF NOT EXISTS (SELECT * FROM [geometry].[Frames])
	BEGIN

		INSERT INTO [geometry].[Frames] ([Length], [Width])
		VALUES (350, 410)
		
		DECLARE @frameId INT
		SET @frameId = @@IDENTITY

		INSERT INTO [geometry].[Circles] ([FrameID], [X], [Y], [Radius])
		SELECT @frameId, 182, 206, 42
		UNION
		SELECT @frameId, 116, 160, 27
		UNION
		SELECT @frameId, 187, 116, 31
		UNION
		SELECT @frameId, 242, 155, 27
		UNION
		SELECT @frameId, 240, 261, 27
		UNION
		SELECT @frameId, 126, 267, 27
		UNION
		SELECT @frameId, 93, 104, 22
		UNION
		SELECT @frameId, 268, 102, 22
		UNION
		SELECT @frameId, 252, 316, 22
		UNION
		SELECT @frameId, 96, 315, 22
		UNION
		SELECT @frameId, 101, 60, 14
		UNION
		SELECT @frameId, 252, 64, 14
		UNION
		SELECT @frameId, 245, 357, 14
		UNION
		SELECT @frameId, 66, 346, 14
	END
