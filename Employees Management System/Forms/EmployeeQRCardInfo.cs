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
    public partial class EmployeeQRCardInfo : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        string PermanentCard;
        string Blocked;

        public EmployeeQRCardInfo()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void EmployeeQRCardInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.EmployeeShortInfo' table. You can move, or remove it, as needed.
            this.employeeShortInfoTableAdapter.Fill(this.eMSDataSet.EmployeeShortInfo);
            Fill();

            dgvEmployeeQRCard.Columns[0].HeaderText = "ID";
            dgvEmployeeQRCard.Columns[1].HeaderText = "პირადი ნომერი";
            dgvEmployeeQRCard.Columns[2].HeaderText = "სრული სახელი";
            dgvEmployeeQRCard.Columns[3].HeaderText = "QR ბარათის ID";
            dgvEmployeeQRCard.Columns[4].HeaderText = "მუდმივი QR ბარათი";
            dgvEmployeeQRCard.Columns[5].HeaderText = "შეცვლის პერიოდი";
            dgvEmployeeQRCard.Columns[6].HeaderText = "სტატუსი";

            dgvEmployeeQRCard.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployeeQRCard.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeQRCard.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEmployeeQRCard.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeQRCard.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeQRCard.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeQRCard.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeQRCard.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeQRCard.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployeeQRCard.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvEmployeeQRCard.Columns[0].Width = 200;
            dgvEmployeeQRCard.Columns[1].Width = 200;
            dgvEmployeeQRCard.Columns[2].Width = 200;
            dgvEmployeeQRCard.Columns[3].Width = 200;
            dgvEmployeeQRCard.Columns[4].Width = 200;
            dgvEmployeeQRCard.Columns[5].Width = 200;
            dgvEmployeeQRCard.Columns[6].Width = 200;

            dgvEmployeeQRCard.Columns[0].Visible = false;
            cboEmployeeID.SelectedItem = null;
            tglPermanentCard.Checked = true;
            PermanentCard = "მუდმივი";
            Blocked = "არ არის დაბლოკილი";
        }

        private void Fill()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM EmployeeQRCardInfo ORDER BY [FullName] ASC", sqlConnection);

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "EmployeeQRCardInfo");

                dgvEmployeeQRCard.DataSource = dataSet.Tables["EmployeeQRCardInfo"];
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
                (dgvEmployeeQRCard.DataSource as DataTable).DefaultView.RowFilter = $"[EmployeeID] LIKE '%{cboEmployeeID.SelectedValue}%' " +
                    $"AND [QRCard_ID] LIKE '%{txtQRCardID.Text}%' " +
                    $"AND [Permanent_Card] LIKE '%{PermanentCard}%' " +
                    $"AND [Blocked] LIKE '%{Blocked}%'";
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


        private void btnReload_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cboEmployeeID.SelectedItem = null;
            cboEmployeeID.Text = "";
            txtQRCardID.Text = "";
            tglPermanentCard.Checked = true;
            tglBlocked.Checked = false;
        }

        private void btnFiltering_Click(object sender, EventArgs e)
        {
            Filtering();
        }

        private void tglPermanentCard_CheckedChanged(object sender, EventArgs e)
        {
            if (tglPermanentCard.Checked == true)
                PermanentCard = "მუდმივი";
            else if (tglPermanentCard.Checked == false)
                PermanentCard = "დროებითი";
                
        }

        private void tglBlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (tglBlocked.Checked == true)
                Blocked = "დაბლოკილია";
            else if (tglBlocked.Checked == false)
                Blocked = "არ არის დაბლოკილი";
        }

        private void dgvEmployeeQRCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                if (indexRow >= 0)
                {
                    DataGridViewRow row = dgvEmployeeQRCard.Rows[indexRow];
                    GlobalVariables.EmployeeID = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployeeQRCard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
