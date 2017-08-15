USE [ReactiveTickets]
GO


CREATE TABLE [dbo].[Timestamp](
	[LastModified] [datetime] NULL,
	[ID] [int] NOT NULL,

CONSTRAINT [PK_Timestamp] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
) ON [PRIMARY]

GO

INSERT INTO [dbo].[Timestamp]
(
	ID, LastModified
)
	VALUES (1, GETDATE())