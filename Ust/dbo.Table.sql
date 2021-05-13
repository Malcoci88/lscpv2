CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nume] NVARCHAR(50) NOT NULL, 
    [Prenume] NVARCHAR(50) NOT NULL, 
    [Facultatea] CHAR(10) NOT NULL, 
    [Ciclu] NCHAR(10) NOT NULL, 
    [Specialitatea] NVARCHAR(50) NOT NULL, 
    [Nota medie] FLOAT NOT NULL
)
