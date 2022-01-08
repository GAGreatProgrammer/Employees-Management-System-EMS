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
    public partial class Employees : UserControl
    {
        private static Employees _instance;

        public static Employees Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Employees();
                return _instance;
            }
        }

        public Employees()
        {
            InitializeComponent();
        }
    }
}
