using Employees_Management_System.Class;
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

        private void Employees_Salary_Load(object sender, EventArgs e)
        {
            lblAverageMonthSalary.Text = EmployeeGlobalInformation.EmployeeAverageMonthSalary().ToString() + " GEL";

            lblAverageYearSalary.Text = EmployeeGlobalInformation.EmployeeAverageYearSalary().ToString() + " GEL";

            rgMinSalary.Minimum = 0;
            rgMinSalary.Maximum = int.Parse(EmployeeGlobalInformation.EmployeeMaxSalary().ToString());
            //rgMinSalary.ValueByTransition = int.Parse(EmployeeGlobalInformation.EmployeeMinSalary().ToString());
            rgMinSalary.TransitionValue(int.Parse(EmployeeGlobalInformation.EmployeeMinSalary().ToString()), 2000);

            rgMaxAward.Minimum = 0;
            rgMaxAward.Maximum = int.Parse(EmployeeGlobalInformation.EmployeeMaxSalary().ToString());
            //rgMaxAward.ValueByTransition = int.Parse(EmployeeGlobalInformation.EmployeeMaxAward().ToString());
            rgMaxAward.TransitionValue(int.Parse(EmployeeGlobalInformation.EmployeeMaxAward().ToString()), 2000);
        }

        private void btnEmployeeBankAccount_Click(object sender, EventArgs e)
        {
            EmployeeSalaryRegistration employeeSalaryRegistration = new EmployeeSalaryRegistration();
            employeeSalaryRegistration.Show();
        }

        private void btnEmployeePayHistory_Click(object sender, EventArgs e)
        {
            EmployeePayHistory employeePayHistory = new EmployeePayHistory();
            employeePayHistory.Show();
        }

        private void btnDepartmentAverageSalary_Click(object sender, EventArgs e)
        {
            DepartmentSalaryChartForm departmentSalaryChartForm = new DepartmentSalaryChartForm();
            departmentSalaryChartForm.Show();
        }

        private void btnAverageSalaryByYear_Click(object sender, EventArgs e)
        {
            AverageSalaryByAgeChartForm averageSalaryByAgeChartForm = new AverageSalaryByAgeChartForm();
            averageSalaryByAgeChartForm.Show();
        }

        private void btnComparativeAnalysis_Click(object sender, EventArgs e)
        {
            ComparativeAnalysisChartForm comparativeAnalysisChartForm = new ComparativeAnalysisChartForm();
            comparativeAnalysisChartForm.Show();
        }
    }
}
