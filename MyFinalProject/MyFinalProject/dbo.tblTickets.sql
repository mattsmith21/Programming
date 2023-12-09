CREATE TABLE [dbo].[tblTickets] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
	[Subject]       VARCHAR (50) NULL,
    [Requester]     VARCHAR (50) NULL,
    [Assigned To]   VARCHAR (50) NULL,
    [Creation Date] VARCHAR (50) NULL,
    [Priority]      VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

