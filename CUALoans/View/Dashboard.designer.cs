namespace CUALoans.View
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnSetup = new FontAwesome.Sharp.IconButton();
            this.btnWithdraw = new FontAwesome.Sharp.IconButton();
            this.btnContribute = new FontAwesome.Sharp.IconButton();
            this.btnPayments = new FontAwesome.Sharp.IconButton();
            this.btnLoans = new FontAwesome.Sharp.IconButton();
            this.btnMembers = new FontAwesome.Sharp.IconButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.lbAppName = new System.Windows.Forms.Label();
            this.pbGmcLogo = new System.Windows.Forms.PictureBox();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbcurrentForm = new System.Windows.Forms.Label();
            this.iconcurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plLine = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.frmLoaderPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnContrib = new System.Windows.Forms.Button();
            this.btnNonActiveMem = new System.Windows.Forms.Button();
            this.btnActiveMem = new System.Windows.Forms.Button();
            this.btnLoanRpts = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGmcLogo)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentForm)).BeginInit();
            this.plLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.frmLoaderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.sidePanel.Controls.Add(this.btnReports);
            this.sidePanel.Controls.Add(this.btnSetup);
            this.sidePanel.Controls.Add(this.btnWithdraw);
            this.sidePanel.Controls.Add(this.btnContribute);
            this.sidePanel.Controls.Add(this.btnPayments);
            this.sidePanel.Controls.Add(this.btnLoans);
            this.sidePanel.Controls.Add(this.btnMembers);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(19, 5, 4, 5);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(315, 882);
            this.sidePanel.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReports.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnReports.IconColor = System.Drawing.Color.White;
            this.btnReports.IconSize = 34;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 720);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnReports.Rotation = 0D;
            this.btnReports.Size = new System.Drawing.Size(315, 68);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Statement";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSetup.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold);
            this.btnSetup.ForeColor = System.Drawing.Color.White;
            this.btnSetup.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSetup.IconColor = System.Drawing.Color.White;
            this.btnSetup.IconSize = 34;
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(0, 652);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnSetup.Rotation = 0D;
            this.btnSetup.Size = new System.Drawing.Size(315, 68);
            this.btnSetup.TabIndex = 7;
            this.btnSetup.Text = "Settings";
            this.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnWithdraw.IconColor = System.Drawing.Color.White;
            this.btnWithdraw.IconSize = 34;
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(0, 584);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnWithdraw.Rotation = 0D;
            this.btnWithdraw.Size = new System.Drawing.Size(315, 68);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Withdrawals";
            this.btnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnContribute
            // 
            this.btnContribute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContribute.FlatAppearance.BorderSize = 0;
            this.btnContribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContribute.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnContribute.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold);
            this.btnContribute.ForeColor = System.Drawing.Color.White;
            this.btnContribute.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnContribute.IconColor = System.Drawing.Color.White;
            this.btnContribute.IconSize = 34;
            this.btnContribute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContribute.Location = new System.Drawing.Point(0, 516);
            this.btnContribute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContribute.Name = "btnContribute";
            this.btnContribute.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnContribute.Rotation = 0D;
            this.btnContribute.Size = new System.Drawing.Size(315, 68);
            this.btnContribute.TabIndex = 5;
            this.btnContribute.Text = "Contributions";
            this.btnContribute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContribute.UseVisualStyleBackColor = true;
            this.btnContribute.Click += new System.EventHandler(this.btnContribute_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPayments.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnPayments.IconColor = System.Drawing.Color.White;
            this.btnPayments.IconSize = 34;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(0, 448);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnPayments.Rotation = 0D;
            this.btnPayments.Size = new System.Drawing.Size(315, 68);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Loan Payments";
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnLoans
            // 
            this.btnLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoans.FlatAppearance.BorderSize = 0;
            this.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoans.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLoans.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoans.ForeColor = System.Drawing.Color.White;
            this.btnLoans.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnLoans.IconColor = System.Drawing.Color.White;
            this.btnLoans.IconSize = 34;
            this.btnLoans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoans.Location = new System.Drawing.Point(0, 380);
            this.btnLoans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnLoans.Rotation = 0D;
            this.btnLoans.Size = new System.Drawing.Size(315, 68);
            this.btnLoans.TabIndex = 2;
            this.btnLoans.Text = "Loans";
            this.btnLoans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoans.UseVisualStyleBackColor = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnMembers.IconColor = System.Drawing.Color.White;
            this.btnMembers.IconSize = 34;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(0, 312);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(19, 5, 4, 5);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnMembers.Rotation = 0D;
            this.btnMembers.Size = new System.Drawing.Size(315, 68);
            this.btnMembers.TabIndex = 1;
            this.btnMembers.Text = "Members";
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.logoPanel.Controls.Add(this.lbAppName);
            this.logoPanel.Controls.Add(this.pbGmcLogo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(315, 312);
            this.logoPanel.TabIndex = 0;
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbAppName.Location = new System.Drawing.Point(68, 32);
            this.lbAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(183, 74);
            this.lbAppName.TabIndex = 2;
            this.lbAppName.Text = "Credit Union\r\nAssociation";
            this.lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbGmcLogo
            // 
            this.pbGmcLogo.Image = global::CUALoans.Properties.Resources.cua_logo;
            this.pbGmcLogo.Location = new System.Drawing.Point(45, 120);
            this.pbGmcLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbGmcLogo.Name = "pbGmcLogo";
            this.pbGmcLogo.Size = new System.Drawing.Size(216, 142);
            this.pbGmcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGmcLogo.TabIndex = 0;
            this.pbGmcLogo.TabStop = false;
            this.pbGmcLogo.Click += new System.EventHandler(this.PbGmcLogo_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.footerPanel.Controls.Add(this.lbTime);
            this.footerPanel.Controls.Add(this.lbDate);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(315, 837);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.footerPanel.Size = new System.Drawing.Size(1065, 45);
            this.footerPanel.TabIndex = 1;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTime.Location = new System.Drawing.Point(972, 8);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(85, 29);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "label1";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDate.Location = new System.Drawing.Point(8, 8);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(85, 29);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "label1";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Controls.Add(this.tableLayoutPanel1);
            this.headerPanel.Controls.Add(this.lbcurrentForm);
            this.headerPanel.Controls.Add(this.iconcurrentForm);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(315, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1065, 82);
            this.headerPanel.TabIndex = 2;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLogout);
            this.panel1.Controls.Add(this.lbWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(603, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 82);
            this.panel1.TabIndex = 1;
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.Red;
            this.lbLogout.Location = new System.Drawing.Point(125, 49);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(93, 29);
            this.lbLogout.TabIndex = 1;
            this.lbLogout.Text = "Logout";
            this.lbLogout.Visible = false;
            this.lbLogout.Click += new System.EventHandler(this.LbLogout_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbWelcome.Font = new System.Drawing.Font("Lucida Calligraphy", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.Lime;
            this.lbWelcome.Location = new System.Drawing.Point(9, 12);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(217, 32);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Welcome User";
            this.lbWelcome.Click += new System.EventHandler(this.LbWelcome_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Controls.Add(this.btnRestore, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMinimize, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(903, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 82);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(55, 5);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(49, 41);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "[-]";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(4, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 41);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-----";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(112, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lbcurrentForm
            // 
            this.lbcurrentForm.AutoSize = true;
            this.lbcurrentForm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcurrentForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbcurrentForm.Location = new System.Drawing.Point(68, 20);
            this.lbcurrentForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcurrentForm.Name = "lbcurrentForm";
            this.lbcurrentForm.Size = new System.Drawing.Size(109, 34);
            this.lbcurrentForm.TabIndex = 1;
            this.lbcurrentForm.Text = "Reports";
            this.lbcurrentForm.Click += new System.EventHandler(this.lbcurrentForm_Click);
            // 
            // iconcurrentForm
            // 
            this.iconcurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.iconcurrentForm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconcurrentForm.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconcurrentForm.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconcurrentForm.IconSize = 48;
            this.iconcurrentForm.Location = new System.Drawing.Point(9, 12);
            this.iconcurrentForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconcurrentForm.Name = "iconcurrentForm";
            this.iconcurrentForm.Size = new System.Drawing.Size(48, 49);
            this.iconcurrentForm.TabIndex = 0;
            this.iconcurrentForm.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Lucida Calligraphy", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Lime;
            this.lbUsername.Location = new System.Drawing.Point(267, 8);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(217, 32);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Welcome User";
            this.lbUsername.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // plLine
            // 
            this.plLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.plLine.Controls.Add(this.label4);
            this.plLine.Controls.Add(this.iconPictureBox1);
            this.plLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.plLine.Location = new System.Drawing.Point(315, 82);
            this.plLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plLine.Name = "plLine";
            this.plLine.Size = new System.Drawing.Size(1065, 15);
            this.plLine.TabIndex = 4;
            this.plLine.Paint += new System.Windows.Forms.PaintEventHandler(this.PlLine_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(68, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Job Book";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconPictureBox1.IconSize = 48;
            this.iconPictureBox1.Location = new System.Drawing.Point(9, 19);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(48, 49);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmLoaderPanel
            // 
            this.frmLoaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.frmLoaderPanel.Controls.Add(this.panel2);
            this.frmLoaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmLoaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLoaderPanel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.frmLoaderPanel.Location = new System.Drawing.Point(315, 97);
            this.frmLoaderPanel.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.frmLoaderPanel.Name = "frmLoaderPanel";
            this.frmLoaderPanel.Size = new System.Drawing.Size(1065, 740);
            this.frmLoaderPanel.TabIndex = 5;
            this.frmLoaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmLoaderPanel_Paint_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(199, 200, 199, 200);
            this.panel2.Size = new System.Drawing.Size(1065, 740);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.btnContrib, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNonActiveMem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActiveMem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLoanRpts, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnPayment, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnWithdrawal, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(199, 200);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(667, 340);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnContrib
            // 
            this.btnContrib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnContrib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContrib.FlatAppearance.BorderSize = 5;
            this.btnContrib.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnContrib.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnContrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContrib.Location = new System.Drawing.Point(452, 14);
            this.btnContrib.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnContrib.Name = "btnContrib";
            this.btnContrib.Size = new System.Drawing.Size(201, 130);
            this.btnContrib.TabIndex = 2;
            this.btnContrib.Text = "Contributions";
            this.btnContrib.UseVisualStyleBackColor = false;
            this.btnContrib.Click += new System.EventHandler(this.btnContrib_Click);
            // 
            // btnNonActiveMem
            // 
            this.btnNonActiveMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnNonActiveMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNonActiveMem.FlatAppearance.BorderSize = 5;
            this.btnNonActiveMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnNonActiveMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnNonActiveMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonActiveMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonActiveMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNonActiveMem.Location = new System.Drawing.Point(233, 14);
            this.btnNonActiveMem.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnNonActiveMem.Name = "btnNonActiveMem";
            this.btnNonActiveMem.Size = new System.Drawing.Size(199, 130);
            this.btnNonActiveMem.TabIndex = 1;
            this.btnNonActiveMem.Text = "All Transactions";
            this.btnNonActiveMem.UseVisualStyleBackColor = false;
            this.btnNonActiveMem.Click += new System.EventHandler(this.btnNonActiveMem_Click);
            // 
            // btnActiveMem
            // 
            this.btnActiveMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnActiveMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActiveMem.FlatAppearance.BorderSize = 5;
            this.btnActiveMem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnActiveMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnActiveMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiveMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActiveMem.Location = new System.Drawing.Point(14, 14);
            this.btnActiveMem.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnActiveMem.Name = "btnActiveMem";
            this.btnActiveMem.Size = new System.Drawing.Size(199, 130);
            this.btnActiveMem.TabIndex = 0;
            this.btnActiveMem.Text = "Members";
            this.btnActiveMem.UseVisualStyleBackColor = false;
            this.btnActiveMem.Click += new System.EventHandler(this.btnActiveMem_Click);
            // 
            // btnLoanRpts
            // 
            this.btnLoanRpts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnLoanRpts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoanRpts.FlatAppearance.BorderSize = 5;
            this.btnLoanRpts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnLoanRpts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnLoanRpts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanRpts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanRpts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoanRpts.Location = new System.Drawing.Point(14, 195);
            this.btnLoanRpts.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnLoanRpts.Name = "btnLoanRpts";
            this.btnLoanRpts.Size = new System.Drawing.Size(199, 131);
            this.btnLoanRpts.TabIndex = 9;
            this.btnLoanRpts.Text = "Loans";
            this.btnLoanRpts.UseVisualStyleBackColor = false;
            this.btnLoanRpts.Click += new System.EventHandler(this.btnLoanRpts_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPayment.FlatAppearance.BorderSize = 5;
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.Location = new System.Drawing.Point(233, 195);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(199, 131);
            this.btnPayment.TabIndex = 10;
            this.btnPayment.Text = "Payments";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnWithdrawal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWithdrawal.FlatAppearance.BorderSize = 5;
            this.btnWithdrawal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnWithdrawal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnWithdrawal.Location = new System.Drawing.Point(452, 195);
            this.btnWithdrawal.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(201, 131);
            this.btnWithdrawal.TabIndex = 8;
            this.btnWithdrawal.Text = "Withdrawals";
            this.btnWithdrawal.UseVisualStyleBackColor = false;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 882);
            this.ControlBox = false;
            this.Controls.Add(this.frmLoaderPanel);
            this.Controls.Add(this.plLine);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.sidePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 735);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.sidePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGmcLogo)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentForm)).EndInit();
            this.plLine.ResumeLayout(false);
            this.plLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.frmLoaderPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel logoPanel;
        private FontAwesome.Sharp.IconButton btnContribute;
        private FontAwesome.Sharp.IconButton btnPayments;
        private FontAwesome.Sharp.IconButton btnLoans;
        private FontAwesome.Sharp.IconButton btnMembers;
        private FontAwesome.Sharp.IconButton btnWithdraw;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lbcurrentForm;
        private FontAwesome.Sharp.IconPictureBox iconcurrentForm;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbGmcLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plLine;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel frmLoaderPanel;
        private System.Windows.Forms.Label lbAppName;
        public System.Windows.Forms.Label lbWelcome;
        internal System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbLogout;
        private FontAwesome.Sharp.IconButton btnSetup;
        private FontAwesome.Sharp.IconButton btnReports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnActiveMem;
        private System.Windows.Forms.Button btnContrib;
        private System.Windows.Forms.Button btnNonActiveMem;
        private System.Windows.Forms.Button btnLoanRpts;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnWithdrawal;
    }
}