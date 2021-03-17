USE [Premier_Service_Solutions]

CREATE TABLE dbo.tblContract(
	ContractID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ContractDescription varchar(255) NOT NULL,
	ContractType varchar(20) NOT NULL,

)
