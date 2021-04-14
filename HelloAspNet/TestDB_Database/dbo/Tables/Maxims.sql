CREATE TABLE [dbo].[Maxims] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (12) NULL,
    [Contents] NVARCHAR (30) NULL,
    [RegDate]  DATE          NULL,
    CONSTRAINT [PK_Maxims] PRIMARY KEY CLUSTERED ([Id] ASC)
);

