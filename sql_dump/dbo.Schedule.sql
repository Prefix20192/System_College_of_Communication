CREATE TABLE [dbo].[schedule]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [g_name] NVARCHAR(50) NOT NULL, 
    [predmet] NVARCHAR(50) NOT NULL, 
    [auditori] NVARCHAR(50) NOT NULL, 
    [time_work] INT NULL, 
    [prepod] NVARCHAR(50) NULL
)
