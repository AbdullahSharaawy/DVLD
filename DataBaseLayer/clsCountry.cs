using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer
{
    public class clsCountry:clsGetAll
    {
        public static int GetCountryIDUsingCountryName(string CountryName)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int CountryID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            string query = "select CountryID from Countries where CountryName=@CountryName ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int _CountryID))
                {
                    CountryID = _CountryID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return CountryID;
        }


        public static string GetCountryNameUsingCountryID(int CountryID)
        {
            string CountryName = "";
            using (SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText))
            {
                string query = "SELECT CountryName FROM DVLD.dbo.Countries WHERE CountryID = @CountryID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            CountryName = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception
                        throw;
                    }
                }
            }
            return CountryName;
        }


        

    }
}
