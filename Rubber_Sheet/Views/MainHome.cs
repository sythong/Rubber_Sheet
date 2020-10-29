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
    public partial class MainHome : UserControl
    {
        ProcessDataPLC plc;
        public MainHome(ref ProcessDataPLC _plc)
        {
            InitializeComponent();
            plc = _plc;
        }
        #region SET CONTROL ON/OFF
        private void btnSCR_OnOff_Click(object sender, EventArgs e)
        {
            if (sender == btnSCR_On) plc.SetSCROn();
            if (sender == btnSCR_Off) plc.SetSCROff();
        }
        private void btnFAN_OnOff_Click(object sender, EventArgs e)
        {
            if (sender == btnFAN_On) plc.SetFANOn();
            if (sender == btnFAN_Off) plc.SetFANOff();
        }
        private void btnHumidityOnOff_Click(object sender, EventArgs e)
        {
            if (sender == btnHumidityON) plc.SetHumidityOn();
            if (sender == btnHumidityOFF) plc.SetHumidityOff();
        }
        private void btnHeaterOnOff_Click(object sender, EventArgs e)
        {
            if (sender == btnHeaterON) plc.SetHeaterOn();
            if (sender == btnHeaterOFF) plc.SetHeaterOff();
        }
        //
        private void btnSoundReset_Click(object sender, EventArgs e)
        {
            plc.SetSoundReset();
        }
        #endregion

        #region Update Status && Value from PLC
        private void timer1Update_Tick(object sender, EventArgs e)
        {
            if (BitStatus.FanRun)        ovFANRun.BackColor = Color.LightGreen;          else ovFANRun.BackColor = Color.Transparent;
            if (BitStatus.ScrRun)       ovSCRRun.BackColor = Color.LightGreen;          else ovSCRRun.BackColor = Color.Transparent;
            if (BitStatus.HumidityRun)  ovHumidityRUN.BackColor = Color.LightGreen;     else ovHumidityRUN.BackColor = Color.Transparent;
            if (BitStatus.HumidityStop) ovHumiditySTOP.BackColor = Color.Red;           else ovHumiditySTOP.BackColor = Color.Transparent;
            if (BitStatus.HeaterRun)    ovHeaterRUN.BackColor = Color.LightGreen;       else ovHeaterRUN.BackColor = Color.Transparent;
            if (BitStatus.HeaterStop)   ovHeaterSTOP.BackColor = Color.Red;             else ovHeaterSTOP.BackColor = Color.Transparent;
            //
            if (BitStatus.FanErr)       ovFanErr.BackColor = Color.Yellow;         else ovFanErr.BackColor = Color.Transparent;
            if (BitStatus.ScrErr)       ovScrErr.BackColor = Color.Yellow;         else ovScrErr.BackColor = Color.Transparent;
            if (BitStatus.HeaterErr)    ovHeaterErrr.BackColor = Color.Yellow;     else ovHeaterErrr.BackColor = Color.Transparent;
            if (BitStatus.SoundAlarm)   ovSoundAlarm.BackColor = Color.Yellow;     else ovSoundAlarm.BackColor = Color.Transparent;

            //Update graphic
            if (BitStatus.FanRun)  { picbox_FanRUN.Visible = true; picbox_FanRUN1.Visible = !picbox_FanRUN1.Visible; } else { picbox_FanRUN.Visible = false; picbox_FanRUN1.Visible = false; }
            //
            if (BitStatus.ScrRun) picbox_SCRRun.Visible = true; else picbox_SCRRun.Visible = false;
            if (BitStatus.HumidityRun) picbox_HumidityRUN.Visible = true; else picbox_HumidityRUN.Visible = false;

            //for Test bug
            //if (BitStatus.FanRun) picbox_FanRUN.Visible = true; else { picbox_FanRUN.Visible = !picbox_FanRUN.Visible; picbox_FanRUN1.Visible = !picbox_FanRUN1.Visible; }
            //if (BitStatus.ScrRun) picbox_SCRRun.Visible = true; else picbox_SCRRun.Visible = !picbox_SCRRun.Visible;
            //if (BitStatus.HumidityRun) picbox_HumidityRUN.Visible = true; else picbox_HumidityRUN.Visible = !picbox_HumidityRUN.Visible;

            //Update TS1-6

            txtTS1.Text =  DataTemperature.TS1.ToString("00.00");
            txtTS2.Text = DataTemperature.TS2.ToString("00.00");
            txtTS3.Text = DataTemperature.TS3.ToString("00.00");
            txtTS4.Text = DataTemperature.TS4.ToString("00.00");
            txtTS5.Text = DataTemperature.TS5.ToString("00.00");
            txtTS6.Text = DataTemperature.TS6.ToString("00.00");
            txtTS_AVG.Text = DataTemperature.TS_AVG.ToString("00.00");
            txtRH.Text = DataTemperature.TS_RH.ToString("00.00");

            //Update settings
            txtTimeHeater.Text = DataTemperature.TimeHeater.ToString();
            txtTimeSET.Text = DataTemperature.TimeSET.ToString();
            txtTempSET.Text = DataTemperature.TemperatureSET.ToString("00.00");
            txtHumiditySET.Text = DataTemperature.HumiditySET.ToString("00.00");

        }
        #endregion
    }
}
