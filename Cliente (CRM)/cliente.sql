﻿CREATE TABLE [dbo].[cliente]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [rfc] VARCHAR(13) NOT NULL, 
    [correo] VARCHAR(50) NOT NULL
)
