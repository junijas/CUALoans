using CUALoans.Model;
using CUALoans.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using User = CUALoans.Model.User;

namespace CUALoans.Controller
{
    internal class UserController
    {
        private static readonly CUALoansData Db = new CUALoansData();

        private readonly User _user = new User();

        private bool _isLoggedIn;

        // Constructor
        public UserController(int id = 0)
        {
            _user.user_id = id;
        }


        public static IEnumerable<dynamic> GetUsers()
        {
            try
            {
                var query = from user in Db.Users
                            where user.status.Equals("Active")
                            select new
                            {
                                user.user_id,
                                user.name,
                                user.username,
                                user.role,
                                user.created_at
                            };
                return query.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static bool Search(string username, TextBox user)
        {
            var query = Db.Users.SingleOrDefault(x => x.username.Equals(username));
            if (query != null)
            {
                MessageBox.Show(@"Username already exists choose different username please", @"User Already Exist",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.Focus();
                return true;
            }

            return false;
        }

        public static bool ChangePassword(User user)
        {
            var query = Db.Users.Find(user.user_id);
            if (query != null)
            {
                query.salt = user.salt;
                query.password = user.password;
            }

            Db.SaveChanges();
            return true;
        }

        public bool Find(int id = 0) //, string username = "")
        {
            var userData = Db.Users;
            // find id
            if (userData.Find(id) != null)
            {
                _user.user_id = userData.First().user_id;
                _user.username = userData.First().username;
                _user.password = userData.First().password;
                _user.salt = userData.First().salt;
                _user.name = userData.First().name;
                //_user.addedby = userData.First().addedby;

                return true;
            }

            return false;
        } // end of find

        private bool Find(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                var userData = Db.Users;
                // find username
                var query = userData.SingleOrDefault(user => user.username.Equals(username) && user.status == "Active");

                if (query != null)
                {
                    _user.user_id = query.user_id;
                    _user.username = query.username;
                    _user.password = query.password;
                    _user.salt = query.salt;
                    _user.name = query.name;
                    // _user.AddedBy = query.AddedBy;
                    return true;
                }
            }

            return false;
        }

        public bool Login(string username, string password)
        {
            try
            {
                //user.find(username);
                if (Find(username))
                    if (_user.password == Hash.AesEncrypt(password, _user.salt))
                    {
                        _isLoggedIn = true;
                        return _isLoggedIn;
                    }
                    // password does not match
                    else
                    {
                        MessageBox.Show(@"Sorry! Incorrect password", @"Access denied", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                else
                    MessageBox.Show(@"Username does not exist. Please check and try again.", @"Invalid username",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public static bool AddUser(User add)
        {
            add.created_at = DateTime.Now;
            add.status = "Active";
            var getuser = Db.Users.SingleOrDefault(op => op.username.Equals(add.username) && op.status == "Active");
            if (getuser != null)
            {
                MessageBox.Show(@"Username already exists choose different username please", @"User Already Exist",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Db.Users.Add(add);
                Db.SaveChanges();
                MessageBox.Show(@"User account has been created successfully", @"Account created", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            return true;
        }

        public static void DeleteUser(int id)
        {
            var query = Db.Users.Find(id);
            if (query != null)
                query.status = "Deleted";
            Db.SaveChanges();
        }

        public static void Logout(Form dashboard)
        {
            if (MessageBox.Show(@"Are you sure you want logout? Any unsaved data will be lost. \n Continue?",
                    @"Confirm logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                dashboard.Hide();
                new Login().ShowDialog();
            }


        }
    }
}