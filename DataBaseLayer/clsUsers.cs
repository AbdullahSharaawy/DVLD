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
    public class clsUsers : clsDataBaseManagement
    {
        public  delegate string IsValid(string ColumnName, string value1,string value2);

        public static bool GetContactInfoByID(ref int UserID,ref int PersonID, ref string UserName, ref string Password, ref int IsActive)
        {
            bool isFound = false;
            string query;
            SqlCommand command;
            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            if(UserID==-1)
            {
                query = "SELECT * FROM Users WHERE UserName = @UserName";

                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserName", UserName);


            }
            else
            {
                query = "SELECT * FROM Users WHERE UserID = @UserID";

                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserID", UserID);

            }

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = Convert.ToInt16(reader["IsActive"]);
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    UserID = Convert.ToInt32(reader["UserID"]);
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

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

            return isFound;
        }
        
        public static bool IsValid_LogInData(IsValid GetQuery,string ColumnName,string value1="",string value2="")
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            string query = GetQuery(ColumnName,value1,value2);

            SqlCommand command = new SqlCommand(query, connection);

            

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

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

            return isFound;
        }
        public static int AddNewUser(int PersonID,string UserName , string Password , int IsActive)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            string query = @"INSERT INTO Users (PersonID , UserName , Password , IsActive)
                             VALUES (@PersonID,@UserName,@Password,@IsActive);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
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

            return UserID;
        }
        public static bool UpdateUserData(int UserID, string UserName, string Password, int IsActive)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            string query = @"Update  Users set UserName = @UserName, Password = @Password,IsActive=@IsActive where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            
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

