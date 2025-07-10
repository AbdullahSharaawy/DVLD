using BusinessLayer;
using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataBaseLayer.clsPeople;

namespace PresentationLayer
{
    public interface inUpdate
    {
         bool update();
    }
    public interface inGetAll
    {
        DataTable GetAll(string TypeFilter = "", string Selector = "");
    }
    public interface inSave
    {
        void save();
    }
    abstract public class clsPersonManagement :inUpdate,inGetAll,inSave
    {
        

        public enum enMode { Update = 0, AddNew = 1 };
        public enMode Mode = enMode.AddNew;
       
        abstract public void save();
        abstract public bool update();
        abstract public bool delete(int ID);
        abstract public void add();
        abstract public DataTable GetAll(string TypeFilter = "", string Selector = "");
        abstract public clsPersonManagement find(int PersonID);
       

    }
}
