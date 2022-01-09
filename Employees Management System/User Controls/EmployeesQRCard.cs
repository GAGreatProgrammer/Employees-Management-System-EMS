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
    public partial class EmployeesQRCard : UserControl
    {
        private static EmployeesQRCard _instance;

        public static EmployeesQRCard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeesQRCard();
                return _instance;
            }
        }
        public EmployeesQRCard()
        {
            InitializeComponent();
        }

        private void EmployeesQRCard_Load(object sender, EventArgs e)
        {

        }
    }
}
