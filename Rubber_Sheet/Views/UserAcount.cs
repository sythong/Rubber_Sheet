using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rubber_Sheet.Models;
//using Rubber_Sheet.Database;

namespace Rubber_Sheet.Views
{
    public partial class UserAcount : UserControl
    {
        public int stUserId = 0;
        public UserAcount()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            //this.BringToFront();
        }

        private void btUpdateUser_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                using (SQLite.SQLiteConnection db = new SQLite.SQLiteConnection("db.sqlite"))
                {
                    //db.CreateTable<ReportError>();
                    db.CreateTable(typeof(Database.User));//, CreateFlags.None);
                    result = db.Update(new Database.User
                    {
                        Id = stUserId,
                        UserName = txtUserNEW.Text,
                        Password = txtPassNEW.Text,
                        Position = txtPositionNEW.Text,
                        Phone = txtPhoneNew.Text,
                    });
                }
            }
            catch { }
            //
            if (result > 0) MessageBox.Show("Đã cập nhập thông tin thành công.","Thông báo Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void UserAcount_Load(object sender, EventArgs e)
        {
        }
    }
}
