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
    public partial class Settings : UserControl
    {
        ProcessDataPLC plc;
        public Settings(ref ProcessDataPLC _plc)
        {
            InitializeComponent();
            plc = _plc;
        }

        private void timer1Update_Tick(object sender, EventArgs e)
        {
            txtDay.Text = DataTimePLC.day.ToString("00");
            txtMonth.Text = DataTimePLC.month.ToString("00");
            txtYear.Text = DataTimePLC.year.ToString("00");
            //
            txtHour.Text = DataTimePLC.hour.ToString("00");
            txtMinute.Text = DataTimePLC.minute.ToString("00");
            txtSecond.Text = DataTimePLC.second.ToString("00");

            //Update Settings
            txtTempSET.Text = DataTemperature.TemperatureSET.ToString("00.00");
            txtTimeOut.Text = DataTemperature.TimeSET.ToString();
            txtHumiditySET.Text = DataTemperature.HumiditySET.ToString("00.00");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            timer1Update.Enabled = true;
        }

        private void btnSetSettings_Click(object sender, EventArgs e)
        {
            float fTempSET = 0.0F, fHumiditySET = 0.0F;
            short timeOut = 0;
            //  
            float.TryParse(txtTempSET.Text, out fTempSET);
            float.TryParse(txtHumiditySET.Text, out fHumiditySET);
            short.TryParse(txtTimeOut.Text, out timeOut);

            //Update data
            plc.SetTimeOut(timeOut);
            plc.SetTempSET(fTempSET);
            plc.SetHumiditySET(fHumiditySET);

        }
    }
}
