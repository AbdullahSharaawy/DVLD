using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class clsSechduleTestManagement
    {
        public static bool IsTestExists(string LocalDrivingLicenseID,string Status)
        {
            return clsSechduleTest.IsTestExists(LocalDrivingLicenseID, Status);
        }
    }
}
