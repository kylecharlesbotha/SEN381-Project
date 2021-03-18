USE Premier_Service_Solutions
GO

/****** Object:  Table [dbo].[tblSchedule]    Script Date: 2021/03/18 08:51:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE tblSchedule(
	ScheduleID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	ScheduleDate date NOT NULL,
	ScheduleStartTime time(7)NOT NULL,
	ScheduleEndTime time(7) NOT NULL,
	ScheduleStatus nchar(10) NOT NULL,
	TicketID int NOT NULL,
)
