using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Employees_Management_System.Class
{
    public class UserActivity
    {
        private static SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        public static void WriteLog(string Activity)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("AddActivityLog", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                sqlCommand.Parameters.Add("@Time", SqlDbType.Time).Value = DateTime.Now.ToString("hh:mm:ss");
                sqlCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = GlobalVariables.EmployeeID;
                sqlCommand.Parameters.Add("@Activity", SqlDbType.NVarChar).Value = Activity;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
