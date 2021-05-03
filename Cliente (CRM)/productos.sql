CREATE TABLE [dbo].[Productos]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [producto] VARCHAR(50) NOT NULL, 
    [cantidad] INT NOT NULL, 
    [precio] MONEY NOT NULL
)
