using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataBaseLayer.clsPeople;

namespace DataBaseLayer
{
    public abstract class clsGetAll
    {
        public static DataTable GetAllContacts(Filter FilterRecords, string TypeFilter, string Selector)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);
            string query = FilterRecords(TypeFilter, Selector,"");
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                 dt = null;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        
    }
}
