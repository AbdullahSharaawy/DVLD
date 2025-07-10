using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    //
    public class clsApplicationTypeManagement : clsServiceManagement
    {
        public clsApplicationType _ApplicationType=new clsApplicationType();
        public override DataTable GetAll(string TypeFilter = "", string Selector = "")
        {
            return DataBaseLayer.clsApplicationType.GetAllContacts(clsGlobalMethods.Filter,TypeFilter,Selector);
        }
        public void getApplicationData(int ID=-1,string Title="",int Fees=0)
        {
            _ApplicationType.ID = ID;
            _ApplicationType.Title = Title;
            _ApplicationType.Fees = Fees;
        }
        public override bool update()
        {
            return DataBaseLayer.clsApplicationType.UpdateApplicationData(clsGlobalMethods.Filter,"Application Type",_ApplicationType.ID, _ApplicationType.Title, _ApplicationType.Fees);
        }
    }
}
