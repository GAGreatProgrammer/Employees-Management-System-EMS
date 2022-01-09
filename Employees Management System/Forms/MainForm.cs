using Employees_Management_System.Forms;
using Employees_Management_System.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private int Radius = 50;

        public MainForm()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radius, Radius));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
