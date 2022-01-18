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
    public partial class EmployeeSalaryRegistration : Form
    {
        private SqlConnection sqlConnection = null;

        int PayFrequency;

        public EmployeeSalaryRegistration()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void Registration()
        {
            if (cboEmployeeID.Text == "" || txtSalary.Text == "" || cboPayFrequency.Text == "")
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                SqlCommand sqlCommand = new SqlCommand("AddEmployeeSalary", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.UniqueIdentifier).Value = cboEmployeeID.SelectedValue;
                sqlCommand.Parameters.Add("@Salary", SqlDbType.Float).Value = float.Parse(txtSalary.Text);
                sqlCommand.Parameters.Add("@Pay_Frequency", SqlDbType.Int).Value = PayFrequency;
                sqlCommand.Parameters.Add("@Additional_Info", SqlDbType.NVarChar).Value = txtAdditionalInfo.Text;


                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"თანამშრომლის ხელფასი წარმატებით დაებატა", "თანამშრომლის ხელფასი", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearData();
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
            cboEmployeeID.SelectedItem = null;
            txtSalary.Text = "";
            cboPayFrequency.Text = "";
            cboPayFrequency.SelectedItem = null;
            txtAdditionalInfo.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void EmployeeSalaryRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);

        }

        private void cboPayFrequency_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPayFrequency.SelectedIndex == 0)
            {
                PayFrequency = 1;
            }
            else if (cboPayFrequency.SelectedIndex == 1)
            {
                PayFrequency = 2;
            }
            else if (cboPayFrequency.SelectedIndex == 2)
            {
                PayFrequency = 3;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Registration();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeSalaryEditing employeeSalaryEditing = new EmployeeSalaryEditing();
            employeeSalaryEditing.Show();
        }
    }
}
