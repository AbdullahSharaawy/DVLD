using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class clsApplicationsManagement 
    {
        public enum enMode { New , Update, Calncel}
        public static enMode Mode =new enMode();
        public static int AddNewContact(int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, Int16 ApplicationStatus, DateTime LastStatusDate, double PaidFees,
           int CreatedByUserID)
        {
            return clsApplications.AddNewContact(ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }
        public static Int16 ApplicationStatus(int ApplicationPersonID)
        {
            return clsApplications.SelectApplicationStatus(ApplicationPersonID);
        }
    }
}
