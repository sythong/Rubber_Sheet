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
using Rubber_Sheet.Helpers;
namespace Rubber_Sheet
{
    public partial class MotorControl : UserControl
    {
        ProcessDataPLC plc;
        public MotorControl(ref ProcessDataPLC _plc)
        {
            InitializeComponent();
            plc = _plc;
        }

        #region Time1 Update Status
        private void timer1Update_Tick(object sender, EventArgs e)
        {
            //Update Limit Servo
            if (BitStatus.bLimitSERVO1UP)   ovLimitSERVO1Up.BackColor   = Color.LightGreen;     else ovLimitSERVO1Up.BackColor      = Color.Transparent;
            if (BitStatus.bLimitSERVO1Down) ovLimitSERVO1Down.BackColor = Color.Red;            else ovLimitSERVO1Down.BackColor    = Color.Transparent;
            //
            if (BitStatus.bLimitSERVO2UP)   ovLimitSERVO2Up.BackColor   = Color.LightGreen;     else ovLimitSERVO2Up.BackColor      = Color.Transparent;
            if (BitStatus.bLimitSERVO2Down) ovLimitSERVO2Down.BackColor = Color.Red;            else ovLimitSERVO2Down.BackColor    = Color.Transparent;
            //
            if (BitStatus.bLimitSERVO3UP)   ovLimitSERVO3Up.BackColor   = Color.LightGreen;     else ovLimitSERVO3Up.BackColor      = Color.Transparent;
            if (BitStatus.bLimitSERVO3Down) ovLimitSERVO3Down.BackColor = Color.Red;            else ovLimitSERVO3Down.BackColor    = Color.Transparent;
            //
            if (BitStatus.bLimitSERVO4UP)   ovLimitSERVO4Up.BackColor   = Color.LightGreen;     else ovLimitSERVO4Up.BackColor      = Color.Transparent;
            if (BitStatus.bLimitSERVO4Down) ovLimitSERVO4Down.BackColor = Color.Red;            else ovLimitSERVO4Down.BackColor    = Color.Transparent;

            //Update Limit Xi-Lanh
            if (BitStatus.bLimitXiLanh1UP)   ovLimitXilanh1Up.BackColor = Color.LightGreen;     else ovLimitXilanh1Up.BackColor     = Color.Transparent;
            if (BitStatus.bLimitXiLanh1Down) ovLimitXilanh1Down.BackColor = Color.Red;          else ovLimitXilanh1Down.BackColor   = Color.Transparent;
            //
            if (BitStatus.bLimitXiLanh2UP)   ovLimitXilanh2Up.BackColor = Color.LightGreen;     else ovLimitXilanh2Up.BackColor     = Color.Transparent;
            if (BitStatus.bLimitXiLanh1Down) ovLimitXilanh2Down.BackColor = Color.Red;          else ovLimitXilanh2Down.BackColor   = Color.Transparent;
            //
            if (BitStatus.bLimitXiLanh3UP)   ovLimitXilanh3Up.BackColor = Color.LightGreen;     else ovLimitXilanh3Up.BackColor     = Color.Transparent;
            if (BitStatus.bLimitXiLanh3Down) ovLimitXilanh3Down.BackColor = Color.Red;          else ovLimitXilanh3Down.BackColor   = Color.Transparent;
            //
            if (BitStatus.bLimitXiLanh4UP)   ovLimitXilanh4Up.BackColor = Color.LightGreen;     else ovLimitXilanh4Up.BackColor     = Color.Transparent;
            if (BitStatus.bLimitXiLanh4Down) ovLimitXilanh4Down.BackColor = Color.Red;          else ovLimitXilanh4Down.BackColor   = Color.Transparent;

            //Update status SERVO RUN
            if (BitStatus.Servo1Up)     ovServo1Up.BackColor = Color.LightGreen;           else ovServo1Up.BackColor = Color.Transparent;
            if (BitStatus.Servo1Down)   ovServo1Down.BackColor = Color.Red;                else ovServo1Down.BackColor = Color.Transparent;
            //
            if (BitStatus.Servo2Up)     ovServo2Up.BackColor = Color.LightGreen;           else ovServo2Up.BackColor = Color.Transparent;
            if (BitStatus.Servo2Down)   ovServo2Down.BackColor = Color.Red;                else ovServo2Down.BackColor = Color.Transparent;
            //
            if (BitStatus.Servo3Up)     ovServo3Up.BackColor = Color.LightGreen;           else ovServo3Up.BackColor = Color.Transparent;
            if (BitStatus.Servo3Down)   ovServo3Down.BackColor = Color.Red;                else ovServo3Down.BackColor = Color.Transparent;
            //
            if (BitStatus.Servo4Up)     ovServo4Up.BackColor = Color.LightGreen;           else ovServo4Up.BackColor = Color.Transparent;
            if (BitStatus.Servo4Down)   ovServo4Down.BackColor = Color.Red;                else ovServo4Down.BackColor = Color.Transparent;

            //Update status XiLanh RUN
            if (BitStatus.XiLanh1Up)    ovXiLanh1Up.BackColor = Color.LightGreen;          else ovXiLanh1Up.BackColor = Color.Transparent;
            if (BitStatus.XiLanh1Down)  ovXiLanh1Down.BackColor = Color.Red;               else ovXiLanh1Down.BackColor = Color.Transparent;
            //
            if (BitStatus.XiLanh2Up)    ovXiLanh2Up.BackColor = Color.LightGreen;          else ovXiLanh2Up.BackColor = Color.Transparent;
            if (BitStatus.XiLanh2Down)  ovXiLanh2Down.BackColor = Color.Red;               else ovXiLanh2Down.BackColor = Color.Transparent;
            //
            if (BitStatus.XiLanh3Up)    ovXiLanh3Up.BackColor = Color.LightGreen;          else ovXiLanh3Up.BackColor = Color.Transparent;
            if (BitStatus.XiLanh3Down)  ovXiLanh3Down.BackColor = Color.Red;               else ovXiLanh3Down.BackColor = Color.Transparent;
            //
            if (BitStatus.XiLanh4Up)    ovXiLanh4Up.BackColor = Color.LightGreen;          else ovXiLanh4Up.BackColor = Color.Transparent;
            if (BitStatus.XiLanh4Down)  ovXiLanh4Down.BackColor = Color.Red;               else ovXiLanh4Down.BackColor = Color.Transparent;

            //Update status PUMP
            if (BitStatus.PumpRun) ovPumRun.BackColor   = Color.LightGreen;     else ovPumRun.BackColor     = Color.Transparent;
            if (BitStatus.PumpErr) ovPumpErr.BackColor  = Color.LightYellow;    else ovPumpErr.BackColor    = Color.Transparent;

            //Update Status DOOR 1-2-3-4
            if (BitStatus.Door1) ovDoor1.BackColor = Color.Red; else ovDoor1.BackColor = Color.Transparent;
            if (BitStatus.Door2) ovDoor2.BackColor = Color.Red; else ovDoor2.BackColor = Color.Transparent;
            if (BitStatus.Door3) ovDoor3.BackColor = Color.Red; else ovDoor3.BackColor = Color.Transparent;
            if (BitStatus.Door4) ovDoor4.BackColor = Color.Red; else ovDoor4.BackColor = Color.Transparent;
            //
        }
        #endregion

