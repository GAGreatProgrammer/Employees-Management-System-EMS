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

namespace Employees_Management_System.Forms
{
    public partial class EmployeeAccountGeneration : Form
    {
        private SqlConnection sqlConnection = null;

        int PermanentPassword;
        int PasswordChangePeriod;

        public EmployeeAccountGeneration()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void EmployeeAccountGeneration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeAccountInfo' table. You can move, or remove it, as needed.
            this.employeeAccountInfoTableAdapter.Fill(this.eMSDataSet.EmployeeAccountInfo);
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);

            tglPermanentPassword.Checked = true;
            txtPasswordChangePeriod.Enabled = false;
        }

        private void Registration()
        {
            if (cboEmployeeID.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || cboAccessLevel.Text == "")
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("EmployeeAccountRegistration", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.UniqueIdentifier).Value = cboEmployeeID.SelectedValue;
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUserName.Text;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPassword.Text;
                sqlCommand.Parameters.Add("@Access_Level", SqlDbType.Int).Value = int.Parse(cboAccessLevel.Text);
                sqlCommand.Parameters.Add("@Permanent_Password", SqlDbType.Bit).Value = PermanentPassword;
                sqlCommand.Parameters.Add("@Password_Change_Period", SqlDbType.Int).Value = PasswordChangePeriod;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"მომხმარებლის ანგარიში წარმატებით დაემატა", "მომხმარებლის ანგარიში", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Delete()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("გსურთ მომხმარებლის ანგარიშის წაშლა?", "მომხმარებლის ანგარიშის წაშლა", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    SqlCommand sqlCommand = new SqlCommand("DeleteEmployeeAccount", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.NVarChar).Value = GlobalVariables.EmployeeID;

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show($"თანამშრომელის პირადი ანგარიში წარმატებით წაიშალა", "პირადი ანგარიშის წაშლა", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(dialogResult == DialogResult.No)
                {
                    return;
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

        private void ClearData()
        {
            cboEmployeeID.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            cboAccessLevel.Text = "";
            tglPermanentPassword.Checked = true;
            txtPasswordChangePeriod.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tglPermanentPassword.Checked == false && txtPasswordChangePeriod.Text == "")
            {
                MessageBox.Show($"შეავსეთ, პაროლის შეცვლის პერიოდის, ველი", "ყურადღება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

            }

            if (tglPermanentPassword.Checked == true)
            {
                PermanentPassword = 1;
                PasswordChangePeriod = 0;
                txtPasswordChangePeriod.Enabled = false;
            }
            else if(tglPermanentPassword.Checked == false)
            {
                PermanentPassword = 0;
                PasswordChangePeriod = int.Parse(txtPasswordChangePeriod.Text);
                txtPasswordChangePeriod.Enabled = true;
            }

            Registration();
            ClearData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void tglPermanentPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tglPermanentPassword.Checked == true)
            {
                txtPasswordChangePeriod.Enabled = false;
            }
            else if (tglPermanentPassword.Checked == false)
            {
                txtPasswordChangePeriod.Enabled = true;
            }
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                if (indexRow >= 0)
                {
                    DataGridViewRow row = dgvEmployeeAccount.Rows[indexRow];
                    GlobalVariables.EmployeeID = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
