
CREATE TABLE [dbo].[BookFeed] (
    [Id]                     INT            IDENTITY (1, 1) NOT NULL,
    [Path]                   NVARCHAR (512) NOT NULL,
    [LineCount]              INT            NOT NULL,
    [WordCount]              INT            NOT NULL,
    [Name]                   NVARCHAR (255) NULL,
    [ProcessingMilliseconds] BIGINT         NULL,
    
	CONSTRAINT [PK_BookFeed] PRIMARY KEY CLUSTERED ([Id] ASC)
);

