using Employees_Management_System.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private SqlConnection sqlConnection = null;

        Thread thread;

        private int Radius = 50;

        public Login()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radius, Radius));
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void MainForm()
        {
            Application.Run(new MainForm());
        }

        int Count = 0;
        private void LogIn()
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT COUNT(*) FROM EmployeeAccount WHERE [Username] = '{txtEmployee.Text}' AND [Password] = '{txtPassword.Text}'", sqlConnection);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //this.Hide();
                    //Form_Main_Navigation form_Main_Navigation = new Form_Main_Navigation();
                    //form_Main_Navigation.Closed += (s, args) => Environment.Exit(0);  //lambda ოპერატორი
                    //form_Main_Navigation.Show();

                    GlobalVariables.LoggedEmployeeFullName = txtEmployee.Text;

                    this.Close();
                    thread = new Thread(MainForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }

                else
                {
                    MessageBox.Show("Invalid username or password", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Count++;
                    if (Count == 3)
                    {
                        Environment.Exit(0);
                    }
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            LogIn();
        }
    }
}
