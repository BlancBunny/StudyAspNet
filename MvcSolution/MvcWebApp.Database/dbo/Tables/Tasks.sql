CREATE TABLE [dbo].[Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[Title] nvarchar(150) NOT NULL,
	[IsDone] bit NULL,
	[CreationDate] datetime NULL DEFAULT (GetDate())
)
