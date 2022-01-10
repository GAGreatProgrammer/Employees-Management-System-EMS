using Employees_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.User_Controls
{
    public partial class Employees_Salary : UserControl
    {
        private static Employees_Salary _instance;

        public static Employees_Salary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Employees_Salary();
                return _instance;
            }
        }
        public Employees_Salary()
        {
            InitializeComponent();
        }

        private void btnEmployeeBankAccount_Click(object sender, EventArgs e)
        {
            EmployeeBankAccountRegistration employeeBankAccountRegistration = new EmployeeBankAccountRegistration();
            employeeBankAccountRegistration.Show();
        }

        private void btnEmployeePayHistory_Click(object sender, EventArgs e)
        {
            EmployeePayHistory employeePayHistory = new EmployeePayHistory();
            employeePayHistory.Show();
        }
    }
}
