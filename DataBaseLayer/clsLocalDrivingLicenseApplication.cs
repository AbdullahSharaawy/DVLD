using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer
{
    public class clsLocalDrivingLicenseApplication
    {
        public static int AddNewContact(int ApplicationID, int LicenseClassID)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int LocalDrivingLicenseApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            string query = @"INSERT INTO DVLD.dbo.LocalDrivingLicenseApplications (ApplicationID,LicenseClassID)
                             VALUES (@ApplicationID, @LicenseClassID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return LocalDrivingLicenseApplicationID;
        }
        public static DataTable GetApplicationBasicInfo(string NationalNumber, string ClassName)
        {
           
            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            string query = $"select Applications.ApplicationID,Applications.PaidFees,ApplicationTypes.ApplicationTypeTitle,Applications.ApplicationDate,Applications.LastStatusDate,Users.UserName " +
                $" from Applications inner join People on People.PersonID=Applications.ApplicationPersonID " +
                $"inner join Users on Users.UserID=Applications.CreatedByUserID " +
                $"inner join ApplicationTypes on ApplicationTypes.ApplicationTypeID=Applications.ApplicationTypeID " +
                $"inner join LocalDrivingLicenseApplications on LocalDrivingLicenseApplications.ApplicationID=Applications.ApplicationID inner join LicenseClasses on LicenseClasses.LicenseClassID=LocalDrivingLicenseApplications.LicenseClassID " +
                $" where People.NationalNo='{NationalNumber}' and LicenseClasses.ClassName='{ClassName}'";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();

            try
            {
              
                SqlDataReader result = command.ExecuteReader();
                if(result.HasRows){
                     dt.Load(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dt ;
        }
    }
}
