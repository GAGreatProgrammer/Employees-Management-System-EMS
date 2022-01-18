using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.Class
{
    public class EmployeeGlobalInformation
    {
        private static SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        private static float AverageMonthSalary = 0;
        private static float AverageYearSalary = 0;
        private static int TotaQRCardCount = 0;
        private static int ActiveQRCard = 0;
        private static int BlockedQRCard = 0;
        private static int OverdueQRCard = 0;
        private static int EmployeeTotalCount = 0;
        private static int CameEmployees = 0;
        private static int NotCame = 0;
        private static float MinimumSalary = 0;
        private static float MaximumSalary = 0;
        private static float MaximumAward = 0;


        public static float EmployeeAverageMonthSalary()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM EmployeeAverageMonthSalary", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AverageMonthSalary = float.Parse(dr.GetValue(0).ToString());
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

            return AverageMonthSalary;
        }

        public static float EmployeeAverageYearSalary()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM EmployeeAverageYearSalary", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AverageYearSalary = float.Parse(dr.GetValue(0).ToString());
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

            return AverageYearSalary;

        }

        public static int QRCardCount()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM EmployeeQRCard", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    TotaQRCardCount = int.Parse(dr.GetValue(0).ToString());
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

            return TotaQRCardCount;

        }

        public static int ActiveQRCardCount()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM EmployeeQRCard WHERE Blocked = '0'", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ActiveQRCard = int.Parse(dr.GetValue(0).ToString());
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

            return ActiveQRCard;

        }

        public static int BlockedQRCardCount()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM EmployeeQRCard WHERE Blocked = '1'", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BlockedQRCard = int.Parse(dr.GetValue(0).ToString());
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

            return BlockedQRCard;

        }

        public static int OverdueQRCardCount()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM EmployeeQRCard WHERE DATEADD(DAY, -30, GETDATE()) >= [Created_Date] AND [Permanent_Card] = '0'", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    OverdueQRCard = int.Parse(dr.GetValue(0).ToString());
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

            return OverdueQRCard;

        }


        public static int EmployeeCount()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) AS [EmployeeCount] FROM Employee", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EmployeeTotalCount = int.Parse(dr.GetValue(0).ToString());
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

            return EmployeeTotalCount;

        }

        public static int EmployeeCame()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM CameEmployees", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CameEmployees = int.Parse(dr.GetValue(0).ToString());
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

            return CameEmployees;

        }

        public static int NotCameEmployees()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM NotCameEmployees", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    NotCame = int.Parse(dr.GetValue(0).ToString());
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

            return NotCame;

        }


        public static float EmployeeMinSalary()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT MIN([Salary]) AS [MinSalary] FROM EmployeeSalary", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    MinimumSalary = float.Parse(dr.GetValue(0).ToString());
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

            return MinimumSalary;
        }

        public static float EmployeeMaxSalary()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT MAX([Salary]) AS [MaxSalary] FROM EmployeeSalary", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    MaximumSalary = float.Parse(dr.GetValue(0).ToString());
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

            return MaximumSalary;
        }

        public static float EmployeeMaxAward()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT MAX([Award]) FROM EmployeePayHistory", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    MaximumAward = float.Parse(dr.GetValue(0).ToString());
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

            return MaximumAward;
        }
    }
}
