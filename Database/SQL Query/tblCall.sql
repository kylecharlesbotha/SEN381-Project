USE Premier_Service_Solutions

CREATE TABLE dbo.tblCall(
	CallID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ClientID int NOT NULL,
	EmployeeID int NOT NULL,
	CallStartTime datetime NOT NULL,
	CallEndTime datetime NOT NULL,
	CallState varchar(15) NOT NULL,
	TicketID int NOT NULL,
	CallRecording varchar(50) NOT NULL
	)
