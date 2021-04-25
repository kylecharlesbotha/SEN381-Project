using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.Presentation_Access_Layer;
using PremierServiceSolutions.Data_Access_Layer;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class User : IComparable<User>
    {
        UserDH objUserDH = new UserDH();
        DBHandler objHandler = new DBHandler();

        private int userID;
        private Employee employeeObject;
        private int employeeID;
        private string userName;
        private string userPassword;
        private int userAccessLevel;
        private int userState;
        private string userAuthToken;
        private string userSalt;



        public User(int userID, Employee employeeObject, string userName, string userPassword, int userAccessLevel, int userState, string userAuthToken)
        {
            this.userID = userID;
            this.employeeObject = employeeObject;
            this.userName = userName;
            this.userPassword = userPassword;
            this.userAccessLevel = userAccessLevel;
            this.userState = userState;
            this.userAuthToken = userAuthToken;
        }
        public User(int userID, int employeeID, int userAccessLevel, string userAuthToken, string userName, string userPassword, int userState, string userSalt)
        {
            this.userID = userID;
            this.employeeID = employeeID;
            this.userName = userName;
            this.userPassword = userPassword;
            this.userAccessLevel = userAccessLevel;
            this.userState = userState;
            this.userAuthToken = userAuthToken;
            this.userSalt = userSalt;
        }

        public User()
        {
        }

        public int UserID { get => userID; set => userID = value; }
        internal Employee EmployeeObject { get => employeeObject; set => employeeObject = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public int UserAccessLevel { get => userAccessLevel; set => userAccessLevel = value; }
        public int UserState { get => userState; set => userState = value; }
        public string UserAuthToken { get => userAuthToken; set => userAuthToken = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string UserSalt { get => userSalt; set => userSalt = value; }

        public int CompareTo(User other)
        {
            throw new NotImplementedException();
        }

        public User(string userName, string userPassword)
        {
            try
            {
                this.userName = userName;
                this.userPassword = userPassword;
                if (UserName.All(Char.IsLetter))
                {
                    login(userName, userPassword);
                }
                else
                {
                    MessageBox.Show("Username may only contain letters");
                }
            }catch
            {

            }
        }

        public void login(string username, string password)
        {
            try
            {
                if (!checkFieldsEmpty())
                {
                    attemptLogin(username, password);
                }
            }
            catch
            {

            }
        }

        public bool checkFieldsEmpty()
        {
            try
            {
                if (String.IsNullOrEmpty(this.userName))
                {
                    MessageBox.Show("Please do not leave the username field blank.");
                    return true;
                }
                else if (String.IsNullOrEmpty(this.userPassword))
                {
                    MessageBox.Show("Please do not leave the password field blank.");
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public void CreateUser(User objUser)
        {
            try
            {
                objUserDH.Create(objUser);
            }
            catch
            {

            }
           
        }

        public String CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public String CreateSHA256Hash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sha256hashstring = new SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToStrng(hash);
        }

        private static string ByteArrayToStrng(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        public bool attemptLogin(string username, string password)
        {
            User objUser = new User();
            try
            {
                objUser = objUserDH.GetByUserName(username);
                string UrName = objUser.UserName;
                string UrPass = objUser.UserPassword;
                string Ursalt = objUser.UserSalt;

                //pass username and ursalt into createsha256hash method

                string hashpass = CreateSHA256Hash(password, Ursalt);

                //check return string equals urpass if it matches log user in else display error msg

                if(hashpass == UrPass) //log user in
                {
                    frmLoginScreen FLS = new frmLoginScreen();
                    FLS.Hide();
                    frmDashBoard FDB = new frmDashBoard();
                    FDB.Show();
                }
                else //display error msg
                {
                    MessageBox.Show("An Error has Occured");
                }

                

            }
            catch (SqlException SQLE)
            {
                //Will catch any errors that occur and will display a error message. it will also return a empty list
                MessageBox.Show("Error has occured");
            }
            return true;
        }

        public void GenerateAuthToken()
        {

        }
        public void ValidateAuthToken(string Token)
        {

        }

        public List<User> GetAllUsers()
        {
            try
            {
                List<User> AllUsers = new List<User>();
                AllUsers = objUserDH.GetAll().ToList();
                return AllUsers;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
