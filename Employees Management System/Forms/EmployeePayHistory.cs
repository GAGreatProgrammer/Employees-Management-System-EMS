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
    public partial class EmployeePayHistory : Form
    {
        private SqlConnection sqlConnection = null;

        DateTime PayDate;
        DateTime From;
        DateTime To;

        public EmployeePayHistory()
        {
            InitializeComponent();
        }

        private void EmployeePayHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeePayHistoryInfo' table. You can move, or remove it, as needed.
            this.employeePayHistoryInfoTableAdapter.Fill(this.eMSDataSet.EmployeePayHistoryInfo);
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void Registration()
        {
            if (cboEmployeeID.Text == "" || cboPaymentState.Text == "" || cboPaymentType.Text == "" || txtRate.Text == "")
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                SqlCommand sqlCommand = new SqlCommand("AddEmployeePayHistory", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.UniqueIdentifier).Value = cboEmployeeID.SelectedValue;
                sqlCommand.Parameters.Add("@Payment_Date", SqlDbType.Date).Value = PayDate;
                sqlCommand.Parameters.Add("@From_Date", SqlDbType.Date).Value = From;
                sqlCommand.Parameters.Add("@To_Date", SqlDbType.Date).Value = To;
                sqlCommand.Parameters.Add("@Payment_Type", SqlDbType.NVarChar).Value = cboPaymentType.Text;
                sqlCommand.Parameters.Add("@Rate", SqlDbType.Float).Value = float.Parse(txtRate.Text);
                sqlCommand.Parameters.Add("@Award", SqlDbType.Float).Value = float.Parse(txtAward.Text);
                sqlCommand.Parameters.Add("@Payment_State", SqlDbType.NVarChar).Value = cboPaymentState.Text;
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

        private void cboPaymentState_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPaymentState.SelectedIndex == 0)
            {
                cboPaymentState.BackColor = Color.FromArgb(46, 204, 113);
                cboPaymentState.ForeColor = Color.White;
                cboPaymentState.IconColor = Color.White;
            }
            else if(cboPaymentState.SelectedIndex == 1)
            {
                cboPaymentState.BackColor = Color.FromArgb(241, 196, 15);
                cboPaymentState.ForeColor = Color.White;
                cboPaymentState.IconColor = Color.White;
            }
            else if (cboPaymentState.SelectedIndex == 2)
            {
                cboPaymentState.BackColor = Color.FromArgb(231, 76, 60);
                cboPaymentState.ForeColor = Color.White;
                cboPaymentState.IconColor = Color.White;
            }
        }

        private void cboPaymentType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPaymentType.SelectedIndex == 1)
            {
                txtAward.Enabled = false;
            }
            else if(cboPaymentType.SelectedIndex != 1)
            {
                txtAward.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Registration();
        }

        private void dtpPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            PayDate = dtpPaymentDate.Value.Date;
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            From = dtpFromDate.Value.Date;
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            To = dtpToDate.Value.Date;
        }
    }
}
