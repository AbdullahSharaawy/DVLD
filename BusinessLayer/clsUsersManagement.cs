using BusinessLayer;
using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static DataBaseLayer.clsPeople;

namespace PresentationLayer
{
    public class clsUser
    {
        public string _UserName { get; set; }
        public string _Password { get; set; }
        public int _UserID { get; set; }
        public int _PersonID { get; set; }
        public int _IsActive { get; set; }

        public clsUser()
        {
            _UserName = "";
            _Password = "";
            _IsActive = 0;
            _UserID = -1;
            _PersonID = -1;

        }
        public clsUser(string userName, string password, int userID, int personID, int isActive)
        {
            _UserName = userName;
            _Password = password;
            _UserID = userID;
            _PersonID = personID;
            _IsActive = isActive;
        }
    }
    public class clsUsersManagement : clsPersonManagement
    {
       //public enum enMode { AddNew, Update};
        //public enMode Mode = enMode.AddNew;
        public clsUser user;
        public  void SelectMode(enMode _Mode)
        {
            Mode = _Mode;
        }
        public clsUsersManagement()
        {
            user = new clsUser();
            Mode = enMode.AddNew;

        }
        private clsUsersManagement(int UserID,int PersonID ,string UserName ,string Password,int IsActive )
        {
                user=new clsUser( UserName, Password,  UserID,  PersonID,  IsActive);
                Mode = enMode.AddNew;
        }

        public override void add()
        {
            this.user._UserID =clsUsers.AddNewUser(this.user._PersonID, this.user._UserName, this.user._Password, this.user._IsActive);
        }
        public override bool update()
        {
            return clsUsers.UpdateUserData(this.user._UserID, this.user._UserName, this.user._Password, this.user._IsActive);
        }
        public override clsPersonManagement find(int UserID)
        {
            int  PersonID=-1 ,IsActive=0;
            string _UserName="" ,Password="";
            
            if(UserID==-1)// to find using user name
                _UserName=user._UserName;
            
            if( clsUsers.GetContactInfoByID(ref UserID,ref PersonID,ref _UserName, ref Password, ref IsActive))
            {
                return new clsUsersManagement(UserID,PersonID, _UserName, Password, IsActive);
            }else 
                return null;
        }
       
        private static string GetQuery(string ColumnName, string value1,string value2="")
        {
            switch (ColumnName)
            {
                case "UserName":
                    return $"SELECT Found=1 FROM Users WHERE UserName ='{value1}'";
                case "Password":
                    return $"SELECT Found=1 FROM Users WHERE Password ='{value1}'";
                case "IsActive":
                    return $"SELECT Found=1 FROM DVLD.dbo.Users WHERE IsActive = 1 and UserName='{value1}'";
                case "PersonID":
                    return $"SELECT Found=1 FROM Users WHERE PersonID = {value1}";
                case "LogIn":
                    return $"SELECT Found=1 FROM DVLD.dbo.Users WHERE Password='{value2}' and UserName='{value1}'";
            }
            return "";
        }
        public static bool IsValidPassword( string Password)
        {
            return (clsUsers.IsValid_LogInData(GetQuery,"Password",Password) );
        }
        public static bool IsValidUserName(string UserName)
        {
            return (clsUsers.IsValid_LogInData(GetQuery,"UserName",UserName));
        }

        public static bool IsValidLogIn(string UserName,string Password)
        {
            return (clsUsers.IsValid_LogInData(GetQuery, "LogIn", UserName,Password));
        }

        public static bool IsActiveUser(string UserName)
        {
            return (clsUsers.IsValid_LogInData(GetQuery, "IsActive",UserName));
        }
        public override DataTable GetAll(string TypeFilter = "", string Selector = "")
        {
            if (TypeFilter == "" && Selector == "")
            {
                return clsPeople.GetAllContacts(clsGlobalMethods.Filter, "All Users", Selector);
            }
            else return clsPeople.GetAllContacts(clsGlobalMethods.Filter, TypeFilter, Selector);
        }
        public override void save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    add();
                    
                    break;
                case enMode.Update:
                    update();
                    break;
            }
        }
        public override bool delete(int UserID)
        {
            return clsUsers.DeleteContact(clsGlobalMethods.Filter,"Delete User",UserID.ToString());
        }
    }
}