        #region Set Control SERVO && XiLanh (UP-Down)
        private void btnOnOffServo1_Click(object sender, EventArgs e)
        {
            if (sender == btnOnServo1)  plc.SetServo1Up();
            if (sender == btnOffServo1) plc.SetServo1Down();
        }
        //
        private void btnOnOffServo2_Click(object sender, EventArgs e)
        {
            if (sender == btnOnServo2) plc.SetServo2Up();
            if (sender == btnOffServo2) plc.SetServo2Down();
        }
        //
        private void btnOnOffServo3_Click(object sender, EventArgs e)
        {
            if (sender == btnOnServo3) plc.SetServo3Up();
            if (sender == btnOffServo3) plc.SetServo3Down();
        }
        //
        private void btnOnOffServo4_Click(object sender, EventArgs e)
        {
            if (sender == btnOnServo4) plc.SetServo4Up();
            if (sender == btnOffServo4) plc.SetServo4Down();
        }
        private void btnOnOffXiLanh1_Click(object sender, EventArgs e)
        {
            if (sender == btnOnXiLanh1) plc.SetXiLanh1Up();
            if (sender == btnOffXiLanh1) plc.SetXiLanh1Down();
        }
        private void btnOnOffXiLanh2_Click(object sender, EventArgs e)
        {
            if (sender == btnOnXiLanh2) plc.SetXiLanh2Up();
            if (sender == btnOffXiLanh2) plc.SetXiLanh2Down();
        }
        private void btnOnOffXiLanh3_Click(object sender, EventArgs e)
        {
            if (sender == btnOnXiLanh3) plc.SetXiLanh3Up();
            if (sender == btnOffXiLanh3) plc.SetXiLanh3Down();
        }
        private void btnOnOffXiLanh4_Click(object sender, EventArgs e)
        {
            if (sender == btnOnXiLanh4) plc.SetXiLanh4Up();
            if (sender == btnOffXiLanh4) plc.SetXiLanh4Down();
        }
        private void btnPumpOnOff_Click(object sender, EventArgs e)
        {
            if (sender == btnPumpON) plc.SetPumpON();
            if (sender == btnPumpOFF) plc.SetPumpOFF();
        }
        #endregion
    }
}
