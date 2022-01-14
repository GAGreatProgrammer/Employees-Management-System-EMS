using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using Employees_Management_System.Class;

namespace Employees_Management_System.Forms
{
    public partial class EmployeeFullInfoFiltering : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        int EmployeeMaxSalary;

        DateTime Today = DateTime.Now;

        public EmployeeFullInfoFiltering()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void EmployeeFullInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.eMSDataSet.Department);
            // TODO: This line of code loads data into the 'eMSDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.eMSDataSet.Countries);
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);


            Fill();

            dgvEmployeeFullInfo.Columns[0].HeaderText = "ID";
            dgvEmployeeFullInfo.Columns[1].HeaderText = "პირადი ნომერი";
            dgvEmployeeFullInfo.Columns[2].HeaderText = "სახელი";
            dgvEmployeeFullInfo.Columns[3].HeaderText = "გვარი";
            dgvEmployeeFullInfo.Columns[4].HeaderText = "ქვენა";
            dgvEmployeeFullInfo.Columns[5].HeaderText = "ტელეფონი";
            dgvEmployeeFullInfo.Columns[6].HeaderText = "ელ.ფისტა";
            dgvEmployeeFullInfo.Columns[7].HeaderText = "ქალაქი";
            dgvEmployeeFullInfo.Columns[8].HeaderText = "ქუჩა";
            dgvEmployeeFullInfo.Columns[9].HeaderText = "დეპარტამენტი";
            dgvEmployeeFullInfo.Columns[10].HeaderText = "პოზიცია";
            dgvEmployeeFullInfo.Columns[11].HeaderText = "სტატუსი";

            dgvEmployeeFullInfo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployeeFullInfo.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeFullInfo.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployeeFullInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeFullInfo.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvEmployeeFullInfo.Columns[0].Width = 200;
            dgvEmployeeFullInfo.Columns[1].Width = 200;
            dgvEmployeeFullInfo.Columns[2].Width = 200;
            dgvEmployeeFullInfo.Columns[3].Width = 200;
            dgvEmployeeFullInfo.Columns[4].Width = 200;
            dgvEmployeeFullInfo.Columns[5].Width = 200;
            dgvEmployeeFullInfo.Columns[6].Width = 200;
            dgvEmployeeFullInfo.Columns[7].Width = 300;
            dgvEmployeeFullInfo.Columns[8].Width = 300;
            dgvEmployeeFullInfo.Columns[9].Width = 300;
            dgvEmployeeFullInfo.Columns[10].Width = 300;
            dgvEmployeeFullInfo.Columns[11].Width = 200;

            dgvEmployeeFullInfo.Columns[0].Visible = false;
            cboEmployeeID.SelectedItem = null;

            MaxSalary();

            lblSalary.Text = "0";
            sliderSalary.Minimum = 0;
            sliderSalary.Value = 0;
            sliderSalary.Maximum = EmployeeMaxSalary;
        }

        private void Fill()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM EmployeeFullInfoFiltering ORDER BY [Surname] ASC", sqlConnection);

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "EmployeeFullInfoFiltering");

                dgvEmployeeFullInfo.DataSource = dataSet.Tables["EmployeeFullInfoFiltering"];
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

        private void MaxSalary()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT CAST(MAX(Salary) AS INT) AS [Salary] FROM EmployeeSalary", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EmployeeMaxSalary = int.Parse(dr.GetValue(0).ToString());
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

        private void Filtering()
        {
            try
            {
                (dgvEmployeeFullInfo.DataSource as DataTable).DefaultView.RowFilter = $"[EmployeeID] LIKE '%{cboEmployeeID.SelectedValue}%' " +
                    $"AND [Passport_ID] LIKE '%{txtPassportID.Text}%' " +
                    $"AND [Name] LIKE '%{txtName.Text}%' " +
                    $"AND [Surname] LIKE '%{txtSurname.Text}%' " +
                    $"AND [Country] LIKE '%{cboCountry.Text}%' " +
                    $"AND [Telephone] LIKE '%{txtTelephone.Text}%' " +
                    $"AND [Email] LIKE '%{txtEmail.Text}%' " +
                    $"AND [City] LIKE '%{txtCity.Text}%' " +
                    $"AND [Street] LIKE '%{txtStreet.Text}%' " +
                    $"AND [Department] LIKE '%{cboDepartment.Text}%' " +
                    $"AND [Position] LIKE '%{txtPosition.Text}%' " +
                    $"AND [Status] LIKE '%{cboStatus.Text}%'";
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

        private void Birthday()
        {
            try
            {
                (dgvEmployeeFullInfo.DataSource as DataTable).DefaultView.RowFilter = $"[Birth_Date] LIKE '%{Today.ToString("MM-dd")}%'";
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

        private void QRCard()
        {
            try
            {
                (dgvEmployeeFullInfo.DataSource as DataTable).DefaultView.RowFilter = $"[QRCard] IS NOT NULL";
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

        private void Blacklist()
        {
            try
            {
                (dgvEmployeeFullInfo.DataSource as DataTable).DefaultView.RowFilter = $"[Blacklist] IS NOT NULL";
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

        private void BotUser()
        {
            try
            {
                (dgvEmployeeFullInfo.DataSource as DataTable).DefaultView.RowFilter = $"[BotUser] IS NOT NULL";
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

        private void Salary()
        {
            try
            {
                (dgvEmployeeFullInfo.DataSource as DataTable).DefaultView.RowFilter = $"[Salary] >= '0' AND [Salary] <= '{EmployeeMaxSalary}'";
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
            cboCountry.SelectedItem = null;
            cboCountry.Text = "";
            txtTelephone.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            txtStreet.Text = "";
            cboDepartment.SelectedItem = null;
            cboDepartment.Text = "";
            txtPosition.Text = "";
            cboStatus.SelectedItem = null;
            cboStatus.Text = "";
            cboStatus.BackColor = Color.White;
            tglBirthday.Checked = false;
            tglQRCard.Checked = false;
            tglBlacklist.Checked = false;
            tglBot.Checked = false;
            sliderSalary.Value = int.MinValue;
            lblSalary.Text = "0";
        }

        private void cboStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboStatus.SelectedIndex == 0)
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

        private void sliderSalary_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            lblSalary.Text = sliderSalary.Value.ToString();
            EmployeeMaxSalary = sliderSalary.Value;
        }

        private void btnFilteringPrimary_Click(object sender, EventArgs e)
        {
            Filtering();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Fill();
        }


        private void tglBirthday_CheckedChanged(object sender, EventArgs e)
        {
            if (tglBirthday.Checked == true)
                Birthday();
            else if (tglBirthday.Checked == false)
                Fill();
        }

        private void tglQRCard_CheckedChanged(object sender, EventArgs e)
        {
            if (tglQRCard.Checked == true)
                QRCard();
            else if (tglQRCard.Checked == false)
                Fill();
        }

        private void tglBlacklist_CheckedChanged(object sender, EventArgs e)
        {
            if (tglBlacklist.Checked == true)
                Blacklist();
            else if (tglBlacklist.Checked == false)
                Fill();
        }

        private void tglBot_CheckedChanged(object sender, EventArgs e)
        {
            if (tglBot.Checked == true)
                BotUser();
            else if (tglBot.Checked == false)
                Fill();
        }

        private void btnSalaryFiltering_Click(object sender, EventArgs e)
        {
            Salary();
        }

        private void dgvEmployeeFullInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                if (indexRow >= 0)
                {
                    DataGridViewRow row = dgvEmployeeFullInfo.Rows[indexRow];
                    GlobalVariables.EmployeeID = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployeeFullInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
