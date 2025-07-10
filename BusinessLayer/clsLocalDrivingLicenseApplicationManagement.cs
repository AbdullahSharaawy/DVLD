using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class clsLocalDrivingLicenseApplicationManagement
    {
        public static int AddNewContact(int ApplicationID,int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplication.AddNewContact(ApplicationID, LicenseClassID);
        }
        public static DataTable GetAll()
        {
            return clsGetAll.GetAllContacts(clsGlobalMethods.Filter, "All Local Driving license Applications", "");
        }
        public static DataTable GetApplicationBasicInfo(string NationalNumber,string ClassName) { 
           return clsLocalDrivingLicenseApplication.GetApplicationBasicInfo(NationalNumber, ClassName);
        }
    }
}
