USE Premier_Service_Solutions
GO

/****** Object:  Table [dbo].[tblCustomerContract]    Script Date: 2021/03/18 08:54:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE tblCustomerContract(
	CustomerContractID int PRIMARY KEY NOT NULL,
	BusinessID int FOREIGN KEY REFRENCES tblBusiness(BusinessID)  NOT NULL,
	ClientID int FOREIGN KEY REFRENCES tblClient(ClientID) NOT NULL,
	ContractID int FOREIGN KEY REFRENCES tblContract(ContractID) NOT NULL,
	CustomerContractStatus varchar(50) NOT NULL,
	StartDate date NOT NULL,
	EndDate nchar(10) NOT NULL,
)
	
        
