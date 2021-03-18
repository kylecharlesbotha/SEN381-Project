USE [Premier_Service_Solutions]

CREATE TABLE dbo.tblSatisfaction
(
SatisfactionID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
[SatisfactionStatus] VARCHAR(50) NOT NULL,
[TicketID] int NOT NULL
)
GO
