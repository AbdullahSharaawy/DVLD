using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataBaseLayer.clsPeople;

namespace DataBaseLayer
{
    public abstract class clsDataBaseManagement:clsGetAll
    {
        public static bool DeleteContact(Filter FilterRecords, string TypeFilter, string Selector)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);
            string query = FilterRecords(TypeFilter, Selector, "");
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }
        public static int IsExist(Filter FilterRecords,string FilterType, string Selector1,string Selector2)
        {
            bool isFound = false;
            int? ID = null;
            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            string query = FilterRecords(FilterType,Selector1,Selector2);

            SqlCommand command = new SqlCommand(query, connection);

            
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (FilterType == "Is Local Driving License Application Exists")
                {
                    if (reader.Read())
                    {
                        ID = reader.GetInt32(0);  // Ensure the first column contains an int
                    }
                }
                else
                {
                    isFound = reader.HasRows;
                }
                reader.Close();


                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            if (FilterType == "Is Local Driving License Application Exists")
                return ID.HasValue ? ID.Value : 0;

                return Convert.ToInt32(isFound);
         }


    }
}
