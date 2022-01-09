using MySystem;
using System;
using System.Data.SqlClient;

namespace POS_and_Inventory_System
{
    class DBConnection
    {
        SqlConnection con = new SqlConnection(MySystem.Properties.Settings.Default.cnSQL);
        SqlCommand cmd = new SqlCommand();

        private double dailySales;
        private int productLine;
        private int stockOnHand;
        private int critical;
        
        #region begins
        public double AllSales()
        {
          

            con.Open();
            string sql = "SELECT isnull(sum(total), 0) AS total FROM tbOrder ";
            cmd = new SqlCommand(sql, con);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return dailySales;
        }

        public int ProductLine()
        {
            
            con.Open();
            cmd = new SqlCommand("SELECT count(*) FROM tbOrder", con);
            productLine = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return productLine;
        }

        public int StockOnHand()
        {
           
            con.Open();
            cmd = new SqlCommand("SELECT isnull(sum(pqty),0) AS pqty FROM tbProduct", con);
            stockOnHand = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return stockOnHand;
        }

        public int coustomercount()
        {
           
            con.Open();
            cmd = new SqlCommand("SELECT count(*) FROM tbCustomer", con);
            critical = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return critical;
        }
        #endregion
        #region Sales-w/m/y
        public double All_week_Sales()
        {
            con.Open();
            string sql = "SELECT isnull(sum(total), 0) AS total FROM tbOrder GROUP BY DATEADD(week,1,odate)";
            cmd = new SqlCommand(sql, con);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return dailySales;
        }

        public int All_mounch_Sales()
        {
            SqlConnection conn = new SqlConnection(SqlConnectionClass.ConReturn());
            con.Open();
            cmd = new SqlCommand("SELECT isnull(sum(total), 0) AS total FROM tbOrder  GROUP BY month(odate)", con);
            productLine = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return productLine;
        }

        public int All_yers_Sales()
        {
             
            con.Open();
            cmd = new SqlCommand("SELECT isnull(sum(total), 0) AS total FROM tbOrder GROUP BY year(odate)", con);
            stockOnHand = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return stockOnHand;
        }
        #endregion
        #region olders-w/m/y

        public double All_week_older()
        {
           
            con.Open();
            string sql = "SELECT count(*)  FROM tbOrder GROUP BY DATEADD(week,1,odate) ";
            cmd = new SqlCommand(sql, con);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return dailySales;
        }

        public int All_mounch_older()
        {
            
            con.Open();
            cmd = new SqlCommand("SELECT count(*)  FROM tbOrder  GROUP BY month(odate)", con);
            productLine = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return productLine;
        }

        public int All_yers_older()
        {
            
            con.Open();
            cmd = new SqlCommand("SELECT count(*)  FROM tbOrder GROUP BY year(odate)", con);
            stockOnHand = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return stockOnHand;
        }
        #endregion
    }
}
