using AForge.Video.DirectShow;
using Employees_Management_System.Class;
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
using ZXing;

namespace Employees_Management_System.Forms
{
    public partial class EmployeeVisitRegistration : Form
    {
        private SqlConnection sqlConnection = null;

        int Type = 1;

        public EmployeeVisitRegistration()
        {
            InitializeComponent();
            this.Icon = Employees_Management_System.Properties.Resources.responsive;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void EmployeeVisitRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);

        }


        private void Registration()
        {
            if (cboEmployeeID.Text == "" || cboType.Text == "")
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("AddEmployeeVisit", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.UniqueIdentifier).Value = cboEmployeeID.SelectedValue;
                sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Now.Date;
                sqlCommand.Parameters.Add("@Time", SqlDbType.Time).Value = DateTime.Now.TimeOfDay;
                sqlCommand.Parameters.Add("@Type", SqlDbType.Bit).Value = Type;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"ვიზიტი წარმატებით დარეგისტრირდა", "ვიზიტები", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ClearData()
        {
            cboEmployeeID.Text = "";
            cboType.Text = "";
        }

        private void cboType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboType.SelectedIndex == 0)
            {
                Type = 1;
            }
            else if (cboType.SelectedIndex == 1)
            {
                Type = 0;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Registration();
            ClearData();
        }
    }
}
