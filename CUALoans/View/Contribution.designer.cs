namespace CUALoans.View
{
    partial class Contribution
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrevCont = new System.Windows.Forms.TextBox();
            this.lbUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentBal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveTran = new System.Windows.Forms.Button();
            this.txtMine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUTotal = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.cboMembers = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plMain = new System.Windows.Forms.Panel();
            this.dgvContribute = new System.Windows.Forms.DataGridView();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.job_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plAction = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInterest = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribute)).BeginInit();
            this.plAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPrevCont);
            this.panel1.Controls.Add(this.lbUsers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCurrentBal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSaveTran);
            this.panel1.Controls.Add(this.txtMine);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUTotal);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.dtDate);
            this.panel1.Controls.Add(this.cboMembers);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 962);
            this.panel1.TabIndex = 0;
            // 
            // txtPrevCont
            // 
            this.txtPrevCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtPrevCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevCont.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPrevCont.Location = new System.Drawing.Point(18, 649);
            this.txtPrevCont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrevCont.Multiline = true;
            this.txtPrevCont.Name = "txtPrevCont";
            this.txtPrevCont.Size = new System.Drawing.Size(199, 39);
            this.txtPrevCont.TabIndex = 60;
            this.txtPrevCont.Visible = false;
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.Location = new System.Drawing.Point(325, 55);
            this.lbUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(51, 20);
            this.lbUsers.TabIndex = 2;
            this.lbUsers.Text = "label1";
            this.lbUsers.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Date";
            // 
            // txtCurrentBal
            // 
            this.txtCurrentBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtCurrentBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBal.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCurrentBal.Location = new System.Drawing.Point(24, 431);
            this.txtCurrentBal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentBal.Multiline = true;
            this.txtCurrentBal.Name = "txtCurrentBal";
            this.txtCurrentBal.ReadOnly = true;
            this.txtCurrentBal.Size = new System.Drawing.Size(343, 39);
            this.txtCurrentBal.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Current Balance";
            // 
            // btnSaveTran
            // 
            this.btnSaveTran.BackColor = System.Drawing.Color.Green;
            this.btnSaveTran.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSaveTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTran.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSaveTran.Location = new System.Drawing.Point(237, 643);
            this.btnSaveTran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveTran.Name = "btnSaveTran";
            this.btnSaveTran.Size = new System.Drawing.Size(129, 52);
            this.btnSaveTran.TabIndex = 3;
            this.btnSaveTran.Text = "&Save";
            this.btnSaveTran.UseVisualStyleBackColor = false;
            this.btnSaveTran.Click += new System.EventHandler(this.btnSaveTran_Click);
            // 
            // txtMine
            // 
            this.txtMine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMine.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtMine.Location = new System.Drawing.Point(22, 220);
            this.txtMine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMine.Multiline = true;
            this.txtMine.Name = "txtMine";
            this.txtMine.Size = new System.Drawing.Size(343, 39);
            this.txtMine.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "Mine No";
            // 
            // txtUTotal
            // 
            this.txtUTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUTotal.Location = new System.Drawing.Point(32, 6);
            this.txtUTotal.Name = "txtUTotal";
            this.txtUTotal.Size = new System.Drawing.Size(150, 35);
            this.txtUTotal.TabIndex = 53;
            this.txtUTotal.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(226, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 35);
            this.txtId.TabIndex = 52;
            this.txtId.Visible = false;
            // 
            // dtDate
            // 
            this.dtDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(22, 563);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(338, 39);
            this.dtDate.TabIndex = 2;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // cboMembers
            // 
            this.cboMembers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMembers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.cboMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMembers.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboMembers.FormattingEnabled = true;
            this.cboMembers.Location = new System.Drawing.Point(22, 106);
            this.cboMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMembers.Name = "cboMembers";
            this.cboMembers.Size = new System.Drawing.Size(343, 40);
            this.cboMembers.TabIndex = 0;
            this.cboMembers.SelectedIndexChanged += new System.EventHandler(this.cboMembers_SelectedIndexChanged);
            this.cboMembers.SelectionChangeCommitted += new System.EventHandler(this.cboMembers_SelectionChangeCommitted);
            this.cboMembers.SelectedValueChanged += new System.EventHandler(this.CboMembers_SelectedValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTotal.Location = new System.Drawing.Point(22, 898);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(343, 39);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Visible = false;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(3, 852);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(68, 29);
            this.lbTotal.TabIndex = 39;
            this.lbTotal.Text = "Total";
            this.lbTotal.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAmount.Location = new System.Drawing.Point(24, 322);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(343, 39);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monthly Contribution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name :";
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
            this.panel2.Size = new System.Drawing.Size(856, 962);
            this.panel2.TabIndex = 1;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.dgvContribute);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 80);
            this.plMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(852, 878);
            this.plMain.TabIndex = 8;
            // 
            // dgvContribute
            // 
            this.dgvContribute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContribute.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.dgvContribute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContribute.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(202)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContribute.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContribute.ColumnHeadersHeight = 26;
            this.dgvContribute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CId,
            this.member,
            this.mine,
            this.amount,
            this.total,
            this.date,
            this.details,
            this.job_edit,
            this.job_del});
            this.dgvContribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContribute.EnableHeadersVisualStyles = false;
            this.dgvContribute.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvContribute.Location = new System.Drawing.Point(0, 0);
            this.dgvContribute.Margin = new System.Windows.Forms.Padding(4, 20, 4, 5);
            this.dgvContribute.Name = "dgvContribute";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContribute.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContribute.RowHeadersVisible = false;
            this.dgvContribute.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(202)))), ((int)(((byte)(121)))));
            this.dgvContribute.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContribute.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvContribute.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.dgvContribute.RowTemplate.Height = 25;
            this.dgvContribute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContribute.Size = new System.Drawing.Size(852, 878);
            this.dgvContribute.TabIndex = 16;
            this.dgvContribute.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContribute_CellContentClick);
            // 
            // CId
            // 
            this.CId.DataPropertyName = "Id";
            this.CId.HeaderText = "Id";
            this.CId.MinimumWidth = 8;
            this.CId.Name = "CId";
            this.CId.Visible = false;
            // 
            // member
            // 
            this.member.DataPropertyName = "Name";
            this.member.HeaderText = "Name";
            this.member.MinimumWidth = 8;
            this.member.Name = "member";
            // 
            // mine
            // 
            this.mine.DataPropertyName = "MineNo";
            this.mine.FillWeight = 20F;
            this.mine.HeaderText = "Mine No.";
            this.mine.MinimumWidth = 8;
            this.mine.Name = "mine";
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount.DataPropertyName = "Amount";
            this.amount.FillWeight = 40F;
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 8;
            this.amount.Name = "amount";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.DataPropertyName = "Total";
            this.total.FillWeight = 50F;
            this.total.HeaderText = "Total Amount";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.FillWeight = 30F;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            // 
            // details
            // 
            this.details.DataPropertyName = "Other";
            this.details.HeaderText = "Other";
            this.details.MinimumWidth = 8;
            this.details.Name = "details";
            this.details.Visible = false;
            // 
            // job_edit
            // 
            this.job_edit.FillWeight = 20F;
            this.job_edit.HeaderText = "Edit";
            this.job_edit.MinimumWidth = 8;
            this.job_edit.Name = "job_edit";
            this.job_edit.Text = "Edit";
            this.job_edit.UseColumnTextForButtonValue = true;
            // 
            // job_del
            // 
            this.job_del.FillWeight = 20F;
            this.job_del.HeaderText = "Delete";
            this.job_del.MinimumWidth = 8;
            this.job_del.Name = "job_del";
            this.job_del.Text = "Delete";
            this.job_del.UseColumnTextForButtonValue = true;
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
            this.plAction.Controls.Add(this.btnDelete);
            this.plAction.Controls.Add(this.btnInterest);
            this.plAction.Controls.Add(this.txtSearch);
            this.plAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.plAction.Location = new System.Drawing.Point(0, 0);
            this.plAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plAction.Name = "plAction";
            this.plAction.Size = new System.Drawing.Size(852, 62);
            this.plAction.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(215, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 52);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Bulk Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInterest
            // 
            this.btnInterest.BackColor = System.Drawing.Color.Green;
            this.btnInterest.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInterest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInterest.Location = new System.Drawing.Point(21, 5);
            this.btnInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(186, 52);
            this.btnInterest.TabIndex = 59;
            this.btnInterest.Text = "&Pay Interest";
            this.btnInterest.UseVisualStyleBackColor = false;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(418, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(428, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search ...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Contribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1296, 985);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Contribution";
            this.Padding = new System.Windows.Forms.Padding(15, 8, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Contribution_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.plMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribute)).EndInit();
            this.plAction.ResumeLayout(false);
            this.plAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel plMain;
        internal System.Windows.Forms.DataGridView dgvContribute;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel plAction;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbTotal;
        internal System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.ComboBox cboMembers;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtUTotal;
        internal System.Windows.Forms.TextBox txtMine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveTran;
        internal System.Windows.Forms.TextBox txtCurrentBal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtPrevCont;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn member;
        private System.Windows.Forms.DataGridViewTextBoxColumn mine;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewButtonColumn job_edit;
        private System.Windows.Forms.DataGridViewButtonColumn job_del;
    }
}