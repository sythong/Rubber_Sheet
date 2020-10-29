using Rubber_Sheet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubber_Sheet.Views
{
    public partial class User : Form
    {
        public bool LoginOK = false;
        public User()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == true)
                txbPassword.UseSystemPasswordChar = false;
            else
                txbPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUser.Text.Trim();
            string password = txbPassword.Text.Trim();
            //
            // create table
            using (SQLite.SQLiteConnection db = new SQLite.SQLiteConnection("db.sqlite"))
            {
                db.CreateTable<Database.User>();
                // checking table is create
                if (db.Table<Database.User>().Count() == 0)
                {
                    // create default
                    db.Insert(new Database.User()
                    {
                        UserName = "admin",
                        Password = "123",
                        Position = "ADMIN",
                        Phone = "0123456789",
                    });
                }

                // query test
                List<Database.User> _usrLst = db.Table<Database.User>().Where(p => p.UserName == username && p.Password == password).ToList();
                if (_usrLst.Count > 0)
                {
                    //Update data
                    UserData.stUserName = _usrLst[0].UserName;
                    UserData.stUserPasswork = _usrLst[0].Password;
                    UserData.stUserPhone = _usrLst[0].Phone;
                    UserData.stUserPosition = _usrLst[0].Position;
                    UserData.stUserId = _usrLst[0].Id;
                    //
                    LoginOK = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không đúng !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
