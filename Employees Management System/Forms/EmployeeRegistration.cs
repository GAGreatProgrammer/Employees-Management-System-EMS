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
    public partial class EmployeeRegistration : Form
    {
        private SqlConnection sqlConnection = null;

        string filename;

        byte[] Image;

        public EmployeeRegistration()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.eMSDataSet.Department);
            // TODO: This line of code loads data into the 'eMSDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.eMSDataSet.Countries);
        }

        private byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
            tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                goto tryagain;
            }

            return stream.ToArray();
        }

        private void Registration()
        {
            if (txtPassportID.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtFathersName.Text == "" ||
                cboGender.Text == "" || cboMaritalStatus.Text == "" || txtTelephone.Text == "" || txtEmail.Text == "" ||
                cboCountry.Text == "" || txtCity.Text == "" || txtStreet.Text == "" || cboDepartment.Text == "" ||
                txtPosition.Text == "" || pbPhoto.Image == null || cboStatus.Text == "")
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            else
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("EmployeeRegistration", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@PassportID", SqlDbType.NVarChar).Value = txtPassportID.Text;
                    sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtName.Text;
                    sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = txtSurname.Text;
                    sqlCommand.Parameters.Add("@FathersName", SqlDbType.NVarChar).Value = txtFathersName.Text;
                    sqlCommand.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = cboGender.Text;
                    sqlCommand.Parameters.Add("@Birth_Date", SqlDbType.Date).Value = dtpBirth_Date.Value.Date;
                    sqlCommand.Parameters.Add("@Marital_Status", SqlDbType.NVarChar).Value = cboMaritalStatus.Text;
                    sqlCommand.Parameters.Add("@Telephone", SqlDbType.NVarChar).Value = txtTelephone.Text;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                    sqlCommand.Parameters.Add("@Country", SqlDbType.Int).Value = cboCountry.SelectedValue;
                    sqlCommand.Parameters.Add("@City", SqlDbType.NVarChar).Value = txtCity.Text;
                    sqlCommand.Parameters.Add("@Street", SqlDbType.NVarChar).Value = txtStreet.Text;
                    sqlCommand.Parameters.Add("@Department", SqlDbType.Int).Value = cboDepartment.SelectedValue;
                    sqlCommand.Parameters.Add("@Position", SqlDbType.NVarChar).Value = txtPosition.Text;
                    sqlCommand.Parameters.Add("@Photo", SqlDbType.Image).Value = Image;
                    sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = cboStatus.Text;
                    sqlCommand.Parameters.Add("@Start_Date", SqlDbType.Date).Value = dtpStartDate.Value.Date;
                    sqlCommand.Parameters.Add("@Additional_Info", SqlDbType.NVarChar).Value = txtAdditional_Info.Text;

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show($"თანამშრომელი წარმატებით დარეგისტრირდა", "თანამშრომლის რეგისტრაცია", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    ClearData();
                }
            }
        }

        private void ClearData()
        {
            txtPassportID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtFathersName.Text = "";
            cboGender.Text = "";
            dtpBirth_Date.Value = DateTime.Now;
            cboCountry.Text = "";
            cboMaritalStatus.Text = "";
            txtTelephone.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            txtStreet.Text = "";
            cboDepartment.Text = "";
            txtPosition.Text = "";
            dtpStartDate.Value = DateTime.Now;
            cboStatus.Text = "";
            txtAdditional_Info.Text = "";
            pbPhoto.Image = null;
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbPhoto.Image = new Bitmap(open.FileName);
                filename = open.FileName;
                Image = ImageToStream(filename);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Registration();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtPassportID_Leave(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand($"SELECT Passport_ID FROM Employee WHERE Passport_ID ='{txtPassportID.Text}'", sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("შეყვანილი მონაცემი არსებობს მონაცემთა ბაზაში!", "ყურადღება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassportID.Text = "";
                    txtPassportID.Focus();
                }
                else
                {

                }
                reader.Close();
                reader.Dispose();
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

        private void btnBankAccount_Click(object sender, EventArgs e)
        {
            EmployeeBankAccountRegistration employeeBankAccountRegistration = new EmployeeBankAccountRegistration();
            employeeBankAccountRegistration.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            EmployeeSalaryRegistration employeeSalaryRegistration = new EmployeeSalaryRegistration();
            employeeSalaryRegistration.Show();
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            EmployeeAccountGeneration employeeAccountGeneration = new EmployeeAccountGeneration();
            employeeAccountGeneration.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
