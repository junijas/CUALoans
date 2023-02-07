using System;
using System.Drawing;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class Setup : Form
    {
        private Button currentBtn;

        public Setup()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            viewsHolderPanel.Controls.Clear();
            viewsHolderPanel.Controls.Add(c);
        }

        private void BtnAddDept_Click(object sender, EventArgs e)
        {
            HighlightButton(sender);
            // AddControlsToPanel(new Department());
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(0, 32, 80);
            HighlightButton(sender);
            //  AddControlsToPanel(new Client());
        }

        private void HighlightButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableHighlight();

                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.Green;
            }
        }

        private void DisableHighlight()
        {
            if (currentBtn != null) currentBtn.BackColor = Color.FromArgb(0, 32, 80);
        }


        private void BtnSample_Click(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.FromArgb(0, 32, 80);
            HighlightButton(sender);
            //AddControlsToPanel(new Sample());
        }
    }
}