USE [Premier_Service_Solutions]
CREATE TABLE [dbo].[tblEmployee](
	EmployeeID INT IDENTITY(1,1) NOT NULL, 
	EmployeeName VARCHAR(30) NOT NULL,
	EmployeeSurname VARCHAR(30) NOT NULL, 
	EmployeeIDNumber VARCHAR(15) PRIMARY KEY NOT NULL, 
	EmployeeCell VARCHAR(15) NOT NULL, 
	EmployeeGender VARCHAR(10) NOT NULL, 
	EmployeeRole VARCHAR(30) NOT NULL, 
	EmployeeStartDate DATE NOT NULL,
	EmployeeStatus VARCHAR(20) NOT NULL
)