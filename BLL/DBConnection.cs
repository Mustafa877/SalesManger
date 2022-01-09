using System;
using System.Data.SqlClient;

namespace POS_and_Inventory_System
{
    class DBConnection
    {
        SqlConnection conn;
        SqlCommand cmd;
       // SqlDataReader dr;
        private double dailySales;
        private int productLine;
        private int stockOnHand;
        private int critical;
        string connString;

        public string MyConnection()
        {
            connString = @"Data Source=(local);Initial Catalog=tbpdate;Integrated Security=True";

     
            return connString;
        }
       
        #region sales/prodect/stock/co
        public double AllSales()
        {
           
            conn = new SqlConnection(MyConnection());
            conn.Open();
            string sql = "SELECT isnull(sum(total), 0) AS total FROM tbOrder";
            cmd = new SqlCommand(sql, conn);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return dailySales;
        }

        public int ProductLine()
        {
            conn = new SqlConnection(MyConnection());
            conn.Open();
            cmd = new SqlCommand("SELECT count(*) FROM tbOrder", conn);
            productLine = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return productLine;
        }

        public int StockOnHand()
        {
            conn = new SqlConnection(MyConnection());
            conn.Open();
            cmd = new SqlCommand("SELECT isnull(sum(pqty),0) AS pqty FROM tbProduct", conn);
            stockOnHand = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return stockOnHand;
        }

        public int coustomercount()
        {
            conn = new SqlConnection(MyConnection());
            conn.Open();
            cmd = new SqlCommand("SELECT count(*) FROM tbCustomer", conn);
            critical = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return critical;
        }
        #endregion
        #region for sales d/w/m/y

        public double All_week_Sales()
        {
           
            conn.Open();
            string sql = "SELECT  isnull(sum(total), 0) FROM tbOrder GROUP BY datepart(wk ,odate)";
            cmd = new SqlCommand(sql, conn);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return dailySales;
        }
        public double All_mounch_Sales()
        {
            string sdate = DateTime.Now.ToShortDateString();
            conn = new SqlConnection(MyConnection());
            conn.Open();

            string sql = "SELECT isnull(sum(total), 0) AS total FROM tbOrder GROUP BY month(odate)";
            cmd = new SqlCommand(sql, conn);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return dailySales;
        }
        public double All_yers_Sales()
        {
            string sdate = DateTime.Now.ToShortDateString();
            conn = new SqlConnection(MyConnection());
            conn.Open();
            string sql = "SELECT isnull(sum(total), 0) AS total FROM tbOrder GROUP BY year(odate)";
            cmd = new SqlCommand(sql, conn);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return dailySales;
        }
        #endregion
        #region olderds
        public double All_week_older()
        {

            conn.Open();
            string sql = "SELECT count(*) FROM tbOrder GROUP BY datepart(wk ,odate)";
            cmd = new SqlCommand(sql, conn);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return dailySales;
        }
        public double All_mounch_older()
        {
            string sdate = DateTime.Now.ToShortDateString();
            conn = new SqlConnection(MyConnection());
            conn.Open();

            string sql = "SELECT count(*) FROM tbOrder GROUP BY month(odate)";
            cmd = new SqlCommand(sql, conn);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return dailySales;
        }
        public double All_yers_older()
        {
            string sdate = DateTime.Now.ToShortDateString();
            conn = new SqlConnection(MyConnection());
            conn.Open();
            string sql = "SELECT count(*) FROM tbOrder GROUP BY year(odate)";
            cmd = new SqlCommand(sql, conn);
            dailySales = double.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return dailySales;
        }
        #endregion


    }
}
