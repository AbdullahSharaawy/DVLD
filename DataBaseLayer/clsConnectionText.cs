using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DataBaseLayer
{
    internal class clsConnectionText
    {
        public static string ConnectionText = ConfigurationManager.ConnectionStrings["MyDataBaseConnectionString"].ConnectionString;
    }
}
