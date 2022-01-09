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
using System.Windows.Media;
using ComponentFactory.Krypton.Toolkit;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MySystem.Properties;
using POS_and_Inventory_System;
using Brushes = System.Windows.Media.Brushes;

namespace MySystem
{
    public partial class MainForm : KryptonForm
    {
        DBConnection dbconn = new DBConnection();
        SqlConnection con = new SqlConnection(Properties.Settings.Default.cnSQL);
        SqlCommand cm = new SqlCommand();
        public MainForm()
        {
            InitializeComponent();
            numetag.Text = Properties.Settings.Default.userName;
     
        }

        //to show subform form in mainform
       public Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            p1.Visible = false;
            c1.Visible = false;
            co1.Visible = false;
            u1.Visible = true;
            o1.Visible = false;
            openChildForm(new UserForm());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            p1.Visible = false;
            c1.Visible = true;
            co1.Visible = false;
            u1.Visible = false;
            o1.Visible = false;
            openChildForm(new CustomerForm());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
           p1.Visible = false;
           c1.Visible = false;
           co1.Visible = true;
           u1.Visible = false;
           o1.Visible = false;
            openChildForm(new CategoryForm());
             
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
           p1.Visible = true;
           c1.Visible = false;
           co1.Visible = false;
           u1.Visible = false;
           o1.Visible = false;
            openChildForm(new ProductForm());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            p1.Visible = false;
            c1.Visible = false;
            co1.Visible = false;
            u1.Visible = false;
            o1.Visible = true;
            openChildForm(new OrderForm());
            
        }
        public void ss()
        {
            
            ALLsalesLB.Text = dbconn.AllSales().ToString("#,##0.00");
            ALLolderLB.Text = dbconn.ProductLine().ToString("#,##0.00");
            ALLonstoukLB.Text = dbconn.StockOnHand().ToString("#,##0.00");
            ALLcustomerLB.Text = dbconn.coustomercount().ToString("#,##0.00");
        }
 
