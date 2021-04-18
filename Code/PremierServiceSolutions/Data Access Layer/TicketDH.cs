﻿using PremierServiceSolutions.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Data_Access_Layer
{
    class TicketDH
    {
        //Object of DBHandler which will store the connection string. We do this so that 
        //we dont have to repeat code in multiple classes but instead just one
        DBHandler objHandler = new DBHandler();

        //Method which will be used to create new record
        private bool CreateTicket(Ticket objTic)
        {
            try
            {
                //First Check if the record already exsists by calling  FindTicket()
                int TicketVal = FindTicket(objTic);
                if (TicketVal == 1)
                {
                    //If found return false and display a message that it already exists else continue with creating
                    MessageBox.Show("Ticket Already Exists");
                    return false;
                }
                else if (TicketVal == 0)
                {
                    //Then you will need to check if the Records Exist
                    {
                        SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        string InsertQuery = string.Format(@"INSERT INTO tblTicket (TechnicianID, ClientID, TicketDescription, TicketDueDate, EmployeeID, TicketIssueType, TicketLastUpdated, TicketLoggedTime, TicketPrority, TicketStatus, TicketTitle) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", objTic.TechnicianID, objTic.TicketDescription, objTic.TicketDueDate, objTic.EmployeeID, objTic.TicketIssueType, objTic.TicketLastUpdated, objTic.TicketLoggedTime, objTic.TicketPriority, objTic.TicketStatus, objTic.TicketTitle);
                        SqlCommand InsertCommand = new SqlCommand(InsertQuery, sqlCon);
                        sqlCon.Open();
                        InsertCommand.ExecuteNonQuery();
                        sqlCon.Close();
                        return true;
                    }
                }
                return false;
            }
            catch (SqlException SQLE)
            {
                return false;
            }

        }

        //Method which will be used to Update current record within Database
        private bool UpdateTicket(Ticket newObjTic, Ticket oldObjTic)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblTicket
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblTicket SET TechnicianID ='{0}',ClientID ='{1}',TicketDescription ='{2}',TicketDueDate ='{3}',EmployeeID ='{4}',TicketIssueType ='{5}',TicketLastUpdated ='{6}',TicketLoggedTime ='{7}',TicketPrority ='{8}',TicketStatus ='{9}',TicketTitle ='{10}' WHERE TicketID ='{11}'", newObjTic.TechnicianID, newObjTic.ClientID, newObjTic.TicketDescription, newObjTic.TicketDueDate, newObjTic.EmployeeID, newObjTic.TicketIssueType, newObjTic.TicketLastUpdated, newObjTic.TicketLoggedTime, newObjTic.TicketPriority, newObjTic.TicketStatus, newObjTic.TicketTitle, oldObjTic.TicketID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Perform the Update Query
                UpdateCommand.ExecuteNonQuery();
                //Close the connection to the database
                sqlCon.Close();
                //If it all works it will then return true to indicate update successful
                return true;
            }
            catch (SqlException SQLE)
            {
                //If any error has to occur during the try phase it will display a Error message and will return false to indicate it was unsuccessful
                MessageBox.Show("Error has occured please try again");
                return false;
            }
        }

        //Method used to Delete a record from the database
        private bool DeleteTicket(Ticket objTic)
        {
            try
            {
                //New SQL Connection which the query will use to perform the update of tblTicket to change the state of the record to indicate that it is deleted but we still keep it
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Update Query which will store the SQL Query to be used when the connection is open
                string UpdateQuery = string.Format(@"UPDATE tblTicket SET TicketState = 0 WHERE TicketID ='{0}'", objTic.TicketID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Perform the Update Query
                UpdateCommand.ExecuteNonQuery();
                //Close the connection to the database
                sqlCon.Close();
                //If it all works it will then return true to indicate update successful
                return true;
            }
            catch (SqlException SQLE)
            {
                //If any error has to occur during the try phase it will display a Error message and will return false to indicate it was unsuccessful
                MessageBox.Show("Error has occured please try again");
                return false;
            }
        }
        //Method used to Get all the records from the table in the database
        private List<Ticket> GetAllTicket(Ticket objTic)
        {
            
            try
            {
                //List of type Ticket which will store all the records and then return that list
                List<Ticket> allTic = new List<Ticket>();
                //New SQL Connection which the query will use to perform the Select of tblTicket
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Tickets
                string SelectQuery = "SELECT * FROM tblTicket";
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //SQL Datareader which will be used to pull specific fields from the Select Return statement
                SqlDataReader sqlDataReader;
                //Open the connection to the database
                sqlCon.Open();
                //
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    allTic.Add(new Ticket((int)sqlDataReader.GetValue(0), (int)sqlDataReader.GetValue(1), (int)sqlDataReader.GetValue(2), (string)sqlDataReader.GetValue(3), (DateTime)sqlDataReader.GetValue(4), (int)sqlDataReader.GetValue(5), (string)sqlDataReader.GetValue(6), (DateTime)sqlDataReader.GetValue(7), (DateTime)sqlDataReader.GetValue(8), (string)sqlDataReader.GetValue(9), (string)sqlDataReader.GetValue(10), (string)sqlDataReader.GetValue(11)));
                }
                //Close connection to database
                sqlCon.Close();
                //Return List of Ticket
                return allTic;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                return null;
            }
        }

        //Method used to find one record within the table
        private int FindTicket(Ticket objTic)
        {
            //Object of type Ticket which will store single record of object to be returned to interface
            int RecordCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblTicket
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Tickets
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblTicket WHERE TicketPriority = '{0}' AND TicketStatus = '{1}' AND EmployeeID = '{2}' AND ClientID = '{3}'", objTic.TicketPriority, objTic.TicketStatus, objTic.EmployeeID, objTic.ClientID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                RecordCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Tickets
                return RecordCount;
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
                RecordCount = -1;
                return RecordCount;
            }
        }

        //Method which will be called to check that neccessary fields exist in the other tables which have relationships
        private bool CheckAllTables(Ticket objTic)
        {
            int EmployeeCount;
            int TechnicianCount;
            int ClientCount;
            try
            {
                //New SQL Connection which the query will use to perform the Select of tblEmployee
                SqlConnection sqlCon = new SqlConnection(objHandler.ConnectionVal);
                //Select Query which will store the SQL qeury needed to return all the Employees
                string SelectQuery = string.Format("SELECT COUNT(*) FROM tblEmployee WHERE EmployeeID = '{0}'", objTic.TicketID);
                //New Command which will take in the sqlCon and UpdateQuery var
                SqlCommand sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                //Open the connection to the database
                sqlCon.Open();
                //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                EmployeeCount = (Int32)sqlCommand.ExecuteScalar();
                //Close connection to database
                sqlCon.Close();
                //Return Count of Employees
                if (EmployeeCount == 1)
                {
                    //New SQL Connection which the query will use to perform the Select of tblClient
                    sqlCon = new SqlConnection(objHandler.ConnectionVal);
                    //Select Query which will store the SQL qeury needed to return all the Clients
                    SelectQuery = string.Format("SELECT COUNT(*) FROM tblClient WHERE ClientID = '{0}'", objTic.ClientID);
                    //New Command which will take in the sqlCon and UpdateQuery var
                    sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                    //Open the connection to the database
                    sqlCon.Open();
                    //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                    ClientCount = (Int32)sqlCommand.ExecuteScalar();
                    //Close connection to database
                    sqlCon.Close();
                    //Return Count of Clients
                    if (ClientCount == 1)
                    {
                        //New SQL Connection which the query will use to perform the Select of tblTechnician
                        sqlCon = new SqlConnection(objHandler.ConnectionVal);
                        //Select Query which will store the SQL qeury needed to return all the Technicains
                        SelectQuery = string.Format("SELECT COUNT(*) FROM tblTechnician WHERE TechnicianID = '{0}'", objTic.TechnicianID);
                        //New Command which will take in the sqlCon and UpdateQuery var
                        sqlCommand = new SqlCommand(SelectQuery, sqlCon);
                        //Open the connection to the database
                        sqlCon.Open();
                        //Execute Scalar which will return the first columns value and ignore the rest. This will show if there is a person or not
                        TechnicianCount = (Int32)sqlCommand.ExecuteScalar();
                        //Close connection to database
                        sqlCon.Close();
                        //Return Count of Technicians
                        if (TechnicianCount == 1)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Technician not found, Try again");
                            return false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Client not found, Try again");
                        return false;

                    }

                }
                else
                {
                    MessageBox.Show("Employee not found, Try again");
                    return false;
                }
            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a false value
                MessageBox.Show("Error has occured");
                return false;
            }
        }
    }
}

