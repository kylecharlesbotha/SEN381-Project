USE [Premier_Service_Solutions]

CREATE TABLE dbo.tblTicket(
	TicketID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TechnicianID int NOT NULL,
	ClientID int NOT NULL,
	TicketDescription varchar(255) NOT NULL,
	TicketDueDate date NOT NULL,
	EmployeeID int NOT NULL,
	TicketIssueType varchar(20) NOT NULL,
	TicketLastUpdated date NOT NULL,
	TicketLoggedTime time(7) NOT NULL,
	TicketPrority varchar(20) NOT NULL,
	TicketStatus varchar(20) NOT NULL,
	TicketTitle varchar(20) NOT NULL,
)
