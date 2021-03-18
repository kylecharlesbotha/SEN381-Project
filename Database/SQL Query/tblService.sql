USE [Premier_Service_Solutions]

CREATE TABLE dbo.tblService
(
ServiceID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
[ServiceDescription] VARCHAR(250) NOT NULL,
[ServiceLevel] VARCHAR(100) NOT NULL,
[ServiceName] VARCHAR(100) NOT NULL
)
GO
