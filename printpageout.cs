using MySystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using DGVPrinterHelper;

namespace MySystem
{
    public partial class printpageout : Form
    {
        // MemoryStream ms;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.cnSQL);
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bsource;
     

        // 

        public printpageout()
        {
            InitializeComponent();

            fillth();
           // guna2HtmlToolTip1.SetToolTip(closebox, "أغلاق");
            guna2HtmlToolTip1.SetToolTip(pictureBox2, "طباعة");
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
          
           print(this.panelprint);
            

        }
        
        public void clarer()
        {
            MAINTEXT.Text = "";
            addresstext.Text = "";
            phonetext.Text = "";
            pictureBox1.Image = null;

            //
        }
        public void fillth()
        {
            dadapter = new SqlDataAdapter("select * from imgt", con);
            dset = new DataSet();
            dadapter.Fill(dset);
            bsource = new BindingSource();
            bsource.DataSource = dset.Tables[0];
            MAINTEXT.DataBindings.Add(new Binding("Text", bsource, "mainN", true));
            addresstext.DataBindings.Add(new Binding("Text", bsource, "address", true));
            phonetext.DataBindings.Add(new Binding("Text", bsource, "number", true));
            pictureBox1.DataBindings.Add(new Binding("image", bsource, "img", true));

            con.Close();
        }
       
        private void printpageout_Load(object sender, EventArgs e)
        {

            OrderModuleForm FF = new OrderModuleForm();


            datetext.Text = FF.dtOrder.Text;
        }

        private void InsertInToDataBase(object value1, object value2, object value3, object value4)
        {
            throw new NotImplementedException();
        }

        private void addresstext_Paint(object sender, PaintEventArgs e)
        {

        }
        private void print(Panel pal)
        {
            PrinterSettings PS = new PrinterSettings();

            panelprint = pal;
            getprintarea(pal);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }
        private Bitmap memoryimg;
        

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));

           
        }
        private void panelprint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebox_Click(object sender, EventArgs e)
        {
            //OrderModuleForm FF = new OrderModuleForm();
            //FF.totalext.Clear();
            //Celar the Data Grid View and Clear all the TExtboxes
            //FF.Printsenddpt.DataSource = null;
            //FF.Printsenddpt.Rows.Clear();
            //FF.Clear();
        }

        private void idtext_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        { 
            
            Rectangle PrintPage = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (PrintPage.Width/2) - (this.panelprint.Width/2 ), this.panelprint.Location.Y);

            
              
           // e.Graphics.DrawImage(memoryimg, 0, 0);
        }

        private void kryptonLabel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Printsenddpt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MAINTEXT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Printsenddpt_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
