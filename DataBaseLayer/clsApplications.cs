using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataBaseLayer
{
    public class clsApplications
    {
        public static int AddNewContact(int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, Int16 ApplicationStatus, DateTime LastStatusDate, double PaidFees,
           int CreatedByUserID)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);

            string query = @"INSERT INTO DVLD.dbo.Applications (ApplicationPersonID, ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate , PaidFees, CreatedByUserID)
                             VALUES (@ApplicationPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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
            return ApplicationID;
        }
        public static Int16 SelectApplicationStatus(int ApplicationPersonID)
        {
            Int16 _ApplicationStatus=-1;
            SqlConnection connection = new SqlConnection(clsConnectionText.ConnectionText);
            string query = @"select top 1 ApplicationStatus from DVLD.dbo.Applications  where ApplicantPersonID=@ApplicationPersonID ORDER BY LastStatusDate desc";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationPersonID",ApplicationPersonID);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && Int16.TryParse(result.ToString(), out Int16 insertedID))
                {
                    _ApplicationStatus = insertedID;
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
            return _ApplicationStatus;
        }

    }
}
