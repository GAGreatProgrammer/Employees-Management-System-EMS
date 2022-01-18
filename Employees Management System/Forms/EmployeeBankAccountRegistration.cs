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
    public partial class EmployeeBankAccountRegistration : Form
    {
        private SqlConnection sqlConnection = null;

        string CardNumber;
        public EmployeeBankAccountRegistration()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void Registration()
        {
            if (cboEmployeeID.Text == "" || cboCardType.Text == "" || txtCardNumber1.Text == "" || txtExpMonth.Text == "" ||
                txtExpYear.Text == "" || txtBankAccountNumber.Text == "")
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("AddEmployeeBankAccount", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.UniqueIdentifier).Value = cboEmployeeID.SelectedValue;
                sqlCommand.Parameters.Add("@Card_Type", SqlDbType.NVarChar).Value = cboCardType.Text;
                sqlCommand.Parameters.Add("@Card_Number", SqlDbType.NVarChar).Value = CardNumber;
                sqlCommand.Parameters.Add("@Exp_Month", SqlDbType.Int).Value = txtExpMonth.Text;
                sqlCommand.Parameters.Add("@Exp_Year", SqlDbType.Int).Value = txtExpYear.Text;
                sqlCommand.Parameters.Add("@Bank_Account_Number", SqlDbType.NVarChar).Value = txtBankAccountNumber.Text;
                sqlCommand.Parameters.Add("@Additional_Info", SqlDbType.NVarChar).Value = txtAdditionalInfo.Text;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"თანამშრომლის საბანკო ანგარიში წარმატებით დარეგისტრირდა", "თანამშრომლის საბანკო ანგარიში", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cboCardType.Text = "";
            txtCardNumber1.Text = "";
            txtExpMonth.Text = "";
            txtExpYear.Text = "";
            txtBankAccountNumber.Text = "";
            txtAdditionalInfo.Text = "";
        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            Blacklist blacklist = new Blacklist();
            blacklist.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            EmployeeSalaryRegistration employeeSalaryRegistration = new EmployeeSalaryRegistration();
            employeeSalaryRegistration.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            EmployeePayHistory employeePayHistory = new EmployeePayHistory();
            employeePayHistory.Show();
        }

        private void EmployeeBankAccountRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Registration();
            ClearData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNumber__TextChanged_1(object sender, EventArgs e)
        {
            if(txtCardNumber1.Text.Count(x => x != '-') % 4 == 0)
            {
                txtCardNumber2.Focus();
            }
        }

        private void txtCardNumber2__TextChanged(object sender, EventArgs e)
        {
            if (txtCardNumber2.Text.Count(x => x != '-') % 4 == 0)
            {
                txtCardNumber3.Focus();
            }
        }

        private void txtCardNumber3__TextChanged(object sender, EventArgs e)
        {
            if (txtCardNumber3.Text.Count(x => x != '-') % 4 == 0)
            {
                txtCardNumber4.Focus();
            }
        }

        private void txtCardNumber4__TextChanged(object sender, EventArgs e)
        {
            if (txtCardNumber4.Text.Count(x => x != '-') % 4 == 0)
            {
                CardNumber = txtCardNumber1.Text + "-" + txtCardNumber2.Text + "-" + txtCardNumber3.Text + "-" + txtCardNumber4.Text;
                txtExpMonth.Focus();
            }
        }

        private void txtExpMonth__TextChanged(object sender, EventArgs e)
        {
            if (txtExpMonth.Text.Count(x => x != '-') % 2 == 0)
            {
                txtExpYear.Focus();
            }
        }

        private void txtExpYear__TextChanged(object sender, EventArgs e)
        {
            if (txtExpYear.Text.Count(x => x != '-') % 2 == 0)
            {
                txtBankAccountNumber.Focus();
            }
        }
    }
}
