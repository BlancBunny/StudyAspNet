CREATE TABLE [dbo].[Contact] (
    [Idx]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (20)  NOT NULL,
    [Email]    VARCHAR (100)  NOT NULL,
    [Contents] NVARCHAR (MAX) NOT NULL,
    [RegDate]  DATETIME       CONSTRAINT [DF_Contacts_RegDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED ([Idx] ASC)
);

