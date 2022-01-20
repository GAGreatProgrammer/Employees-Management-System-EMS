using Employees_Management_System.Class;
using Employees_Management_System.Forms;
using Employees_Management_System.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System
{
    public partial class MainForm : Form
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


        private int Radius = 50;

        public MainForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EMSConnectionString"].ConnectionString);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radius, Radius));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (!contentPanel.Controls.Contains(Employees.Instance))
            //{
            //    contentPanel.Controls.Add(Employees.Instance);
            //    Employees.Instance.Dock = DockStyle.Fill;
            //    Employees.Instance.BringToFront();
            //}

            //else
            //{
            //    Employees.Instance.BringToFront();
            //}

            Fill();

            GlobalMethods.EmployeeAccess();

            lblEmployee.Text = GlobalVariables.LoggedEmployeeFullName;

            if(GlobalVariables.AccessLevel == 0)
            {
                MessageBox.Show("თქვენ არ გაქვთ წვდომის უფლება!", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }
            else if(GlobalVariables.AccessLevel == 1)
            {
                if (!contentPanel.Controls.Contains(EmployeesQRCard.Instance))
                {
                    contentPanel.Controls.Add(EmployeesQRCard.Instance);
                    EmployeesQRCard.Instance.Dock = DockStyle.Fill;
                    EmployeesQRCard.Instance.BringToFront();
                }

                else
                {
                    EmployeesQRCard.Instance.BringToFront();
                }

                btnEmployees.Enabled = false;
                btnSalary.Enabled = false;
                btnAddVisits.Enabled = true;
                btnEmails.Enabled = false;
            }
            else if (GlobalVariables.AccessLevel == 2)
            {
                if (!contentPanel.Controls.Contains(EmployeesQRCard.Instance))
                {
                    contentPanel.Controls.Add(EmployeesQRCard.Instance);
                    EmployeesQRCard.Instance.Dock = DockStyle.Fill;
                    EmployeesQRCard.Instance.BringToFront();
                }

                else
                {
                    EmployeesQRCard.Instance.BringToFront();
                }

                btnEmployees.Enabled = false;
                btnSalary.Enabled = false;
                btnAddVisits.Enabled = true;
                btnEmails.Enabled = true;
            }
            else if (GlobalVariables.AccessLevel == 3)
            {
                if (!contentPanel.Controls.Contains(Employees_Salary.Instance))
                {
                    contentPanel.Controls.Add(Employees_Salary.Instance);
                    Employees_Salary.Instance.Dock = DockStyle.Fill;
                    Employees_Salary.Instance.BringToFront();
                }

                else
                {
                    Employees_Salary.Instance.BringToFront();
                }

                btnEmployees.Enabled = false;
                btnSalary.Enabled = true;
                btnAddVisits.Enabled = true;
                btnEmails.Enabled = true;
            }
            else if (GlobalVariables.AccessLevel >= 4)
            {
                if (!contentPanel.Controls.Contains(Employees.Instance))
                {
                    contentPanel.Controls.Add(Employees.Instance);
                    Employees.Instance.Dock = DockStyle.Fill;
                    Employees.Instance.BringToFront();
                }

                else
                {
                    Employees.Instance.BringToFront();
                }

                btnEmployees.Enabled = true;
                btnSalary.Enabled = true;
                btnAddVisits.Enabled = true;
                btnEmails.Enabled = true;
            }
        }

        private void Fill()
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM EmployeeImage WHERE [Username] = '{GlobalVariables.LoggedEmployeeFullName}'", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    MemoryStream ms = new MemoryStream((byte[])dr.GetValue(1));
                    pbEmployeePhoto.Image = new Bitmap(ms);
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

            private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(Employees.Instance))
            {
                contentPanel.Controls.Add(Employees.Instance);
                Employees.Instance.Dock = DockStyle.Fill;
                Employees.Instance.BringToFront();
            }

            else
            {
                Employees.Instance.BringToFront();
            }
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(Employees_Salary.Instance))
            {
                contentPanel.Controls.Add(Employees_Salary.Instance);
                Employees_Salary.Instance.Dock = DockStyle.Fill;
                Employees_Salary.Instance.BringToFront();
            }

            else
            {
                Employees_Salary.Instance.BringToFront();
            }
        }

        private void btnVisits_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(Employees_Visits.Instance))
            {
                contentPanel.Controls.Add(Employees_Visits.Instance);
                Employees_Visits.Instance.Dock = DockStyle.Fill;
                Employees_Visits.Instance.BringToFront();
            }

            else
            {
                Employees_Visits.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeRegistration employeeRegistration = new EmployeeRegistration();
            employeeRegistration.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Blacklist blacklist = new Blacklist();
            blacklist.Show();
        }

        private void btnAddVisits_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(EmployeesQRCard.Instance))
            {
                contentPanel.Controls.Add(EmployeesQRCard.Instance);
                EmployeesQRCard.Instance.Dock = DockStyle.Fill;
                EmployeesQRCard.Instance.BringToFront();
            }

            else
            {
                EmployeesQRCard.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
        }
    }
}
