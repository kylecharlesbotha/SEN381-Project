using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Business_Logic_Layer
{
    class User : IComparable<User>
    {

        private int userID;
        private Employee employeeObject;
        private int employeeID;
        private string userName;
        private string userPassword;
        private string userAccessLevel;
        private string userState;
        private string userAuthToken;
        private string userSalt;



        public User(int userID, Employee employeeObject, string userName, string userPassword, string userAccessLevel, string userState, string userAuthToken)
        {
            this.userID = userID;
            this.employeeObject = employeeObject;
            this.userName = userName;
            this.userPassword = userPassword;
            this.userAccessLevel = userAccessLevel;
            this.userState = userState;
            this.userAuthToken = userAuthToken;
        }
        public User(int userID, int employeeID, string userAccessLevel, string userAuthToken, string userName, string userPassword, string userState, string userSalt)
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
        public string UserAccessLevel { get => userAccessLevel; set => userAccessLevel = value; }
        public string UserState { get => userState; set => userState = value; }
        public string UserAuthToken { get => userAuthToken; set => userAuthToken = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string UserSalt { get => userSalt; set => userSalt = value; }

        public int CompareTo(User other)
        {
            throw new NotImplementedException();
        }

        public void GenerateAuthToken()
        {

        }
        public void ValidateAuthToken(string Token)
        {

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
