using AnimateDemo;
using DGVPrinterHelper;
using MySystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace MySystem
{
    public partial class OrderModuleForm :KryptonForm
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.cnSQL);
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        printpageout ff = new printpageout();
        printpage dd = new printpage();
        public OrderModuleForm()
        {

            InitializeComponent();
            LoadCustomer();
            LoadProduct();
            
           
        }
       
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        public void LoadCustomer()
        {
        
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT cid, cname FROM tbCustomer WHERE CONCAT(cid,cname) LIKE '%" + txtSearchCust.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void LoadProduct()
        {
           
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid, pname, pprice, pdescription, pcategory) LIKE '%" + txtSearchProd.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void UDQty_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if (txtCId.Text == "" & txtPid.Text == "")
            {
               // MessageBox.Show("ادخل معلومات اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(UDQty.Value) > qty)
            {

                UDQty.Value = UDQty.Value - 1;
                MessageBox.Show("لايوجد كميه كافيه في المخزن", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (Convert.ToInt32(UDQty.Value) > 0)
            {
              
                int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(UDQty.Value);
                txtTotal.Text = total.ToString();
                 

            }


        }

       private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                txtPid.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCId.Text == "")
                {
                    MessageBox.Show("اختر العميل رجاءا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPid.Text == "")
                {
                    MessageBox.Show("اختر الماده رجاءا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("هل انت متاكد من عمل هذا الطلب", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO tbOrder(odate, pid, cid, qty, price, total)VALUES(@odate, @pid, @cid, @qty, @price, @total)", con);
                    cm.Parameters.AddWithValue("@odate", dtOrder.Value);
                    cm.Parameters.AddWithValue("@pid", Convert.ToInt32(txtPid.Text));
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt32(txtCId.Text));
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt32(UDQty.Value));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt32(txtTotal.Text));
                   
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                   
                    MessageBox.Show("تم عمل الطلب بنجاح");
                   

                    cm = new SqlCommand("UPDATE tbProduct SET pqty=(pqty-@pqty) WHERE pid LIKE '"+ txtPid.Text +"' ", con);                    
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(UDQty.Value));
                    
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    getprintdate();
                    sumtotal();
                   // Clear();
                    LoadProduct();
                   

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void sumtotal()
        {
            int sum = 0;
            for (int i = 0; i < Printsenddpt.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(Printsenddpt.Rows[i].Cells["Column11"].Value);
            }
            totalext.Text = sum.ToString();
        }
        public void Clear()
        {
            txtCId.Text="";
            txtCName.Clear();

            txtPid.Clear();
            txtPName.Clear();

            txtPrice.Clear();
            UDQty.Value = 0;
            txtTotal.Clear();
            dtOrder.Value = DateTime.Now;
        }
        public void Clear2()
        {
            txtPid.Clear();
            txtPName.Clear();

            txtPrice.Clear();
            UDQty.Value = 0;
            txtTotal.Clear();
            dtOrder.Value = DateTime.Now;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();                        
        }
        private void printerbt()
        {
            printpage gg = new printpage();
            sumtotal();
            DGVPrinter printer = new  DGVPrinter();
            printer.Title = "\r\n\r\n\r\n نظام ميم لمبيعات \r\n\r\n";
           
            printer.SubTitle = "العراق ,النجف \r\n\r\n Phone: 07502680210 \r\n\r\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "\r\n" + "المجموع الكلي : " + totalext.Text + "\r\n\r\n" + "Thank you for doing business with us.";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(Printsenddpt);

            MessageBox.Show("تم الطباعة");
            totalext.Clear();
            //Celar the Data Grid View and Clear all the TExtboxes
            Printsenddpt.DataSource = null;
            Printsenddpt.Rows.Clear();

        }
        public void GetQty()
        {
            cm = new SqlCommand("SELECT pqty FROM tbProduct WHERE pid='"+ txtPid.Text +"'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void txtSearchProd_TextChanged_1(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void txtSearchCust_TextChanged_1(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        public void getprintdate()
        {
            Printsenddpt.Rows.Add( txtPName.Text, txtPrice.Text, UDQty.Value, txtTotal.Text, dtOrder.Value);
            ff.Printsenddpt.Rows.Add(txtPName.Text, txtPrice.Text, UDQty.Value, txtTotal.Text, dtOrder.Value);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            ff.totaltext.Text = totalext.Text;
            ff.idtext.Text = txtPid.Text;
            ff.palltext.Text = txtCName.Text;
            ff.guna2AnimateWindow1.AnimationType = (Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType)Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE;
           
           
            if (Printsenddpt.Rows.Count==0)
            {
                
                MessageBox.Show("يرجي عمل طلب اولا", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        else
            {

                ff.ShowDialog();
                totalext.Clear();
                Printsenddpt.DataSource = null;
                Printsenddpt.Rows.Clear();
                Clear2();
                MessageBox.Show("تم الطباعة");
            }
           
            
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void g(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.HOR_Positive);
      
        }

        private void totalext_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Printsenddpt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    } 
  
