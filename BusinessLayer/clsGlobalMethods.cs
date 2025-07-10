using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;
namespace PresentationLayer
{
    public static class clsGlobalMethods
    {
        public static string Filter(string TypeFilter, string Selector1,string Selector2)
        {
            switch (TypeFilter)
            {
                case "Person ID":
                    return $"select * from People where PersonID= '{Selector1}' ";
                case "National Number":
                    return $"select * from People where NationalNo= '{Selector1}' ";
                case "National No":
                    return $"select * from People where NationalNo= '{Selector1}' ";
                case "First Name":
                    return $"select * from People where FirstName= '{Selector1}' ";
                case "Second Name":
                    return $"select * from People where SecondName= '{Selector1}' ";
                case "Third Name":
                    return $"select * from People where ThirdName= '{Selector1}' ";
                case "Last Name":
                    return $"select * from People where LastName= '{Selector1}' ";
                case "Phone":
                    return $"select * from People where Phone= '{Selector1}' ";
                case "Email":
                    return $"select * from People where Email= '{Selector1}' ";
                case "Gendor":
                    return $"select * from People where Gendor= '{Selector1}' ";
                case "Nationality":
                    return $"select * from People where NationalCountryID= '{Selector1}' ";
                case "UserName":
                    return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where Users.UserName= '{Selector1}' ";
                case "Person ID ":
                    return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where Users.PersonID= '{Selector1}' ";
                case "User ID":
                    return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where Users.UserID= '{Selector1}' ";
                case "Full Name":// Users table inner join People table          
                    return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where FirstName+' '+SecondName+' '+ThirdName+' '+LastName= '{Selector1}' ";
                case "Full Name ":// People table only
                    return $"select * from People where FirstName+' '+SecondName+' '+ThirdName+' '+LastName= '{Selector1}' ";
                case "All People":
                    return "select * from People ";
                case "All Users":
                    return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID ";
                case "All Application Types":
                    return "select * from DVLD.dbo.ApplicationTypes";
                case "All Test Types":
                    return "select * from DVLD.dbo.TestTypes";
                case "All Countries":
                    return "SELECT * FROM DVLD.dbo.Countries order by CountryName";
                case "All License Classes":
                    return "select * from DVLD.dbo.LicenseClasses";
                case "All Local Driving license Applications":
                    return "select People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName , People.NationalNo,LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID ,Applications.ApplicationDate ,case when Applications.ApplicationStatus=1 then 'New' when Applications.ApplicationStatus=2 then 'Cancel' when Applications.ApplicationStatus=3 then 'Completed' end as ApplicationStatus, LicenseClasses.ClassName,COUNT(case when TestResult>0 then 1 end) as PassedTests from People inner join Applications on People.PersonID=Applications.ApplicationPersonID inner join LocalDrivingLicenseApplications on LocalDrivingLicenseApplications.ApplicationID=Applications.ApplicationID inner join LicenseClasses on LocalDrivingLicenseApplications.LicenseClassID=LicenseClasses.LicenseClassID left join TestAppointments on TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID left join Tests on Tests.TestAppointmentID=TestAppointments.TestAppointmentID group by People.FirstName,    People.SecondName,   People.ThirdName,   People.LastName,    People.NationalNo,    LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,    Applications.ApplicationDate,    Applications.ApplicationStatus,  LicenseClasses.ClassName,   LicenseClasses.LicenseClassID";
                case "Delete User":
                    return $"Delete Users where UserID = '{Selector1}'";
                case "Delete Person":
                    return $"Delete People where PersonID = '{Selector1}'";
                case "Application Type":
                    return @"Update  DVLD.dbo.ApplicationTypes set ApplicationTypeTitle = @Title, ApplicationFees = @Fees where ApplicationTypeID = @ID";
                case "Test Type":
                    return @"Update  DVLD.dbo.TestTypes set TestTypeTitle = @Title, TestTypeFees = @Fees ,TestTypeDescription=@Description where TestTypeID = @ID";
                case "Is Active":
                    return $"select Users.UserID,Users.PersonID,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as FullName,UserName,IsActive from Users inner join People on People.PersonID=Users.PersonID where Users.IsActive= '{Selector1}' ";
                case "Is National No Exists":
                    return $"SELECT Found=1 FROM People WHERE NationalNo = '{Selector1}'";
                case "Is Local Driving License Application Exists":
                    return $"select Applications.ApplicationID from Applications inner join LocalDrivingLicenseApplications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID\r\nwhere Applications.ApplicationPersonID='{Selector1}' and Applications.ApplicationStatus in (1,3) and LocalDrivingLicenseApplications.LicenseClassID='{Selector2}' and Applications.ApplicationTypeID=1";
                case "Is User Exists":
                    return $"select  1 as found from DVLD.dbo.Users  where PersonID='{Selector1}' ";
                    
            }
            return "";
        }

        public static int IsExist(string TypeFilter, string Selector1,string Selector2)
        {
            return clsDataBaseManagement.IsExist(Filter, TypeFilter, Selector1,Selector2);
        }
       public static void RecordExceptionErrorInEventViewer(string SourceName,string Description)
        {
            if(!EventLog.SourceExists(SourceName))
                EventLog.CreateEventSource(SourceName, "Application");
                
            EventLog.WriteEntry(SourceName, Description, EventLogEntryType.Error);

        }
        public static string ComputeHash(string input)
        {
            using (SHA256 _SHA = SHA256.Create())
            {
                byte[] input_bytes = Encoding.UTF8.GetBytes(input);
                byte[] output_bytes = SHA256.Create().ComputeHash(input_bytes);
                return BitConverter.ToString(output_bytes).Replace("-", "").ToLower();
            }
        }
    }

}
