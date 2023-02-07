namespace CUALoans.View
{
    partial class Loans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plAction = new System.Windows.Forms.Panel();
            this.lbUsers = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plMain = new System.Windows.Forms.Panel();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.LId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gua1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gua2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.job_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.plAction.SuspendLayout();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // plAction
            // 
            this.plAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.plAction.Controls.Add(this.lbUsers);
            this.plAction.Controls.Add(this.txtSearch);
            this.plAction.Controls.Add(this.btnAddJob);
            this.plAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.plAction.Location = new System.Drawing.Point(13, 6);
            this.plAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plAction.Name = "plAction";
            this.plAction.Size = new System.Drawing.Size(1126, 49);
            this.plAction.TabIndex = 2;
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.Location = new System.Drawing.Point(245, 18);
            this.lbUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(46, 17);
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
            this.txtSearch.Location = new System.Drawing.Point(740, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(381, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search ...";
            this.txtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnAddJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddJob.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJob.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddJob.Location = new System.Drawing.Point(0, 0);
            this.btnAddJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(180, 49);
            this.btnAddJob.TabIndex = 0;
            this.btnAddJob.Text = "Add New Loan";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.BtnAddJob_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 15);
            this.panel1.TabIndex = 4;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.dgvLoans);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(13, 70);
            this.plMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1126, 622);
            this.plMain.TabIndex = 5;
            // 
            // dgvLoans
            // 
            this.dgvLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.dgvLoans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(202)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoans.ColumnHeadersHeight = 26;
            this.dgvLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LId,
            this.mid,
            this.Member,
            this.mine,
            this.amount,
            this.period,
            this.interest,
            this.apay,
            this.date,
            this.status,
            this.purpose,
            this.gua1,
            this.gua2,
            this.mine1,
            this.mine2,
            this.dept,
            this.job_edit,
            this.job_del});
            this.dgvLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoans.EnableHeadersVisualStyles = false;
            this.dgvLoans.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvLoans.Location = new System.Drawing.Point(0, 0);
            this.dgvLoans.Margin = new System.Windows.Forms.Padding(4, 16, 4, 4);
            this.dgvLoans.Name = "dgvLoans";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoans.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoans.RowHeadersVisible = false;
            this.dgvLoans.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(202)))), ((int)(((byte)(121)))));
            this.dgvLoans.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoans.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvLoans.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.dgvLoans.RowTemplate.Height = 25;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(1126, 622);
            this.dgvLoans.TabIndex = 16;
            this.dgvLoans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellContentClick);
            // 
            // LId
            // 
            this.LId.DataPropertyName = "Id";
            this.LId.HeaderText = "Id";
            this.LId.MinimumWidth = 8;
            this.LId.Name = "LId";
            this.LId.Visible = false;
            // 
            // mid
            // 
            this.mid.DataPropertyName = "Member";
            this.mid.HeaderText = "mid";
            this.mid.MinimumWidth = 8;
            this.mid.Name = "mid";
            this.mid.Visible = false;
            // 
            // Member
            // 
            this.Member.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Member.DataPropertyName = "Name";
            this.Member.HeaderText = "Name";
            this.Member.MinimumWidth = 8;
            this.Member.Name = "Member";
            // 
            // mine
            // 
            this.mine.DataPropertyName = "MineNo";
            this.mine.FillWeight = 40F;
            this.mine.HeaderText = "Mine No.";
            this.mine.MinimumWidth = 8;
            this.mine.Name = "mine";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "Amount";
            this.amount.FillWeight = 50F;
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 8;
            this.amount.Name = "amount";
            // 
            // period
            // 
            this.period.DataPropertyName = "RepaymentPeriod";
            this.period.FillWeight = 30F;
            this.period.HeaderText = "Period";
            this.period.MinimumWidth = 8;
            this.period.Name = "period";
            // 
            // interest
            // 
            this.interest.DataPropertyName = "Interest";
            this.interest.FillWeight = 40F;
            this.interest.HeaderText = "Interest";
            this.interest.MinimumWidth = 8;
            this.interest.Name = "interest";
            // 
            // apay
            // 
            this.apay.DataPropertyName = "AmountPayable";
            this.apay.FillWeight = 70F;
            this.apay.HeaderText = "Amount Payable";
            this.apay.MinimumWidth = 8;
            this.apay.Name = "apay";
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.FillWeight = 40F;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.FillWeight = 40F;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            // 
            // purpose
            // 
            this.purpose.DataPropertyName = "Purpose";
            this.purpose.HeaderText = "purpose";
            this.purpose.MinimumWidth = 8;
            this.purpose.Name = "purpose";
            this.purpose.Visible = false;
            // 
            // gua1
            // 
            this.gua1.DataPropertyName = "Guarantor1";
            this.gua1.HeaderText = "Guarantor";
            this.gua1.MinimumWidth = 8;
            this.gua1.Name = "gua1";
            this.gua1.Visible = false;
            // 
            // gua2
            // 
            this.gua2.DataPropertyName = "Guarantor2";
            this.gua2.HeaderText = "Gua";
            this.gua2.MinimumWidth = 8;
            this.gua2.Name = "gua2";
            this.gua2.Visible = false;
            // 
            // mine1
            // 
            this.mine1.DataPropertyName = "MineNo1";
            this.mine1.HeaderText = "mine";
            this.mine1.MinimumWidth = 8;
            this.mine1.Name = "mine1";
            this.mine1.Visible = false;
            // 
            // mine2
            // 
            this.mine2.DataPropertyName = "MineNo2";
            this.mine2.HeaderText = "mine";
            this.mine2.MinimumWidth = 8;
            this.mine2.Name = "mine2";
            this.mine2.Visible = false;
            // 
            // dept
            // 
            this.dept.DataPropertyName = "Department";
            this.dept.HeaderText = "dept";
            this.dept.MinimumWidth = 8;
            this.dept.Name = "dept";
            this.dept.Visible = false;
            // 
            // job_edit
            // 
            this.job_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.job_edit.FillWeight = 20F;
            this.job_edit.HeaderText = "Edit";
            this.job_edit.MinimumWidth = 8;
            this.job_edit.Name = "job_edit";
            this.job_edit.Text = "Edit";
            this.job_edit.UseColumnTextForButtonValue = true;
            this.job_edit.Width = 45;
            // 
            // job_del
            // 
            this.job_del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.job_del.HeaderText = "Delete";
            this.job_del.MinimumWidth = 8;
            this.job_del.Name = "job_del";
            this.job_del.Text = "Delete";
            this.job_del.UseColumnTextForButtonValue = true;
            this.job_del.Width = 63;
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1152, 704);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Loans";
            this.Padding = new System.Windows.Forms.Padding(13, 6, 13, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JobBook_Load);
            this.plAction.ResumeLayout(false);
            this.plAction.PerformLayout();
            this.plMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plAction;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn LId;
        private System.Windows.Forms.DataGridViewTextBoxColumn mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridViewTextBoxColumn mine;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn period;
        private System.Windows.Forms.DataGridViewTextBoxColumn interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn apay;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn gua1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gua2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewButtonColumn job_edit;
        private System.Windows.Forms.DataGridViewButtonColumn job_del;
    }
}