        public void MainForm_Load(object sender, EventArgs e)
        {
            p1.Visible = false;
            c1.Visible = false;
            co1.Visible = false;
            u1.Visible = false;
            o1.Visible = false;

            chart.Visible = false;
            btdays.Visible = false;
            ss();
            chartstart();
            chart.AxisX.Add(new Axis
            {
                Title = "احصاء المبيعات",

                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
            });
            chart.AxisY.Add(new Axis
            {
                Title = "الربح",

                LabelFormatter = value => value.ToString("c"),
            });
        }
        public void chartstart()
        {
            #region sales if empty
            chart.LegendLocation = LiveCharts.LegendLocation.Right;
            if (ALLsalesLB.Text == "0.00")
            {
                chart.Series.Clear();
                chart.Series.Add(new LineSeries
                {

                    Title = ALLsalesLB.Text,

                    // Values = new ChartValues<double> { 0, 0, 0, 0, 0, 0 },

                    StrokeThickness = 2,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 124, 49)),
                    PointGeometrySize = 15,
                    PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

                });
                chart.Series.Add(new LineSeries
                {
                    Title = ALLolderLB.Text,

                    //Values = new ChartValues<double> { 0, 0, 0, 0, 0, 0 },

                    StrokeThickness = 2,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 79)),
                    PointGeometrySize = 15,
                    PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

                });
            }
            else
            {
                #endregion
            #region chart in main form

                chart.Series.Clear();
                chart.Series.Add(new LineSeries
                {

                    Title = ALLsalesLB.Text,

                    Values = new ChartValues<double> { 3, 5, 7, 4, 9, 5 },

                    StrokeThickness = 2,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 124, 49)),
                    PointGeometrySize = 15,
                    PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

                });

                chart.Series.Add(new LineSeries
                {
                    Title = ALLolderLB.Text,

                    Values = new ChartValues<double> { 5, 6, 2, 7, 5, 7 },

                    StrokeThickness = 2,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 79)),
                    PointGeometrySize = 15,
                    PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

                });
            }
            #endregion
        }
        private void btnMainM_Click(object sender, EventArgs e)
        {
            
           p1.Visible = false;
           c1.Visible = false;
           co1.Visible = false;
           u1.Visible = false;
           o1.Visible = false;
            chartstart();
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            ss();
            
        }

        private void Mainbt(object sender, EventArgs e)
        {
            chart.Visible = false;
            backgbt.Visible = true;
            btdays.Visible = false;
        }

        private void chartbt(object sender, EventArgs e)
        {
            chart.Visible = true;
            backgbt.Visible = false;
            btdays.Show();
        }

        private void calender_bt(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("outlookcal:");
        }

        private void calcuter_bt(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");

        }

        private void sawech_uers(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تبديل حسابك؟", "اشعار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                LoginForm log = new LoginForm();
                log.Show();
            }
        }

        private void logOut_bt(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اغلاق البرنامج؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                
            }
        }

        private void weekdpt_Click(object sender, EventArgs e)
        {
          
            if (ALLsalesLB.Text == "0.00")
            {
                MessageBox.Show(" رجاءا اعمل طلب اولا", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ALLolderLB.Text = dbconn.All_week_older().ToString("#,##0.00");
                ALLsalesLB.Text = dbconn.All_week_Sales().ToString("#,##0.00");
           
            #region for chart
            chart.Series.Clear();
            chart.Series.Add(new LineSeries
            {

                Title = ALLsalesLB.Text,

                Values = new ChartValues<double> { 4, 6, 5, 2, 4, 13, 11 },

                StrokeThickness = 2,
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 124, 49)),
                PointGeometrySize = 15,
                PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

            });
            chart.Series.Add(new LineSeries
            {
                Title = ALLolderLB.Text,

                Values = new ChartValues<double> { 1, 7, 3, 4, 6, 12, 13 },

                StrokeThickness = 2,
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 79)),
                PointGeometrySize = 15,
                PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

            });
                #endregion
            }
        }

        private void mounchdpt_Click(object sender, EventArgs e)
        {
            if (ALLsalesLB.Text == "0.00")
            {
                MessageBox.Show("رجاءا اعمل طلب اولا", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ALLolderLB.Text = dbconn.All_mounch_older().ToString("#,##0.00");
                ALLsalesLB.Text = dbconn.All_mounch_Sales().ToString("#,##0.00");
            
           
            #region for chart
            chart.Series.Clear();
            chart.Series.Add(new LineSeries
            {

                Title = ALLsalesLB.Text,
                Values = new ChartValues<double> { 1, 13, 6, 9, 6, 5, 4 },
                StrokeThickness = 2,
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 124, 49)),
                PointGeometrySize = 15,
                PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

            });
            chart.Series.Add(new LineSeries
            {
                Title = ALLolderLB.Text,                                        
                Values = new ChartValues<double> { 4, 12, 6, 8, 3, 7, 6 },
                StrokeThickness = 2,
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 79)),
                PointGeometrySize = 15,
                PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

            });
                #endregion
            }
        }


        private void yersdpt_Click(object sender, EventArgs e)
        {
            if (ALLsalesLB.Text == "0.00")
            {
                MessageBox.Show("رجاءا اعمل طلب اولا", "اشعار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                ALLolderLB.Text = dbconn.All_yers_older().ToString("#,##0.00");
                ALLsalesLB.Text = dbconn.All_yers_Sales().ToString("#,##0.00");

           
            #region for chart
            chart.Series.Clear();
            chart.Series.Add(new LineSeries
            {

                Title = ALLsalesLB.Text,
                Values = new ChartValues<double> { 4, 2, 7, 2, 7, 9, 8 },
                StrokeThickness = 2,
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 124, 49)),
                PointGeometrySize = 15,
                PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

            });
            chart.Series.Add(new LineSeries
            {
                Title = ALLolderLB.Text,
                Values = new ChartValues<double> { 1, 5, 3, 7, 9, 8, 6 },
                StrokeThickness = 2,
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 79)),
                PointGeometrySize = 15,
                PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 252, 252)),

            });
            #endregion
        }
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btdays_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void customerButton8_Click(object sender, EventArgs e)
        { 
            printpage FF = new printpage();
          
            FF.ShowDialog();
        }

        private void customerButton9_Click(object sender, EventArgs e)
        {
            info FF = new info();
            FF.annme1.AnimationType = (Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType)Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
           
            FF.ShowDialog();
        }

        private void odb_Paint(object sender, PaintEventArgs e)
        {

        }

        private void co1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
