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
    public partial class LoginForm :KryptonForm
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.cnSQL);
      
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtName.Clear();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                cm.Parameters.AddWithValue("@username", txtPass.Text);
                cm.Parameters.AddWithValue("@password", txtName.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show( dr["fullname"].ToString() +"  "+ "مرحبا ", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    this.Hide();
                    main.annme1.AnimationType = (Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType)Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
                    main.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة", "منع الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.userName != string.Empty)
            {
                txtName.Text = Properties.Settings.Default.userName;
                txtPass.Text = Properties.Settings.Default.passUser;
            }

        }
        private void REMBER1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass1.Checked == true)
            {
                Properties.Settings.Default.userName = txtName.Text;
                Properties.Settings.Default.passUser = txtPass.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.userName = "";
                Properties.Settings.Default.passUser = "";
                Properties.Settings.Default.Save();
            }
           
        }

        private void checkBoxPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;

            }
            else
            {
                txtPass.UseSystemPasswordChar = true;

            }
        }

    }
}
