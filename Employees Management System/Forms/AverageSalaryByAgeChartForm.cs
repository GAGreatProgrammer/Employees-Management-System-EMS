using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class AverageSalaryByAgeChartForm : Form
    {
        private SqlConnection sqlConnection = null;

        public AverageSalaryByAgeChartForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void AverageSalaryByAgeChartForm_Load(object sender, EventArgs e)
        {
            AverageSalaryByYear();
            TotalRateByYear();
            TotalAwardByYear();
        }

        private void AverageSalaryByYear()
        {
            bunifuChartCanvas1.Clear();
            sqlConnection.Open();

            List<string> Age = new List<string>();
            List<double> Salary = new List<double>();

            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM EmployeeAverageSalaryByAge ORDER BY [Age] ASC", sqlConnection);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Age.Add(dataReader.GetValue(0).ToString());
                Salary.Add(float.Parse(dataReader.GetValue(1).ToString()));
            }

            //string[] Array = Year.ToArray();

            bunifuLineChart1.Data = Salary;

            bunifuChartCanvas1.Labels = Age.ToArray();
            //bunifuLineChart1.BackgroundColor = Color.Blue;

            sqlConnection.Close();
        }

        private void TotalRateByYear()
        {
            bunifuChartCanvas2.Clear();
            sqlConnection.Open();

            List<string> Year = new List<string>();
            List<double> Rate = new List<double>();
            List<Color> bgColors = new List<Color>();

            var r = new Random();


            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM EmployeeTotalRateByYear ORDER BY [Year] ASC", sqlConnection);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Year.Add(dataReader.GetValue(0).ToString());
                Rate.Add(float.Parse(dataReader.GetValue(1).ToString()));
            }

            for (int i = 0; i < Rate.Count; i++)
            {
                bgColors.Add(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            }

            bunifuPieChart1.BackgroundColor = bgColors;

            //string[] Array = Year.ToArray();

            bunifuPieChart1.Data = Rate;

            bunifuChartCanvas2.Labels = Year.ToArray();
            //bunifuLineChart1.BackgroundColor = Color.Blue;

            sqlConnection.Close();
        }

        private void TotalAwardByYear()
        {
            bunifuChartCanvas3.Clear();
            sqlConnection.Open();

            List<string> Year = new List<string>();
            List<double> Award = new List<double>();
            List<Color> bgColors = new List<Color>();

            var r = new Random();

            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM EmployeeTotalAwardByYear ORDER BY [Year] ASC", sqlConnection);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Year.Add(dataReader.GetValue(0).ToString());
                Award.Add(Convert.ToDouble(dataReader.GetValue(1)));
            }

            for (int i = 0; i < Award.Count; i++)
            {
                bgColors.Add(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            }

            bunifuPolarAreaChart1.BackgroundColor = bgColors;

            //string[] Array = Bookings.ToArray();

            bunifuPolarAreaChart1.Data = Award;

            bunifuChartCanvas3.Labels = Year.ToArray();
            bunifuPolarAreaChart1.Label = "ჯამური პრემია წლის მიხედვით";

            sqlConnection.Close();
        }

        private void btnReload1_Click(object sender, EventArgs e)
        {
            bunifuChartCanvas1.Clear();
            AverageSalaryByYear();
        }

        private void btnReload2_Click(object sender, EventArgs e)
        {
            bunifuChartCanvas2.Clear();
            TotalRateByYear();
        }

        private void btnReload3_Click(object sender, EventArgs e)
        {
            bunifuChartCanvas3.Clear();
            TotalAwardByYear();
        }
    }
}
