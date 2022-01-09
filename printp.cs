using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem.Properties
{
    public partial class printpage : Form
    {
        MemoryStream ms;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.cnSQL);
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bsource;
        public Image IMG ;
        public string date,address,number,menyn;
        public printpage()
        {
            InitializeComponent();
            SAVETEXT.Enabled = false;
            btupdate.Enabled = false;
        }
        public void uploadimg()
        {
            
            try
            {
                openFileDialog1.Filter = "JPG FILES(*.jpg)|*.jpg|PNG FILES(*.png)|*.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error canot ubload. \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            IMG =pictureBox1.Image  ;
            dadapter = new SqlDataAdapter("select * from imgt", con);
            dset = new DataSet();
            dadapter.Fill(dset);
            bsource = new BindingSource();
            bsource.DataSource = dset.Tables[0];
            txtName.DataBindings.Add(new Binding("Text", bsource, "mainN", true));
            addresstext.DataBindings.Add(new Binding("Text", bsource, "address", true));
            phonetext.DataBindings.Add(new Binding("Text", bsource, "number", true));
            pictureBox1.DataBindings.Add(new Binding("image", bsource, "img", true));
            sfus();

        }
        public void sfus()
        {

            if (phonetext.Text == "" & txtName.Text == "" & addresstext.Text == "")
            {
                SAVETEXT.Enabled = true;
               
            }
            else

            {
                btupdate.Enabled = true;
               
            }
           
        }
        private void btupdate_Click(object sender, EventArgs e)
        {
            if (phonetext.Text == "" & txtName.Text == "" & addresstext.Text == "")
            {
                MessageBox.Show("يرجى ادخال معلومات اولا");
            }
            else
            {
                cm = new SqlCommand("UPDATE imgt SET number = @number,mainN=@mainN,nameP=@nameP,address=@address ,img=@img", con);
                cm.Parameters.AddWithValue("@number", phonetext.Text);
                cm.Parameters.AddWithValue("@mainN", txtName.Text);
                cm.Parameters.AddWithValue("@nameP", addresstext.Text);
                cm.Parameters.AddWithValue("@address", addresstext.Text);
                conv_photo();
                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم تحديث المعلومات بنجاح");
            }
        }
        //upload img to date
        public void conv_photo()
        {
            if (pictureBox1.Image != null)
            { 
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Png);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cm.Parameters.AddWithValue("@img", photo_aray);
            }
            else
            {
                MessageBox.Show("ادخل صورة اولا");

            }

        }
        private void SAVETEXT_Click(object sender, EventArgs e)
        {
            if (phonetext.Text == "" & txtName.Text == "" & addresstext.Text == "")
            {
                MessageBox.Show("يرجى ادخال معلومات اولا");
                return;
            }
            try
            {
                if (MessageBox.Show("هل انت متاكد من حفظ المعلومات ؟", "اشعار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO imgt(number,mainN,nameP,address,img)VALUES(@number,@mainN,@nameP,@address,@img)", con);
                    cm.Parameters.AddWithValue("@number", phonetext.Text);
                    cm.Parameters.AddWithValue("@mainN", txtName.Text);
                    cm.Parameters.AddWithValue("@nameP", addresstext.Text);
                    cm.Parameters.AddWithValue("@address", addresstext.Text);
                    conv_photo();
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم حفظ المعلومات بنجاح");


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
   
        }
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            uploadimg();
        }

        

        private void datetext1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
