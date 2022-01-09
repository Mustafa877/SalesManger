using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using TrialApplication;

namespace MySystem
{
    public partial class WelcomeForm : KryptonForm
    {
       
        public WelcomeForm()
        {
            InitializeComponent();
            timer1.Start();
           


        }
      
            int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)

        {
            
            startPoint += 5;
            progressBar1.Value = startPoint;
            if (progressBar1.Value == 100)
            {
               
                progressBar1.Value = 0;
                timer1.Stop();
                this.Hide();
                LoginForm login = new LoginForm();

                login.guna2AnimateWindow1.AnimationType = (Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType)Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;

                login.ShowDialog();

            } 
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
