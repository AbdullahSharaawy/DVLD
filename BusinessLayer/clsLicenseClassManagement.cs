using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class clsLicenseClassManagement:inGetAll
    {
       
        public DataTable GetAll(string TypeFilter = "", string Selector = "")
        {
            return clsLicenseClass.GetAllContacts(clsGlobalMethods.Filter, TypeFilter,"");
        }
    }
}
