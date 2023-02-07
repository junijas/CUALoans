namespace CUALoans.View
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plAction = new System.Windows.Forms.Panel();
            this.lbUsers = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMembers = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.daDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plMain = new System.Windows.Forms.Panel();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.job_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOldBal = new System.Windows.Forms.TextBox();
            this.txtOldPaid = new System.Windows.Forms.TextBox();
            this.txtOldAmt = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.cboLoans = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.plAction.SuspendLayout();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 18);
            this.panel3.TabIndex = 7;
            // 
            // plAction
            // 
            this.plAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.plAction.Controls.Add(this.lbUsers);
            this.plAction.Controls.Add(this.txtSearch);
            this.plAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.plAction.Location = new System.Drawing.Point(0, 0);
            this.plAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plAction.Name = "plAction";
            this.plAction.Size = new System.Drawing.Size(852, 62);
            this.plAction.TabIndex = 6;
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.Location = new System.Drawing.Point(276, 23);
            this.lbUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(51, 20);
            this.lbUsers.TabIndex = 2;
            this.lbUsers.Text = "label1";
            this.lbUsers.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(419, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(428, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search ...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(216, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 35);
            this.txtId.TabIndex = 52;
            this.txtId.Visible = false;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBalance.Location = new System.Drawing.Point(22, 535);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(343, 39);
            this.txtBalance.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Balance:";
            // 
            // cboMembers
            // 
            this.cboMembers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMembers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.cboMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMembers.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboMembers.FormattingEnabled = true;
            this.cboMembers.Location = new System.Drawing.Point(22, 111);
            this.cboMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMembers.Name = "cboMembers";
            this.cboMembers.Size = new System.Drawing.Size(343, 40);
            this.cboMembers.TabIndex = 0;
            this.cboMembers.SelectedIndexChanged += new System.EventHandler(this.cboMembers_SelectedIndexChanged);
            this.cboMembers.SelectionChangeCommitted += new System.EventHandler(this.cboMembers_SelectionChangeCommitted);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(216, 840);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 52);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAmount.Location = new System.Drawing.Point(22, 426);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(343, 39);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(22, 383);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(201, 29);
            this.txtTotal.TabIndex = 39;
            this.txtTotal.Text = "Monthly Payment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loan:";
            // 
            // dtDate
            // 
            this.dtDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.dtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(22, 638);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(343, 39);
            this.dtDate.TabIndex = 4;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // daDate
            // 
            this.daDate.AutoSize = true;
            this.daDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daDate.Location = new System.Drawing.Point(22, 691);
            this.daDate.Name = "daDate";
            this.daDate.Size = new System.Drawing.Size(109, 29);
            this.daDate.TabIndex = 41;
            this.daDate.Text = "Remarks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name :";
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.dgvPayments);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 80);
            this.plMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(852, 945);
            this.plMain.TabIndex = 8;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(202)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.ColumnHeadersHeight = 26;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.member,
            this.loan,
            this.pay,
            this.total,
            this.balance,
            this.date,
            this.job_edit,
            this.job_del});
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvPayments.Location = new System.Drawing.Point(0, 0);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
            this.dgvPayments.Name = "dgvPayments";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(202)))), ((int)(((byte)(121)))));
            this.dgvPayments.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayments.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvPayments.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.dgvPayments.RowTemplate.Height = 25;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(852, 945);
            this.dgvPayments.TabIndex = 0;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellContentClick);
            // 
            // PId
            // 
            this.PId.DataPropertyName = "Id";
            this.PId.HeaderText = "Id";
            this.PId.MinimumWidth = 8;
            this.PId.Name = "PId";
            this.PId.Visible = false;
            // 
            // member
            // 
            this.member.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.member.DataPropertyName = "Name";
            this.member.FillWeight = 70F;
            this.member.HeaderText = "Name";
            this.member.MinimumWidth = 8;
            this.member.Name = "member";
            // 
            // loan
            // 
            this.loan.DataPropertyName = "Loan";
            this.loan.FillWeight = 50F;
            this.loan.HeaderText = "Loan";
            this.loan.MinimumWidth = 8;
            this.loan.Name = "loan";
            // 
            // pay
            // 
            this.pay.DataPropertyName = "Payment1";
            this.pay.FillWeight = 25F;
            this.pay.HeaderText = "Amount Paid";
            this.pay.MinimumWidth = 8;
            this.pay.Name = "pay";
            // 
            // total
            // 
            this.total.DataPropertyName = "TotalPaid";
            this.total.FillWeight = 50F;
            this.total.HeaderText = "Total Amount Paid";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            // 
            // balance
            // 
            this.balance.DataPropertyName = "Balance";
            this.balance.FillWeight = 50F;
            this.balance.HeaderText = "Balance";
            this.balance.MinimumWidth = 8;
            this.balance.Name = "balance";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "Date";
            this.date.FillWeight = 30F;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            // 
            // job_edit
            // 
            this.job_edit.FillWeight = 22F;
            this.job_edit.HeaderText = "Edit";
            this.job_edit.MinimumWidth = 8;
            this.job_edit.Name = "job_edit";
            this.job_edit.Text = "Edit";
            this.job_edit.UseColumnTextForButtonValue = true;
            // 
            // job_del
            // 
            this.job_del.FillWeight = 30F;
            this.job_del.HeaderText = "Delete";
            this.job_del.MinimumWidth = 8;
            this.job_del.Name = "job_del";
            this.job_del.Text = "Delete";
            this.job_del.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.plMain);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.plAction);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(425, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 1029);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMine);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOldBal);
            this.panel1.Controls.Add(this.txtOldPaid);
            this.panel1.Controls.Add(this.txtOldAmt);
            this.panel1.Controls.Add(this.txtPaid);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.cboLoans);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtDate);
            this.panel1.Controls.Add(this.cboMembers);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.daDate);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 1029);
            this.panel1.TabIndex = 0;
            // 
            // txtMine
            // 
            this.txtMine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMine.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMine.Location = new System.Drawing.Point(22, 222);
            this.txtMine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMine.Multiline = true;
            this.txtMine.Name = "txtMine";
            this.txtMine.ReadOnly = true;
            this.txtMine.Size = new System.Drawing.Size(343, 39);
            this.txtMine.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Mine No";
            // 
            // txtOldBal
            // 
            this.txtOldBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtOldBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldBal.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtOldBal.Location = new System.Drawing.Point(206, 482);
            this.txtOldBal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldBal.Multiline = true;
            this.txtOldBal.Name = "txtOldBal";
            this.txtOldBal.Size = new System.Drawing.Size(160, 39);
            this.txtOldBal.TabIndex = 56;
            this.txtOldBal.Visible = false;
            // 
            // txtOldPaid
            // 
            this.txtOldPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtOldPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPaid.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtOldPaid.Location = new System.Drawing.Point(24, 837);
            this.txtOldPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldPaid.Multiline = true;
            this.txtOldPaid.Name = "txtOldPaid";
            this.txtOldPaid.Size = new System.Drawing.Size(166, 39);
            this.txtOldPaid.TabIndex = 55;
            this.txtOldPaid.Visible = false;
            // 
            // txtOldAmt
            // 
            this.txtOldAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtOldAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldAmt.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtOldAmt.Location = new System.Drawing.Point(183, 583);
            this.txtOldAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldAmt.Multiline = true;
            this.txtOldAmt.Name = "txtOldAmt";
            this.txtOldAmt.Size = new System.Drawing.Size(182, 39);
            this.txtOldAmt.TabIndex = 54;
            this.txtOldAmt.Visible = false;
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPaid.Location = new System.Drawing.Point(22, 883);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaid.Multiline = true;
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(166, 39);
            this.txtPaid.TabIndex = 53;
            this.txtPaid.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.White;
            this.txtRemarks.Location = new System.Drawing.Point(22, 742);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(343, 81);
            this.txtRemarks.TabIndex = 5;
            this.txtRemarks.Text = "";
            // 
            // cboLoans
            // 
            this.cboLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.cboLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoans.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboLoans.FormattingEnabled = true;
            this.cboLoans.Location = new System.Drawing.Point(22, 322);
            this.cboLoans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLoans.Name = "cboLoans";
            this.cboLoans.Size = new System.Drawing.Size(343, 40);
            this.cboLoans.TabIndex = 1;
            this.cboLoans.SelectedIndexChanged += new System.EventHandler(this.cboLoans_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1296, 1052);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Payment";
            this.Padding = new System.Windows.Forms.Padding(15, 8, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            this.plAction.ResumeLayout(false);
            this.plAction.PerformLayout();
            this.plMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel plAction;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cboMembers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label daDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plMain;
        internal System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtRemarks;
        internal System.Windows.Forms.ComboBox cboLoans;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.TextBox txtPaid;
        internal System.Windows.Forms.TextBox txtOldAmt;
        internal System.Windows.Forms.TextBox txtOldPaid;
        internal System.Windows.Forms.TextBox txtOldBal;
        internal System.Windows.Forms.TextBox txtMine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn member;
        private System.Windows.Forms.DataGridViewTextBoxColumn loan;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn job_edit;
        private System.Windows.Forms.DataGridViewButtonColumn job_del;
    }
}