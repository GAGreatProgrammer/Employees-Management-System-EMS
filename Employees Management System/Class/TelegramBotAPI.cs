using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.Class
{
    public class TelegramBotAPI
    {
        //Employee Info

        public static int EmployeeCount { get; set; } = -1;

        public static string EmployeePassportID { get; set; }
        public static string EmployeeFullName { get; set; }
        public static string EmployeeBirth_Date { get; set; }
        public static string EmployeeTelephone { get; set; }
        public static string EmployeeEmail { get; set; }
        public static string EmployeeDepartment { get; set; }
        public static string EmployeePosition { get; set; }
        public static string EmployeeStatus { get; set; }
        public static string EmployeeStart_Date { get; set; }
        public static MemoryStream EmployeePhoto { get; set; }


        private static SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);


        private static void Count()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmdCount = new SqlCommand($"SELECT COUNT(*) FROM Employee WHERE [Passport_ID] = '{EmployeePassportID}'", sqlConnection);
                SqlDataReader dr = cmdCount.ExecuteReader();

                while (dr.Read())
                {
                    EmployeeCount = int.Parse(dr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public static void EmployeeInfo()
        {
            Count();
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM BOTEmployeeInfo WHERE [Passport_ID] = '{EmployeePassportID}'", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EmployeePassportID = dr.GetValue(0).ToString();
                    EmployeeFullName = dr.GetValue(1).ToString();
                    EmployeeBirth_Date = dr.GetValue(2).ToString();
                    EmployeeTelephone = dr.GetValue(3).ToString();
                    EmployeeEmail = dr.GetValue(4).ToString();
                    EmployeeDepartment = dr.GetValue(5).ToString();
                    EmployeePosition = dr.GetValue(6).ToString();
                    EmployeeStatus = dr.GetValue(7).ToString();
                    EmployeeStart_Date = dr.GetValue(8).ToString();

                    EmployeePhoto = new MemoryStream((byte[])dr.GetValue(9));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
