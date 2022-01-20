using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Management_System.Class
{
    public static class GlobalVariables
    {
        public static readonly string EMSBotToken = "";

        public static string LoggedEmployeeID { get; set; }
        public static string LoggedEmployeeFullName { get; set; }
        public static int AccessLevel { get; set; }


        public static string EmployeeID { get; set; }
        public static int EmployeeAccessLevel { get; set; } = 3;


        public static string ClientID { get; set; }
    }
}
