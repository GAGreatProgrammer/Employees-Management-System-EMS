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
    public partial class EmployeeInfoEditing : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        public EmployeeInfoEditing()
        {
            InitializeComponent();
            this.Icon = Employees_Management_System.Properties.Resources.responsive;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void EmployeeInfoEditing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);

            Fill();

            dgvEmployees.Columns[0].HeaderText = "ID";
            dgvEmployees.Columns[1].HeaderText = "პირადი ნომერი";
            dgvEmployees.Columns[2].HeaderText = "სახელი";
            dgvEmployees.Columns[3].HeaderText = "გვარი";
            dgvEmployees.Columns[4].HeaderText = "სქესი";
            dgvEmployees.Columns[5].HeaderText = "ტელეფონი";
            dgvEmployees.Columns[6].HeaderText = "ელ.ფოსტა";
            dgvEmployees.Columns[7].HeaderText = "დეპარტამენტი";

            dgvEmployees.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployees.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployees.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployees.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployees.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployees.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployees.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployees.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployees.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployees.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvEmployees.Columns[0].Width = 200;
            dgvEmployees.Columns[1].Width = 200;
            dgvEmployees.Columns[2].Width = 200;
            dgvEmployees.Columns[3].Width = 200;
            dgvEmployees.Columns[4].Width = 200;
            dgvEmployees.Columns[5].Width = 200;
            dgvEmployees.Columns[6].Width = 200;
            dgvEmployees.Columns[7].Width = 300;

            dgvEmployees.Columns[0].Visible = false;
            cboEmployeeID.SelectedItem = null;
        }

        private void Fill()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM EmployeeInfoForEditing ORDER BY [Surname] ASC",sqlConnection);

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "EmployeeInfoForEditing");

                dgvEmployees.DataSource = dataSet.Tables["EmployeeInfoForEditing"];
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
            cboEmployeeID.SelectedItem = null;
            cboEmployeeID.Text = "";
            txtPassportID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
        }

        private void Filtering()
        {
            try
            {
                (dgvEmployees.DataSource as DataTable).DefaultView.RowFilter = $"[ID] LIKE '%{cboEmployeeID.SelectedValue}%' " +
                    $"AND [Passport_ID] LIKE '%{txtPassportID.Text}%' " +
                    $"AND [Name] LIKE '%{txtName.Text}%' " +
                    $"AND [Surname] LIKE '%{txtSurname.Text}%'";
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

        private void btnFiltering_Click(object sender, EventArgs e)
        {
            Filtering();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            Fill();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                if (indexRow >= 0)
                {
                    DataGridViewRow row = dgvEmployees.Rows[indexRow];
                    GlobalVariables.EmployeeID = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("გსურთ თანამშრომლის " +
                    "ინფორმაციის რედაქტირება?", "ინფორმაციის რედაქტირება", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(dialogResult == DialogResult.Yes)
                {
                    EmployeeEditingForm employeeEditingForm = new EmployeeEditingForm();
                    employeeEditingForm.ShowDialog();
                }
                else if(dialogResult == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
