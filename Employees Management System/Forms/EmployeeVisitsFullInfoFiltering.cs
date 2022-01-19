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
    public partial class EmployeeVisitsFullInfoFiltering : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        private string Date = null;

        public EmployeeVisitsFullInfoFiltering()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void EmployeeVisitsFullInfoFiltering_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.eMSDataSet.Department);
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);
            // TODO: This line of code loads data into the 'eMSDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.eMSDataSet.Department);
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);

            Fill();

            dgvEmployeeVisitsFullInfo.Columns[0].HeaderText = "ID";
            dgvEmployeeVisitsFullInfo.Columns[1].HeaderText = "პირადი ნომერი";
            dgvEmployeeVisitsFullInfo.Columns[2].HeaderText = "სრული სახელი";
            dgvEmployeeVisitsFullInfo.Columns[3].HeaderText = "ტელეფონი";
            dgvEmployeeVisitsFullInfo.Columns[4].HeaderText = "ელ.ფოსტა";
            dgvEmployeeVisitsFullInfo.Columns[5].HeaderText = "დეპარტამენტი";
            dgvEmployeeVisitsFullInfo.Columns[6].HeaderText = "პოზიცია";
            dgvEmployeeVisitsFullInfo.Columns[7].HeaderText = "სტატუსი";
            dgvEmployeeVisitsFullInfo.Columns[8].HeaderText = "თარიღი";
            dgvEmployeeVisitsFullInfo.Columns[9].HeaderText = "დრო";
            dgvEmployeeVisitsFullInfo.Columns[10].HeaderText = "ტიპი";

            dgvEmployeeVisitsFullInfo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployeeVisitsFullInfo.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeVisitsFullInfo.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployeeVisitsFullInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeVisitsFullInfo.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvEmployeeVisitsFullInfo.Columns[0].Width = 200;
            dgvEmployeeVisitsFullInfo.Columns[1].Width = 200;
            dgvEmployeeVisitsFullInfo.Columns[2].Width = 300;
            dgvEmployeeVisitsFullInfo.Columns[3].Width = 200;
            dgvEmployeeVisitsFullInfo.Columns[4].Width = 200;
            dgvEmployeeVisitsFullInfo.Columns[5].Width = 300;
            dgvEmployeeVisitsFullInfo.Columns[6].Width = 300;
            dgvEmployeeVisitsFullInfo.Columns[7].Width = 200;
            dgvEmployeeVisitsFullInfo.Columns[8].Width = 150;
            dgvEmployeeVisitsFullInfo.Columns[9].Width = 150;
            dgvEmployeeVisitsFullInfo.Columns[10].Width = 150;


            dgvEmployeeVisitsFullInfo.Columns[0].Visible = false;
            cboEmployeeID.SelectedItem = null;
        }

        private void Fill()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM EmployeeVisitsFullInfo ORDER BY [Date] DESC", sqlConnection);

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "EmployeeVisitsFullInfo");

                dgvEmployeeVisitsFullInfo.DataSource = dataSet.Tables["EmployeeVisitsFullInfo"];
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

        private void Filtering()
        {
            try
            {
                (dgvEmployeeVisitsFullInfo.DataSource as DataTable).DefaultView.RowFilter = $"[EmployeeID] LIKE '%{cboEmployeeID.SelectedValue}%' " +
                    $"AND [Passport_ID] LIKE '%{txtPassportID.Text}%' " +
                    $"AND [Telephone] LIKE '%{txtTelephone.Text}%' " +
                    $"AND [Email] LIKE '%{txtEmail.Text}%' " +
                    $"AND [Department] LIKE '%{cboDepartment.Text}%' " +
                    $"AND [Position] LIKE '%{txtPosition.Text}%' " +
                    $"AND [Status] LIKE '%{cboStatus.Text}%' " +
                    $"AND [DATE] LIKE '%{Date}%' " +
                    $"AND [TIME] LIKE '%{txtTime.Text}%' " +
                    $"AND [Type] LIKE '%{cboType.Text}%'";
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
            txtTelephone.Text = "";
            txtEmail.Text = "";
            cboDepartment.SelectedItem = null;
            cboDepartment.Text = "";
            txtPosition.Text = "";
            cboStatus.SelectedItem = null;
            cboStatus.Text = "";
            cboStatus.BackColor = Color.White;
            txtPosition.Text = "";
            txtTime.Text = "";
            Date = null;
            cboType.Text = "";
            dtpDate.Value = DateTime.Now;
        }

        private void cboStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStatus.SelectedIndex == 0)
            {
                cboStatus.BackColor = Color.FromArgb(46, 204, 113);
                cboStatus.ForeColor = Color.White;
                cboStatus.IconColor = Color.White;
            }
            else if (cboStatus.SelectedIndex == 1)
            {
                cboStatus.BackColor = Color.FromArgb(241, 196, 15);
                cboStatus.ForeColor = Color.White;
                cboStatus.IconColor = Color.White;
            }
            else if (cboStatus.SelectedIndex == 2)
            {
                cboStatus.BackColor = Color.FromArgb(231, 76, 60);
                cboStatus.ForeColor = Color.White;
                cboStatus.IconColor = Color.White;
            }
        }

        private void btnFilteringPrimary_Click(object sender, EventArgs e)
        {
            Filtering();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            Date = dtpDate.Value.ToString("dd/MM/yyyy");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void dgvEmployeeVisitsFullInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                if (indexRow >= 0)
                {
                    DataGridViewRow row = dgvEmployeeVisitsFullInfo.Rows[indexRow];
                    GlobalVariables.EmployeeID = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployeeVisitsFullInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("გსურთ თანამშრომლის " +
                    "სრული ინფორმაციის დათვალიერება?", "თანამშრომლის სრული ინფორმაცია", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    EmployeeFullInformationForm employeeFullInformationForm = new EmployeeFullInformationForm();
                    employeeFullInformationForm.Show();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
