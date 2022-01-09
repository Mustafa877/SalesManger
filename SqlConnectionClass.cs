using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace MySystem
{
    class SqlConnectionClass
    {
        
        public static SqlConnection cn = new SqlConnection(Properties.Settings.Default.cnSQL);

        public static void cnOpen()
        {
            if(cn.State==ConnectionState.Closed)
            {
                cn.Open();
            }

        }
        public static void cnClose()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public static string ConReturn()
        {
            return ("Data Source = MUSTAFAHAADDAD; Initial Catalog = theOne; Integrated Security = True");
        }
    }
}
