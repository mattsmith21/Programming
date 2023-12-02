CREATE TABLE [dbo].[tblContacts] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [LastName]  VARCHAR (25) NULL,
    [FirstName] VARCHAR (25) NULL,
    [Email]     VARCHAR (50) NULL,
    [Street]    VARCHAR (50) NULL, 
    [City]      VARCHAR (50) NULL, 
    [State]     VARCHAR (50) NULL, 
    [Zip]       VARCHAR (50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

