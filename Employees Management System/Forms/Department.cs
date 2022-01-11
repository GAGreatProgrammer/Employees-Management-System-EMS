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
    public partial class Department : Form
    {
        private SqlConnection sqlConnection = null;

        public Department()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);
            
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }

        private void Registration()
        {
            if (txtDepartment.Text == "")
            {
                MessageBox.Show("შეავსეთ ყველა სავალდებულო ველი!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand sqlCommand = new SqlCommand("AddDepartment", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@Department", SqlDbType.NVarChar).Value = txtDepartment.Text;
                sqlCommand.Parameters.Add("@Group_Name", SqlDbType.NVarChar).Value = txtGroupName.Text;
                sqlCommand.Parameters.Add("@Additional_Info", SqlDbType.NVarChar).Value = txtAdditionalInfo.Text;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"დეპარტამენტი წარმატებით დარეგისტრირდა", "დეპარტამენტის რეგისტრაცია", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtDepartment.Text = "";
            txtGroupName.Text = "";
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
    }
}
