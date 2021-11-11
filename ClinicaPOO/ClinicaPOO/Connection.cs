using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaPOO
{
    class Connection
    {
        public string WindowsAuth;

        public void Connect()
        {
            WindowsAuth = "Persist Security Info=False; Integrated Security=true; Initial Catalog=ClinicaPOO; server=(local)";
        }
    }
}
