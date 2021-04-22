CREATE TABLE [dbo].[Board] (
    [Idx]       INT            IDENTITY (1, 1) NOT NULL,
    [Subject]   NVARCHAR (200) NOT NULL,
    [Contents]  NVARCHAR (MAX) NULL,
    [Writer]    NVARCHAR (20)  NOT NULL,
    [RegDate]   DATETIME2 (7)  CONSTRAINT [DF_Board_RegDate] DEFAULT (getdate()) NULL,
    [ReadCount] INT            NULL,
    CONSTRAINT [PK_Board] PRIMARY KEY CLUSTERED ([Idx] ASC)
);

