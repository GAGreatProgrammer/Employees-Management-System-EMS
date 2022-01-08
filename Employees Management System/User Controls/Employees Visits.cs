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
    public partial class Employees_Visits : UserControl
    {
        private static Employees_Visits _instance;

        public static Employees_Visits Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Employees_Visits();
                return _instance;
            }
        }
        public Employees_Visits()
        {
            InitializeComponent();
        }
    }
}
