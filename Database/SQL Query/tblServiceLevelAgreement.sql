USE [Premier_Service_Solutions]
CREATE TABLE [dbo].[tblServiceLevelAgreement](
	SLAID INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	TechnicianLevel VARCHAR(20) NOT NULL,
	TechnicianStatus VARCHAR(20) NOT NULL,  
)

