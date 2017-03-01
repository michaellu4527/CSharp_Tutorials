CREATE TABLE [dbo].[Customers]
(
	[CustomerId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [State] VARCHAR(50) NOT NULL, 
    [PostalCode] VARCHAR(50) NOT NULL, 
    [Notes] VARCHAR(MAX) NULL
)
