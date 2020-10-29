using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rubber_Sheet.Views;
using Rubber_Sheet.Models;
using Rubber_Sheet.Helpers;

using System.Net;   //get hostnam (IP)
using System.Net.NetworkInformation; //Include this
using System.IO;

namespace Rubber_Sheet
{
    public partial class Form1 : Form
    {
        static ProcessDataPLC plc = new ProcessDataPLC();
        //
        MainHome frmMain = new MainHome(ref plc);
        MotorControl frmMotor = new MotorControl(ref plc);
        Settings frmSetting = new Settings(ref plc);
        ChartViews frmChart = new ChartViews();
        UserAcount frmUserAcc = new UserAcount();
        UserWarning frmWarning = new UserWarning();
        //
        // Get IPAddress
        public string ipAddress = "";

        public Form1()
        {
            InitializeComponent();
            panel4.Controls.Add(frmMain);
            panel4.Controls.Add(frmMotor);
            panel4.Controls.Add(frmSetting);
            panel4.Controls.Add(frmChart);
            panel4.Controls.Add(frmUserAcc);
            panel4.Controls.Add(frmWarning);
            //
            frmMain.Dock = DockStyle.Fill;
            frmMotor.Dock = DockStyle.Fill;
            frmSetting.Dock = DockStyle.Fill;
            frmChart.Dock = DockStyle.Fill;
            frmUserAcc.Dock = DockStyle.Fill;
            frmWarning.Dock = DockStyle.Fill;
            //
            timer1Update.Enabled = true;
        }

        private void SelectView_Click(object sender, EventArgs e)
        {
            if (sender == HomeMain)     frmMain.BringToFront();
            if (sender == MotorControl) frmMotor.BringToFront();
            if (sender == ChartViews)   frmChart.BringToFront();
            if (sender == Settings)     frmSetting.BringToFront();
            if (sender == Warning)      frmWarning.BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void User_Click(object sender, EventArgs e)
        {
            User frmUser = new User() { LoginOK = false };
            frmUser.ShowDialog();
            //
            if (frmUser.LoginOK)
            {
                frmUserAcc.BringToFront();
                frmUserAcc.txtUserNEW.Text = UserData.stUserName;
                frmUserAcc.txtPassNEW.Text = UserData.stUserPasswork;
                frmUserAcc.txtPositionNEW.Text = UserData.stUserPosition;
                frmUserAcc.txtPhoneNew.Text = UserData.stUserPhone;
                frmUserAcc.stUserId = UserData.stUserId;

                //Update user
                txtUser.Text = UserData.stUserName;
                txtPosition.Text = UserData.stUserPosition;
                txtPhone.Text = UserData.stUserPhone;
            }
        }

        private void timer1Update_Tick(object sender, EventArgs e)
        {
            if (!plc.isConnected) return;
            //Update Status
            if (BitStatus.SelectAtSite) lblASite.BackColor = Color.LightGreen;
            else lblASite.BackColor = Color.LightGray;
            //
            if (BitStatus.SelectHMI) lblHMI.BackColor = Color.LightGreen;
            else lblHMI.BackColor = Color.LightGray;
            //
            if (BitStatus.SelectRemote) lblRemote.BackColor = Color.LightGreen;
            else lblRemote.BackColor = Color.LightGray;
            //
            if (BitStatus.SelectManualAuto)
            {
                lblAuto.BackColor = Color.LightGreen;
                lbalManual.BackColor = Color.LightGray;
            }
            else
            {
                lblAuto.BackColor = Color.LightGray;
                lbalManual.BackColor = Color.LightGreen;
            }
            //Update Date - Time
            DateTime d1 = DateTime.Now;
            txtDate.Text = d1.ToString("dd/MM/yyyy");
            txtTime.Text = d1.ToString("HH:mm:ss");

            // Check connect he thong
            if (plc.isConnected)
            {
                toolStripConnect.Text = "Đã kết nối đến PLC";
                toolStripStatusLabel1.Text = "Hệ thống sẵn sàng làm việc";
                toolStripStatusLabel1.Image = Rubber_Sheet.Properties.Resources.Checked_48px;
                toolStripConnect.Image = Rubber_Sheet.Properties.Resources.Connected_48px;
                //
                btnConnect.Text = "NGẮT KẾT NỐI";
            }
            else
            {
                toolStripConnect.Text = "Chưa kết nối đến PLC";
                toolStripStatusLabel1.Text = "Hệ thống chưa sẵn sàng làm việc";
                toolStripStatusLabel1.Image = Rubber_Sheet.Properties.Resources.Cancel_48px;
                toolStripConnect.Image = Rubber_Sheet.Properties.Resources.Disconnected_48px;
                //
                btnConnect.Text = "KẾT NỐI PLC";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (plc.isConnected) plc.Disconnect();
            if (plc.isThreadRun) plc.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Database
            // create new db
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "db.sqlite";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
            //Update date + time
            DateTime d0 = DateTime.Now;
            txtDateLog.Text = d0.ToString("dd/MM/yyyy");
            txtTimeLog.Text = d0.ToString("HH:mm:ss");
            //
            toolStripConnect.Text = "Chưa kết nối đến PLC";
            toolStripStatusLabel1.Text = "Hệ thống chưa sẵn sàng làm việc";
            toolStripStatusLabel1.Image = Rubber_Sheet.Properties.Resources.Cancel_48px;
            //
            //Get IPAddress
            if (Dns.GetHostAddresses(Dns.GetHostName()).Length > 0)
                //ipAddress = Dns.GetHostAddresses(Dns.GetHostName())[0].ToString();
                ipAddress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString(); //OK
            toolStripStatusLabelMyIP.Text = "PC IP Address: " + ipAddress;
            //
            //if (!plc.isConnected)  plc.Connect();
            //if (plc.isConnected) if (!plc.isThreadRun) plc.start();
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (plc.isConnected)
            {
                plc.Disconnect();
                if (plc.isThreadRun) plc.stop();
            }
            else
            {
                plc.Connect();
                if (!plc.isThreadRun) plc.start();
            }     
        }
    }
}
