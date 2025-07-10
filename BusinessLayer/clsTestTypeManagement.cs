using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class clsTestTypeManagement:clsServiceManagement
    {
        public clsTestType _TestType = new clsTestType();
        public override DataTable GetAll(string TypeFilter = "", string Selector = "")
        {
            return DataBaseLayer.clsApplicationType.GetAllContacts(clsGlobalMethods.Filter, TypeFilter, Selector);
        }
        public void getTestData(int ID = -1, string Title = "", int Fees = 0,string Description="")
        {
            _TestType.ID = ID;
            _TestType.Title = Title;
            _TestType.Fees = Fees;
            _TestType.Description = Description;
        }
        public override bool update()
        {
            return DataBaseLayer.clsApplicationType.UpdateApplicationData(clsGlobalMethods.Filter,"Test Type",_TestType.ID, _TestType.Title, _TestType.Fees,_TestType.Description);
        }
    }
}
