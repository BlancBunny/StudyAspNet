CREATE TABLE [dbo].[Manages] (
    [Idx]      INT            IDENTITY (1, 1) NOT NULL,
    [Cate]     VARCHAR (10)   NOT NULL,
    [Subject]  NVARCHAR (200) NOT NULL,
    [Contents] NVARCHAR (MAX) NOT NULL,
    [RegDate]  DATETIME2 (7)  CONSTRAINT [DF_Pages_RegDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Pages] PRIMARY KEY CLUSTERED ([Idx] ASC)
);

