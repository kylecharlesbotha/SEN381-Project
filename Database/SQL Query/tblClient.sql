USE [Premier_Service_Solutions]

CREATE TABLE dbo.tblClient
(
ClientIDNumber int PRIMARY KEY NOT NULL,
[ClientID] int IDENTITY(1,1) NOT NULL,
[ClientName] VARCHAR(50) NOT NULL,  
[ClientSurname] VARCHAR(50) NOT NULL,  
[ClientTitle] VARCHAR(10) NOT NULL,  
[ClientGender] VARCHAR(6) NOT NULL,  
[ClientAddress] VARCHAR(200) NOT NULL,  
[ClientCell] VARCHAR(13) NOT NULL,  
[ClientCreationDate] DATE NOT NULL,  
[ClientEmail] VARCHAR(100) NOT NULL,  
[ClientPriority] VARCHAR(20) NOT NULL, 
[ClientState] VARCHAR(10) NOT NULL
)
GO
