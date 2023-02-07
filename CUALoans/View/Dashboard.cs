using CUALoans.Report;
using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class Dashboard : Form
    {
        public static string GetUser = "";
        private readonly Panel leftBorderBtn;
        private IconButton currentBtn;
        private Form currentMenuForm;


        public Dashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 44)
            };
            //  lbAppName.Text = "Assay Lab \n Management \n System";
            sidePanel.Controls.Add(leftBorderBtn);
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            //lbCright.Text = @"© Copyright  " + DateTime.Now.Year;
            timer1.Start();
        }

        private void HighlightButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableHighlight();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // current form icon
                iconcurrentForm.IconChar = currentBtn.IconChar;
                iconcurrentForm.IconColor = color;
                // current form label
                lbcurrentForm.Text = currentBtn.Text;
            }
        }

        private void DisableHighlight()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 32, 80);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenMenuForms(Form childForm)
        {
            currentMenuForm?.Close();
            currentMenuForm = childForm;
            childForm.TopLevel = false;
            frmLoaderPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }


        // Drag form
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to close the application", @"Confirm Exit Alams",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }


        private void PbGmcLogo_Click(object sender, EventArgs e)
        {
            currentMenuForm?.Close();
            DisableHighlight();
            leftBorderBtn.Visible = false;
            lbcurrentForm.Text = @"Home";
            iconcurrentForm.IconChar = IconChar.Home;
            iconcurrentForm.IconColor = Color.Gainsboro;
        }


        private void PlLine_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, plLine.ClientRectangle,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 1, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid);
        }

        private void FrmLoaderPanel_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, frmLoaderPanel.ClientRectangle,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 0, ButtonBorderStyle.Solid,
                Color.DodgerBlue, 1, ButtonBorderStyle.Solid);
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private struct MenuColors
        {
            public static readonly Color color1 = Color.FromArgb(117, 12, 174);
            public static readonly Color color2 = Color.FromArgb(146, 20, 12);
            public static readonly Color color3 = Color.FromArgb(247, 23, 53);
            public static readonly Color color4 = Color.FromArgb(77, 36, 61);
            public static readonly Color color5 = Color.FromArgb(255, 159, 28);
            public static readonly Color color6 = Color.FromArgb(30, 144, 255);
            public static readonly Color color7 = Color.FromArgb(0, 153, 0);
        }
        private void LbWelcome_Click(object sender, EventArgs e)
        {
           // lbLogout.Visible = lbLogout.Visible == false;
        }

        private void LbLogout_Click(object sender, EventArgs e)
        {
            lbLogout.Visible = false;
            //UserController.Logout(this);
        }

        private void PbJLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://jasbasoft.com");
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, MenuColors.color1);
            GetUser = lbUsername.Text;
            OpenMenuForms(new Members());
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, MenuColors.color2);
            GetUser = lbUsername.Text;

            OpenMenuForms(new Loans());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, MenuColors.color3);
            GetUser = lbUsername.Text;

            OpenMenuForms(new Payment());
        }

        private void btnContribute_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, MenuColors.color4);
            GetUser = lbUsername.Text;

            OpenMenuForms(new Contribution());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, MenuColors.color5);
            GetUser = lbUsername.Text;

            OpenMenuForms(new Withdrawal());
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, MenuColors.color6);
            GetUser = lbUsername.Text;

            OpenMenuForms(new Setup());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, MenuColors.color7);
            OpenMenuForms(new Reports());
        }


        private void btnActiveMem_Click(object sender, EventArgs e)
        {
            try
            {
                var rpt = new ActiveMembers();
                var mem = new MembersReport();
                rpt.Refresh();
                //rpt.SetParameterValue("@Fromdate", dtFrom.Text);
                //rpt.SetParameterValue("@Todate", dtTo.Text);
                mem.memRptViewer.RefreshReport();
                mem.memRptViewer.ReportSource = rpt;
                mem.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }
        }

        private void btnNonActiveMem_Click(object sender, EventArgs e)
        {
            
                var mem = new AllTransactionsReport();
                mem.ShowDialog();
        }

        private void btnContrib_Click(object sender, EventArgs e)
        {
            new ContributionReport().ShowDialog();
        }

        private void btnLoanRpts_Click(object sender, EventArgs e)
        {
            new LoanReport().ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new PaymentReport().ShowDialog();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            new WithdrawalReport().ShowDialog();
        }

        private void lbcurrentForm_Click(object sender, EventArgs e)
        {

        }
    }
}