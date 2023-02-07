using CUALoans.Controller;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace CUALoans.View
{
    public partial class Login : Form
    {
        private readonly Dashboard _db = new Dashboard();

        private readonly UserController _user = new UserController();
        private const string KLibraryKey = "693B5EBA090436BD4D1B9E0C0233B219E8DDCA9D56366EE0DAACB1402DFD454F0189FA2D4030";

        public Login()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            lbCopyRight.Text = @"© Copy right  " + DateTime.Now.Year + @".  Developed By ";
            timer1.Start();
            dgvLogin.DataSource = UserController.GetUsers();

            // We launch the trial UI on a thread because we want the trial UI to be
            // displayed after you main application UI is displayed.
            Thread thread = new Thread(InitTrial);
            //  thread.Start();
        }

        // Main trial function
        // This function does all the work
        //
        // @return
        // - 0 when licensed
        // - 2 when unlicensed but in trial
        [DllImport("Trial.dll", EntryPoint = "ReadSettingsStr", CharSet = CharSet.Ansi)]
        private static extern uint InitTrial(String aKeyCode, IntPtr aHWnd);

        // This function does all the work but it will NOT kill the application
        //
        // @return
        // - 0 when licensed
        // - 2 when unlicensed but in trial
        // - values grater or equal with 4 when unlicensed and trial expired
        [DllImport("Trial.dll", EntryPoint = "ReadSettingsRetStr", CharSet = CharSet.Ansi)]
        private static extern uint InitTrialReturn(String aKeyCode, IntPtr aHWnd);

        // Use this function to register the application using the provided serial
        [DllImport("Trial.dll", EntryPoint = "DisplayRegistrationStr", CharSet = CharSet.Ansi)]
        private static extern uint DisplayRegistration(String aKeyCode, IntPtr aHWnd);

        [DllImport("Trial.dll", EntryPoint = "GetPropertyValue", CharSet = CharSet.Unicode)]
        private static extern uint GetPropertyValue(String aPropName, StringBuilder aResult, ref UInt32 aResultLen);


        private static void InitTrial()
        {
            try
            {
                // Wait 2 second for the main window to be visible.
                Thread.Sleep(2000);

                Debug.WriteLine("Debug Information-Product Starting ");

                Process process = Process.GetCurrentProcess();
                InitTrial(KLibraryKey, process.MainWindowHandle);

                // To prevent your application be killed when unlicensed and trial expired
                // ReadSettingsRetStr must be called which will return 4 or grater instead of killing the app
                //
                //         uint ret = InitTrialReturn(kLibraryKey, process.MainWindowHandle);
                //
                //         if (ret >= 4)
                //         {
                //           MessageBox.Show("Invalid mode to run");
                //           // disable the application
                //           // Process.GetCurrentProcess().Kill();
                //         }

                // Let's read some licensing configuration property
                StringBuilder trialName = new StringBuilder();
                UInt32 len = (UInt32)trialName.Capacity;
                if (GetPropertyValue("TrialName", trialName, ref len) == 234)
                {
                    trialName.EnsureCapacity((Int32)len);
                    GetPropertyValue("TrialName", trialName, ref len);
                }

                Debug.WriteLine("TrialName=" + trialName);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void LinkToJasbasoft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jasbasoft.com");
        }

        private void Logon()
        {
            if (_user.Login(txtUsername.Text, txtPassword.Text))
            {
                _db.lbWelcome.Text = @"Welcome  " + txtUsername.Text;
                _db.lbUsername.Text = txtUsername.Text;

                Hide();
                _db.ShowDialog();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Logon();
            // new Dashboard().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Logon();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LbForgot_Click(object sender, EventArgs e)
        {
            // new ChangePassword().ShowDialog();
        }
    }
}