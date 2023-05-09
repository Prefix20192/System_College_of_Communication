CREATE TABLE [dbo].[Student_info]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [stud_id] INT NOT NULL, 
    [family_id] INT NOT NULL, 
    [birthday] DATE NOT NULL, 
    [phone] NVARCHAR(50) NOT NULL, 
    [pasport] INT NOT NULL, 
    [education] NCHAR(20) NOT NULL, 
    [address_in_stav] NVARCHAR(50) NOT NULL, 
    [propiska] NVARCHAR(50) NOT NULL, 
    [family_status] NCHAR(20) NOT NULL, 
    [Accounting_of_ODN] NCHAR(20) NOT NULL
)
