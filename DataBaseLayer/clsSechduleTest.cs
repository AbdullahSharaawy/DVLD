using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer
{
    public static class clsSechduleTest
    {
        public static bool IsTestExists(string LocalDrivingLicenseID,string Status)
        {

            
            SqlConnection conn=new SqlConnection(clsConnectionText.ConnectionText);
            conn.Open();
            string Query = $"select * from TestAppointments where LocalDrivingLicenseApplicationID='{LocalDrivingLicenseID}' and TestTypeID='{SelectStatusNo(Status)}'";
            SqlCommand cmd = new SqlCommand(Query,conn);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
            catch(Exception ex) { throw(ex);   }
            finally { conn.Close(); }
           
        }
        private static int SelectStatusNo(string Status)
        {
            return Status == "New" ? 1 : (Status == "Completed" ? 3 : 2);
        }
    }
}
