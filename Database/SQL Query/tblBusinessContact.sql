USE Premier_Service_Solution
GO

/****** Object:  Table [dbo].[tblBusinessContact]    Script Date: 2021/03/18 09:03:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE tblBusinessContact(
	BusinessID int PRIMARY KEY NOT NULL,
	ClientID int FOREIGN KEY REFRENCES tblClient(ClientID) NOT NULL,
	ContactJobTitle varchar(50) NOT NULL,
	ContactState varchar(50) NOT NULL,

)
