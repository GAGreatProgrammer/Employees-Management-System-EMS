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
    public partial class ComparativeAnalysisChartForm : Form
    {
        private SqlConnection sqlConnection = null;

        public ComparativeAnalysisChartForm()
        {
            InitializeComponent();
            this.Icon = Employees_Management_System.Properties.Resources.responsive;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void ComparativeAnalysisChartForm_Load(object sender, EventArgs e)
        {
            ComparativeaAnalysis();
        }

        private void ComparativeaAnalysis()
        {
            sqlConnection.Open();

            List<string> Department = new List<string>();
            List<double> AverageSalary = new List<double>();
            List<Color> bgColors = new List<Color>();

            var r = new Random();

            SqlCommand sqlCommand = new SqlCommand($"SELECT YEAR([Payment_Date]) AS [Payment_Date], SUM([Rate]) AS [Rate] FROM EmployeePayHistory GROUP BY YEAR([Payment_Date])", sqlConnection);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Department.Add(dataReader.GetValue(0).ToString());
                AverageSalary.Add(Convert.ToDouble(dataReader.GetValue(1)));
            }

            for (int i = 0; i < AverageSalary.Count; i++)
            {
                bgColors.Add(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            }

            bunifuBarChart1.BackgroundColor = bgColors;

            string[] priceArray = Department.ToArray();

            bunifuBarChart1.Data = AverageSalary;

            bunifuChartCanvas1.Labels = priceArray;
            bunifuBarChart1.Label = "ხელფასის შედარებითი ანალიზი";

            sqlConnection.Close();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            bunifuChartCanvas1.Clear();
            ComparativeaAnalysis();
        }
    }
}
