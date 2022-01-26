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
    public partial class Blacklist : Form
    {
        private SqlConnection sqlConnection = null;

        public Blacklist()
        {
            InitializeComponent();
            this.Icon = Employees_Management_System.Properties.Resources.responsive;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void Registration()
        {
            if (cboEmployeeID.Text == "" || txtReason.Text == "")
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("AddBlacklist", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.UniqueIdentifier).Value = cboEmployeeID.SelectedValue;
                sqlCommand.Parameters.Add("@Effective_Date", SqlDbType.DateTime).Value = dtpEffectiveDate.Value.Date;
                sqlCommand.Parameters.Add("@Reason", SqlDbType.NVarChar).Value = txtReason.Text;
                sqlCommand.Parameters.Add("@Additional_Info", SqlDbType.NVarChar).Value = txtAdditionalInfo.Text;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"თანამშრომელი წარმატებით დაემატა", "შავი სია", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult dialogResult = MessageBox.Show("გსურთ მომხმარებლის წაშლა?", "მომხმარებლის წაშლა", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand sqlCommand = new SqlCommand("DeleteBlacklist", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@EmployeeID", SqlDbType.NVarChar).Value = GlobalVariables.EmployeeID;

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show($"თანამშრომელის წარმატებით წაიშალა", "მომხმარებლის წაშლა", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
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
            dtpEffectiveDate.Value = DateTime.Now;
            txtReason.Text = "";
            txtAdditionalInfo.Text = "";
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

        private void Blacklist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.BlacklistInfo' table. You can move, or remove it, as needed.
            this.blacklistInfoTableAdapter.Fill(this.eMSDataSet.BlacklistInfo);
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void dgvBlacklist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                if (indexRow >= 0)
                {
                    DataGridViewRow row = dgvBlacklist.Rows[indexRow];
                    GlobalVariables.EmployeeID = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
