using DataBaseLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsPerson
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int PersonID { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Gendor { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalNo { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public clsPerson() 
        {
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            Address = "";
            ImagePath = "";
            PersonID = -1;
            DateOfBirth = new DateTime();

            Gendor = 0;
            NationalityCountryID = -1;
            NationalNo = "";
        }
        public clsPerson(string _FirstName, string _SecondName, string _ThirdName, string _LastName, string _NationalNo, string _Address, string _Email, string _Phone, DateTime _DateOFBirth, int _Gendor, int _NationalityCountryID, int _PersonID, string _ImagePath)
        {
            FirstName = _FirstName;
            SecondName = _SecondName;
            PersonID = _PersonID;
            ThirdName = _ThirdName;
            LastName = _LastName;
            Address = _Address;
            Phone = _Phone;
            Email = _Email;
            Gendor = _Gendor;
            DateOfBirth = _DateOFBirth;
            NationalNo = _NationalNo;
            NationalityCountryID = _NationalityCountryID;
            ImagePath = _ImagePath;
        }
    }
    public class clsPeopleManagement:clsPersonManagement
    {
        //public enum enMode { Update = 0, AddNew = 1 };
       // public static enMode Mode = enMode.AddNew;
        public clsPerson person;
        public clsPeopleManagement()
        {
            person = new clsPerson();
        }
        private  clsPeopleManagement(string _FirstName, string _SecondName,string _ThirdName,string _LastName,string _NationalNo,string _Address,string _Email,string _Phone,DateTime _DateOFBirth,int _Gendor,int _NationalityCountryID,int _PersonID,string _ImagePath)
        {
            person = new clsPerson(_FirstName,_SecondName,_ThirdName,_LastName,_NationalNo,_Address,_Email, _Phone,_DateOFBirth,_Gendor, _NationalityCountryID, _PersonID, _ImagePath); 
        }

        // the previous variables to fill all text boxes when user click on update for specific record


        //public string FirstName { get; set; }
        //public string SecondName { get; set; }
        //public int PersonID { get; set; }
        //public string ThirdName { get; set; }
        //public string LastName { get; set; }
        //public string Address { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
        //public int Gendor { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public string NationalNo { get; set; }
        //public int NationalityCountryID { get; set; }
        //public string ImagePath { get; set; }

        //internal static string Filter(string TypeFilter,string Selector )
        //{
        //    switch(TypeFilter)
        //    {
        //        case "Person ID":
        //            return $"select * from People where PersonID= '{Selector}' ";
        //        case "National No":
        //            return $"select * from People where NationalNo= '{Selector}' " ;
        //        case "First Name":
        //            return $"select * from People where FirstName= '{Selector}' ";
        //        case "Second Name":
        //            return $"select * from People where SecondName= '{Selector}' ";
        //        case "Third Name":
        //            return $"select * from People where ThirdName= '{Selector}' ";
        //        case "Last Name":
        //            return $"select * from People where LastName= '{Selector}' ";
        //        case "Phone":
        //            return $"select * from People where Phone= '{Selector}' ";
        //        case "Email":
        //            return $"select * from People where Email= '{Selector}' ";
        //         case "Gendor":
        //            return $"select * from People where Gendor= '{Selector}' ";
        //        case "Nationality":
        //            return $"select * from People where NationalCountryID= '{Selector}' ";

        //        case "All People":
        //            return "select * from People ";
        //        case "":
        //            return "select * from People ";
        //        case "Person ID ":
        //            return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where Users.PersonID= '{Selector}' ";
        //        case "All Users":
        //            return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID ";
        //        case "User ID":
        //            return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where Users.UserID= '{Selector}' ";
        //        case "Full Name":// Users table inner join People table          
        //            return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where FirstName+' '+SecondName+' '+ThirdName+' '+LastName= '{Selector}' ";
        //        case "Full Name ":// People table only
        //            return $"select * from People where FirstName+' '+SecondName+' '+ThirdName+' '+LastName= '{Selector}' ";

        //        case "UserName":           
        //            return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where Users.UserName= '{Selector}' ";
        //        case "Is Active":          
        //            return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where Users.IsActive= '{Selector}' ";


        //    }
        //    return "";
        //}
        public   override  DataTable GetAll(string TypeFilter="" , string Selector = "" )
        {
            return clsPeople.GetAllContacts(clsGlobalMethods.Filter,TypeFilter,Selector);
        }

        //public static int GetCountPeople()
        //{
        //    return clsDataBase.CountPeopleRecords();
        //}
        public static int GetCountryID(string CountryName)
        {
            return clsCountry.GetCountryIDUsingCountryName(CountryName);
        }
        public static string GetCountryName(int CountryID)
        {
            return clsCountry.GetCountryNameUsingCountryID(CountryID);
        }
        public static DataTable GetAllCountriesName()
        {
            return clsCountry.GetAllContacts(clsGlobalMethods.Filter, "All Countries", "");
        }
        public override bool delete(int PersonID)
        {
            return clsPeople.DeleteContact(clsGlobalMethods.Filter, "Delete Person",PersonID.ToString());
        }
        public override void add()
        {
            person.PersonID =clsPeople.AddNewContact(person.FirstName, person.LastName,person.SecondName,person.ThirdName,person.Gendor,person.NationalNo,person.Email,person.Phone,person.Address, person.DateOfBirth, person.NationalityCountryID, person.ImagePath);
        }
         
        public override void  save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    add();
                    break;
            }
        }
        public override  bool update( )
        {
            return clsPeople.UpdatePersonData(this.person.PersonID,this.person.NationalNo,this.person.FirstName,this.person.SecondName,this.person.ThirdName,this.person.LastName,this.person.DateOfBirth,this.person.Gendor,this.person.Address,this.person.Phone, this.person.Email,this.person.NationalityCountryID, this.person.ImagePath);
        }
        public override clsPersonManagement find(int PersonID)
        {
            string _FirstName = "", _SecondName = "", _ThirdName = "", _LastName = "", _Phone = "", _Address = "", _NationalNo = "", _Email = "", _ImagePath = "";
            int _NationalityCountryID = -1, _Gendor = 0;
            DateTime _DateOfBirth = new DateTime();

            if (clsPeople.GetContactInfoByID(PersonID, ref _NationalNo, ref _FirstName, ref _SecondName, ref _ThirdName, ref _LastName, ref _DateOfBirth, ref _Gendor, ref _Address, ref _Phone, ref _Email, ref _NationalityCountryID, ref _ImagePath))
            {
                return new clsPeopleManagement(_FirstName, _SecondName, _ThirdName, _LastName, _NationalNo, _Address, _Email, _Phone, _DateOfBirth, _Gendor, _NationalityCountryID, PersonID, _ImagePath);
            }
            else return null;
        }    
}
}
