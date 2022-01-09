using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*add references here :*/
using System.Runtime.InteropServices;
using System.Diagnostics;
using MySystem;

namespace TrialApplication
{
    public partial class Form1 : Form
    {

        #region Trial Section :
        // This function does all the work
        [DllImport("TrialApp.dll", EntryPoint = "ReadSettingsStr", CharSet = CharSet.Ansi)]
        static extern uint InitTrial(String aKeyCode, IntPtr aHWnd);

        // Use this function to register the application when the application is running
        [DllImport("TrialApp.dll", EntryPoint = "DisplayRegistrationStr", CharSet = CharSet.Ansi)]
        static extern uint DisplayRegistration(String aKeyCode, IntPtr aHWnd);

        // The kLibraryKey is meant to prevent unauthorized use of the library.
        // Do not share this key. Replace this key with your own from Advanced Installer 
        // project > Licensing > Registration > Library Key
        private const string kLibraryKey = "2CF2A7F3C869CB27A7F608E687C70CF03DE841C84D10D3B83F1AE5A1439E395783BFF497A54F";

        private static void OnInit()
        {
            try
            {
                Process process = Process.GetCurrentProcess();
                InitTrial(kLibraryKey, process.MainWindowHandle);
            }
            catch (DllNotFoundException ex)
            {
                // Trial dll is missing close the application immediately.
                MessageBox.Show(ex.ToString());
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }
        }

        private void RegisterApp()
        {
            try
            {
                Process process = Process.GetCurrentProcess();
                DisplayRegistration(kLibraryKey, process.MainWindowHandle);
                WelcomeForm g = new WelcomeForm();
                g.ShowDialog();
                this.Close();
                
            }
            catch (DllNotFoundException ex)
            {
                // Trial dll is missing close the application immediately.
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }
        }
        #endregion

        

        public Form1()
        {
            InitializeComponent(); 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnInit();
            if (!BGW.IsBusy)
                BGW.RunWorkerAsync();
            RegisterApp();
           
        }

        #region Background Tasks :
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        private void BGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Text = "Trial Application";
        }
        #endregion
    }
}
