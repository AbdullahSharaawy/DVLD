using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public abstract class clsServiceManagement : inUpdate, inGetAll
    {
        public  abstract DataTable GetAll(string TypeFilter = "", string Selector = "");
       
        public abstract bool update();

       


    }
}
