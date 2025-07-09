using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer
{
    public abstract class clsApplicationManagement:clsGetAll
    {
        public delegate string Filter(string TypeFilter, string Selector1,string Selector2);

        public static bool UpdateApplicationData(Filter Query,string TypeFilter,int ID, string Title, int Fees, string Description = "")
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            string query = Query(TypeFilter,"","");
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);
            if (query.Contains("@Description")) 
                command.Parameters.AddWithValue ("@Description", Description);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
       
    }
}
