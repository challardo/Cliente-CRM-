CREATE TABLE [dbo].[Productos] (
    [Id]       INT          NOT NULL IDENTITY,
    [producto] VARCHAR (50) NULL,
    [cantidad] INT          NULL,
    [precio]   MONEY        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

