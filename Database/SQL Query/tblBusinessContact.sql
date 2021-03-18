USE Premier_Service_Solution
GO


CREATE TABLE dbo.tblBusinessContact(
	BusinessID int PRIMARY KEY NOT NULL,
	ClientID int FOREIGN KEY REFRENCES tblClient(ClientID) NOT NULL,
	ContactJobTitle varchar(50) NOT NULL,
	ContactState varchar(50) NOT NULL

)
