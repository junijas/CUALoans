using CUALoans.Controller;
using CUALoans.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class User : UserControl
    {
        private readonly CUALoansData _db = new CUALoansData();


        public User()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
        }

        private void Clear()
        {
            txtId.Clear();
            txtUser.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            txtConfirm.Clear();
            cbRole.ResetText();
        }

        private void Confirm()
        {
            if (txtConfirm.Text != txtPass.Text)
            {
                MessageBox.Show(@"Passwords do not match, try again", @"Message", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = UserController.GetUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = Dashboard.GetUser;
            var id = _db.Users.SingleOrDefault(a => a.username == user)?.user_id;
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(cbRole.Text) ||
                string.IsNullOrEmpty(txtConfirm.Text))
            {
                MessageBox.Show(@"All fields are required", @"Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                var salt = Hash.Unique();
                var users = new Model.User
                {
                    name = txtUser.Text,
                    username = txtUsername.Text,
                    salt = salt,
                    password = Hash.AesEncrypt(txtPass.Text, salt),
                    role = cbRole.Text,
                    user_id = Convert.ToInt32(id)
                };
                if (UserController.AddUser(users))
                {
                    dgvUsers.DataSource = UserController.GetUsers();
                    Clear();
                }
            }

        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            Confirm();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvUsers.CurrentRow != null)
            {
                var id = (int)dgvUsers.CurrentRow.Cells["UId"].Value;
                //   var datasource = data.Members.Where(x => x.Id == id).ToList();


                var columnedit = dgvUsers.Columns["job_edit"];
                var columndel = dgvUsers.Columns["job_del"];

                if (columnedit != null && e.ColumnIndex == columnedit.Index)
                {
                    // btnSaveCat.Text = "Update";

                    txtId.Text = id.ToString();
                    txtUser.Text = dgvUsers.CurrentRow?.Cells["name"].Value.ToString();
                    txtUser.Text = dgvUsers.CurrentRow?.Cells["role"].Value.ToString();


                }
                else
                {
                    // Debug.Assert(columndel != null, "columndel != null");
                    if (e.ColumnIndex == columndel.Index)
                    {
                        if (string.IsNullOrEmpty(id.ToString())) return;

                        if (MessageBox.Show(@"Are you sure you want to delete this user", @"Deleting record",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            UserController.DeleteUser(id);
                            dgvUsers.DataSource = UserController.GetUsers();
                        }
                    }
                }
            }

        }
    }
}