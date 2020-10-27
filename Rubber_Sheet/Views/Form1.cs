using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubber_Sheet
{
    public partial class Form1 : Form
    {
        //
        //UserControl1 newuser = new UserControl1();
        //panel4.Controls.Add(newuser);
        //    newuser.Dock = DockStyle.Fill;
        //    newuser.BringToFront();

        MainHome frmMain = new MainHome();
        MotorControl frmMotor = new MotorControl();
        Settings frmSetting = new Settings();
        ChartViews frmChart = new ChartViews();
        //

        public Form1()
        {
            InitializeComponent();
            panel4.Controls.Add(frmMain);
            panel4.Controls.Add(frmMotor);
            panel4.Controls.Add(frmSetting);
            panel4.Controls.Add(frmChart);
            //
            frmMain.Dock = DockStyle.Fill;
            frmMotor.Dock = DockStyle.Fill;
            frmSetting.Dock = DockStyle.Fill;
            frmChart.Dock = DockStyle.Fill;
        }

        private void SelectView_Click(object sender, EventArgs e)
        {
            if (sender == HomeMain)     frmMain.BringToFront();
            if (sender == MotorControl) frmMotor.BringToFront();
            if (sender == ChartViews)   frmChart.BringToFront();
            if (sender == Settings)     frmSetting.BringToFront();
            //if (sender == Warning)      frmMotor.BringToFront();
            //if (sender == User)         frmMotor.BringToFront();
        }
    }
}
