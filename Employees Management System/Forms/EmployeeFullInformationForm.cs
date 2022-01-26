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
    public partial class EmployeeFullInformationForm : Form
    {
        private SqlConnection sqlConnection = null;

        public EmployeeFullInformationForm()
        {
            InitializeComponent();
            this.Icon = Employees_Management_System.Properties.Resources.responsive;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

        }

        private void EmployeeFullInformationForm_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM  EmployeeFullInformation WHERE [ID] = '{GlobalVariables.EmployeeID}'", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lblEmployeeID.Text = dr.GetValue(0).ToString();
                    txtPassportID.Text = dr.GetValue(1).ToString();
                    txtName.Text = dr.GetValue(2).ToString();
                    txtSurname.Text = dr.GetValue(3).ToString();
                    txtFathersName.Text =  dr.GetValue(4).ToString();
                    txtGender.Text = dr.GetValue(5).ToString();
                    txtBirthDate.Text = dr.GetValue(6).ToString();
                    txtCountry.Text = dr.GetValue(7).ToString();
                    txtCity.Text = dr.GetValue(8).ToString();
                    txtStreet.Text = dr.GetValue(9).ToString();
                    txtMaritalStatus.Text = dr.GetValue(10).ToString();
                    txtTelephone.Text = dr.GetValue(11).ToString();
                    txtEmail.Text = dr.GetValue(12).ToString();
                    txtDepartment.Text = dr.GetValue(13).ToString();
                    txtPosition.Text = dr.GetValue(14).ToString();
                    txtStartDate.Text = dr.GetValue(15).ToString();
                    txtStatus.Text = dr.GetValue(16).ToString();
                    txtAccessLevel.Text = dr.GetValue(17).ToString();
                    txtQRCardID.Text = dr.GetValue(18).ToString();
                    txtBotID.Text = dr.GetValue(19).ToString();
                    txtBotAccessLevel.Text = dr.GetValue(20).ToString();
                    txtSalary.Text = dr.GetValue(21).ToString();
                    txtPayFrequency.Text = dr.GetValue(22).ToString();
                    txtBankAccount.Text = dr.GetValue(23).ToString();
                    txtBankCardNumber.Text = dr.GetValue(24).ToString();
                    txtAdditional_Info.Text = dr.GetValue(25).ToString();

                    MemoryStream ms = new MemoryStream((byte[])dr.GetValue(26));
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
    }
}
