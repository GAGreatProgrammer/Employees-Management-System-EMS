using Employees_Management_System.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class EmployeeEditingForm : Form
    {
        private SqlConnection sqlConnection = null;

        int Department = 0;
        public EmployeeEditingForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void EmployeeEditingForm_Load(object sender, EventArgs e)
        {
            Fill();
            ComboBoxFill();
            Block();
        }

        private void Fill()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM EditEmployeeInfoForm WHERE [ID] = '{GlobalVariables.EmployeeID}'",sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    txtPassportID.Text = dr.GetValue(1).ToString();
                    txtName.Text = dr.GetValue(2).ToString();
                    txtSurname.Text = dr.GetValue(3).ToString();
                    dtpBirthDate.Value = Convert.ToDateTime(dr.GetValue(4));
                    cboMaritalStatus.Text = dr.GetValue(5).ToString();
                    txtTelephone.Text = dr.GetValue(6).ToString();
                    txtEmail.Text = dr.GetValue(7).ToString();
                    txtCity.Text = dr.GetValue(8).ToString();
                    txtStreet.Text = dr.GetValue(9).ToString();
                    Department = int.Parse(dr.GetValue(10).ToString());
                    txtPosition.Text = dr.GetValue(11).ToString();
                    cboStatus.Text = dr.GetValue(12).ToString();

                    MemoryStream ms = new MemoryStream((byte[])dr.GetValue(13));
                    pbPhoto.Image = new Bitmap(ms);
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

        private void ComboBoxFill()
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT [ID], [Department] FROM Department WHERE [ID] = '{Department}'", sqlConnection);
                sqlConnection.Open();
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Department");
                cboDepartment.DisplayMember = "Department";
                cboDepartment.ValueMember = "ID";
                cboDepartment.DataSource = dataSet.Tables["Department"];

                //cboDepartment.SelectedValue = Department;

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

        private void Edit()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("EmployeeInfoEditing", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = GlobalVariables.EmployeeID;
                sqlCommand.Parameters.Add("@PassportID", SqlDbType.NVarChar).Value = txtPassportID.Text;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtName.Text;
                sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = txtSurname.Text;
                sqlCommand.Parameters.Add("@Birth_Date", SqlDbType.Date).Value = dtpBirthDate.Value.Date;
                sqlCommand.Parameters.Add("@Marital_Status", SqlDbType.NVarChar).Value = cboMaritalStatus.Text;
                sqlCommand.Parameters.Add("@Telephone", SqlDbType.NVarChar).Value = txtTelephone.Text;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                sqlCommand.Parameters.Add("@City", SqlDbType.NVarChar).Value = txtCity.Text;
                sqlCommand.Parameters.Add("@Street", SqlDbType.NVarChar).Value = txtStreet.Text;
                sqlCommand.Parameters.Add("@Department", SqlDbType.Int).Value = cboDepartment.SelectedValue;
                sqlCommand.Parameters.Add("@Position", SqlDbType.NVarChar).Value = txtPosition.Text;
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = cboStatus.Text;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"თანამშრომლის ინფორმაცია წარმატებით დარედაქტირდა", "თანამშრომლის რედაქტირება", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Block()
        {
            txtPassportID.Enabled = false;
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            dtpBirthDate.Enabled = false;
            cboMaritalStatus.Enabled = false;
            txtTelephone.Enabled = false;
            txtEmail.Enabled = false;
            txtCity.Enabled = false;
            txtStreet.Enabled = false;
            cboDepartment.Enabled = false;
            txtPosition.Enabled = false;
            cboStatus.Enabled = false;
        }

        private void Unlock()
        {
            txtPassportID.Enabled = true;
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            dtpBirthDate.Enabled = true;
            cboMaritalStatus.Enabled = true;
            txtTelephone.Enabled = true;
            txtEmail.Enabled = true;
            txtCity.Enabled = true;
            txtStreet.Enabled = true;
            cboDepartment.Enabled = true;
            txtPosition.Enabled = true;
            cboStatus.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Edit();
            Block();
        }

        private void cboDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT [ID], [Department] FROM Department", sqlConnection);
                sqlConnection.Open();
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Department");
                cboDepartment.DisplayMember = "Department";
                cboDepartment.ValueMember = "ID";
                cboDepartment.DataSource = dataSet.Tables["Department"];

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Unlock();
        }
    }
}
