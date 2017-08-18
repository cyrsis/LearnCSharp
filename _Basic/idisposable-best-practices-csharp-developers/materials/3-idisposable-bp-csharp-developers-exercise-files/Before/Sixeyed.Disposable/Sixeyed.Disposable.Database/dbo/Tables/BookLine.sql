
CREATE TABLE [dbo].[BookLine] (
    [Id]                     INT            IDENTITY (1, 1) NOT NULL,
    [BookFeedId]                  INT NOT NULL,
    [LineNumber]              INT            NOT NULL,
    [WordCount]              INT            NOT NULL,
    [Excerpt]                   NVARCHAR (255) NULL,
    
	CONSTRAINT [PK_BookLine] PRIMARY KEY CLUSTERED ([Id] ASC),

	CONSTRAINT [FK_BookLine_BookFeed] FOREIGN KEY ([BookFeedId]) REFERENCES [BookFeed]([Id])
);

