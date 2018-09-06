CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Header] NVARCHAR(150) NULL, 
    [ItemName] NVARCHAR(500) NULL, 
    [DeadLine] DATETIME NULL, 
    [CreatedDate] DATETIME NULL
)
