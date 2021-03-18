USE Premier_Service_Solutions

CREATE TABLE dbo.tblPackage(
	ContractID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ServiceID int NOT NULL,
	SLAID int NOT NULL
)
