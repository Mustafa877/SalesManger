using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace MySystem
{
    public partial class info : KryptonForm
    {
        public info()
        {
            InitializeComponent();
            guna2HtmlToolTip1.SetToolTip(facebook, "بوك فيس");
            guna2HtmlToolTip1.SetToolTip(ins, "انستغرام");
            guna2HtmlToolTip1.SetToolTip(lin, "لينكد");
            guna2HtmlToolTip1.SetToolTip(ControlBox1, "أغلاق");
          
        }

        private void info_Load(object sender, EventArgs e)
        {

        }

        private void ControlBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void facebook_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100007794943667");
        }

        private void ins_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/mdev_87/");
        }

        private void lin_Click(object sender, EventArgs e)
        {System.Diagnostics.Process.Start("https://www.linkedin.com/in/mustafa-haddad-280aa2202");
           
        }
    }
    
}
