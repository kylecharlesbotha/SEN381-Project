USE [Premier_Service_Solutions]

CREATE TABLE dbo.tblBusiness(
	BusinessID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	BusinessAddress varchar(255) NOT NULL,
	BusinessName varchar(50) NOT NULL,
	BusinessPhone varchar(13) NOT NULL,
	BusinessRegistrationNumber int  NOT NULL,
	BusinessState varchar(20) NOT NULL,

)
