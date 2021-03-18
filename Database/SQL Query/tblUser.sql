USE Premier_Service_Solutions

CREATE TABLE dbo.tblUser(
	UserID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	EmployeeID int NOT NULL,
	UserAccessLevel int NOT NULL,
	UserAuthToken varchar(50) NOT NULL,
	UserName varchar(50) NOT NULL,
	UserPassword varchar(50) NOT NULL,
	UserState varchar(15) NOT NULL
)
