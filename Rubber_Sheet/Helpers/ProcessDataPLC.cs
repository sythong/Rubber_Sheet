
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ActUtlTypeLib;
using Rubber_Sheet.Models;

namespace Rubber_Sheet.Helpers
{
    public class ProcessDataPLC
    {
        //variable
        public bool isConnected = false;
        public bool isThreadRun = false;
        public ActUtlType plc = new ActUtlType();
        //
        

        int ReturnCode;
        short[] DeviceValue = new short[1];

        //constructor
        public ProcessDataPLC() { }
        //
        public void Connect()
        {
            int returncode;

            plc.ActLogicalStationNumber = 1;
            returncode = plc.Open();
            if (returncode == 0)
            {
                isConnected = true;
            }
        }
        public void Disconnect()
        {
            int returncode;
            returncode = plc.Close();
            if (returncode == 0)
            {
                isConnected = false;
            }
        }
        #region Thread Area (Update Status form PLC)
        Thread updatePlcThread;
        public void start()
        {
            updatePlcThread = new Thread(new ThreadStart(updatePlcParameters));
            updatePlcThread.IsBackground = true;
            updatePlcThread.Start();
            isThreadRun = true;
        }
        public void stop()
        {
            updatePlcThread.Abort();
            isThreadRun = false;
        }
        public void updatePlcParameters()
        {
            int ReturnCode;
            short[] DeviceValue;
            DeviceValue = new short[1];
            while (true)
            {
                Thread.Sleep(500); //500ms
                if (isConnected) {
                    try
                    {
                        ReturnCode = plc.ReadDeviceRandom2("M0", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.FanRun = true; else BitStatus.FanRun = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M1", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.FanErr = true; else BitStatus.FanErr = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M2", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.ScrRun = true; else BitStatus.ScrRun = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M3", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.ScrErr = true; else BitStatus.ScrErr = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M4", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.HumidityRun = true; else BitStatus.HumidityRun = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M5", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.HumidityStop = true; else BitStatus.HumidityStop = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M6", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.HeaterRun = true; else BitStatus.HeaterRun = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M7", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.HeaterErr= true; else BitStatus.HeaterErr = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M8", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.HeaterStop = true; else BitStatus.HeaterStop = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M9", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.PumpRun = true; else BitStatus.PumpRun = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M10", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.PumpErr = true; else BitStatus.PumpErr = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M11", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.SoundAlarm = true; else BitStatus.SoundAlarm = false;
                        
                        // M100-101-102
                        ReturnCode = plc.ReadDeviceRandom2("M100", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.SelectManualAuto = true; else BitStatus.SelectManualAuto = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M101", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.SelectAtSite = true; else BitStatus.SelectAtSite = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M102", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.SelectHMI = true; else BitStatus.SelectHMI = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M103", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.SelectRemote = true; else BitStatus.SelectRemote = false;

                        //Limit Xi Lanh
                        ReturnCode = plc.ReadDeviceRandom2("M136", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitXiLanh1UP = true; else BitStatus.bLimitXiLanh1UP = false;
                        ReturnCode = plc.ReadDeviceRandom2("M137", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitXiLanh1Down = true; else BitStatus.bLimitXiLanh1Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M140", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitXiLanh2UP = true; else BitStatus.bLimitXiLanh2UP = false;
                        ReturnCode = plc.ReadDeviceRandom2("M141", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitXiLanh2Down = true; else BitStatus.bLimitXiLanh2Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M142", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitXiLanh3UP = true; else BitStatus.bLimitXiLanh3UP = false;
                        ReturnCode = plc.ReadDeviceRandom2("M143", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitXiLanh3Down = true; else BitStatus.bLimitXiLanh3Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M144", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitXiLanh4UP = true; else BitStatus.bLimitXiLanh4UP = false;
                        ReturnCode = plc.ReadDeviceRandom2("M145", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitXiLanh4Down = true; else BitStatus.bLimitXiLanh4Down = false;

                        //Limit Servo
                        ReturnCode = plc.ReadDeviceRandom2("M146", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitSERVO1UP = true; else BitStatus.bLimitSERVO1UP = false;
                        ReturnCode = plc.ReadDeviceRandom2("M147", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitSERVO1Down = true; else BitStatus.bLimitSERVO1Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M150", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitSERVO2UP = true; else BitStatus.bLimitSERVO2UP = false;
                        ReturnCode = plc.ReadDeviceRandom2("M151", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitSERVO2Down = true; else BitStatus.bLimitSERVO2Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M152", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitSERVO3UP = true; else BitStatus.bLimitSERVO3UP = false;
                        ReturnCode = plc.ReadDeviceRandom2("M153", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitSERVO3Down = true; else BitStatus.bLimitSERVO3Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("M154", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitSERVO4UP = true; else BitStatus.bLimitSERVO4UP = false;
                        ReturnCode = plc.ReadDeviceRandom2("M155", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.bLimitSERVO4Down = true; else BitStatus.bLimitSERVO4Down = false;

                        //Update door
                        ReturnCode = plc.ReadDeviceRandom2("M132", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Door1 = true; else BitStatus.Door1 = false;
                        ReturnCode = plc.ReadDeviceRandom2("M133", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Door2 = true; else BitStatus.Door2 = false;
                        ReturnCode = plc.ReadDeviceRandom2("M134", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Door3 = true; else BitStatus.Door3 = false;
                        ReturnCode = plc.ReadDeviceRandom2("M135", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Door4 = true; else BitStatus.Door4 = false;

                        //Update status Servo
                        ReturnCode = plc.ReadDeviceRandom2("Y042", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Servo1Up = true; else BitStatus.Servo1Up = false;
                        ReturnCode = plc.ReadDeviceRandom2("Y043", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Servo1Down = true; else BitStatus.Servo1Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("Y044", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Servo2Up = true; else BitStatus.Servo2Up = false;
                        ReturnCode = plc.ReadDeviceRandom2("Y045", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Servo2Down = true; else BitStatus.Servo2Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("Y046", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Servo3Up = true; else BitStatus.Servo3Up = false;
                        ReturnCode = plc.ReadDeviceRandom2("Y047", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Servo3Down = true; else BitStatus.Servo3Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("Y050", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Servo4Up = true; else BitStatus.Servo4Up = false;
                        ReturnCode = plc.ReadDeviceRandom2("Y051", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.Servo4Down = true; else BitStatus.Servo4Down = false;

                        //Update status xiLanh
                        ReturnCode = plc.ReadDeviceRandom2("Y052", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.XiLanh1Up = true; else BitStatus.XiLanh1Up = false;
                        ReturnCode = plc.ReadDeviceRandom2("Y053", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.XiLanh1Down = true; else BitStatus.XiLanh1Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("Y054", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.XiLanh2Up = true; else BitStatus.XiLanh2Up = false;
                        ReturnCode = plc.ReadDeviceRandom2("Y055", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.XiLanh2Down = true; else BitStatus.XiLanh2Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("Y056", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.XiLanh3Up = true; else BitStatus.XiLanh3Up = false;
                        ReturnCode = plc.ReadDeviceRandom2("Y057", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.XiLanh3Down = true; else BitStatus.XiLanh3Down = false;
                        //
                        ReturnCode = plc.ReadDeviceRandom2("Y060", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.XiLanh4Up = true; else BitStatus.XiLanh4Up = false;
                        ReturnCode = plc.ReadDeviceRandom2("Y061", 1, out DeviceValue[0]);
                        if (DeviceValue[0] == 1) BitStatus.XiLanh4Down = true; else BitStatus.XiLanh4Down = false;

                        //Update Nhiet do
                        ReturnCode = plc.ReadDeviceBlock2("D0", 1, out DeviceValue[0]);
                        DataTemperature.TS1 = (Math.Round(DeviceValue[0] / (double)10, 2));
                        ReturnCode = plc.ReadDeviceBlock2("D1", 1, out DeviceValue[0]);
                        DataTemperature.TS2 = (Math.Round(DeviceValue[0] / (double)10, 2));
                        ReturnCode = plc.ReadDeviceBlock2("D2", 1, out DeviceValue[0]);
                        DataTemperature.TS3 = (Math.Round(DeviceValue[0] / (double)10, 2));
                        ReturnCode = plc.ReadDeviceBlock2("D3", 1, out DeviceValue[0]);
                        DataTemperature.TS4 = (Math.Round(DeviceValue[0] / (double)10, 2));
                        ReturnCode = plc.ReadDeviceBlock2("D4", 1, out DeviceValue[0]);
                        DataTemperature.TS5 = (Math.Round(DeviceValue[0] / (double)10, 2));
                        ReturnCode = plc.ReadDeviceBlock2("D5", 1, out DeviceValue[0]);
                        DataTemperature.TS6 = (Math.Round(DeviceValue[0] / (double)10, 2));
                        ReturnCode = plc.ReadDeviceBlock2("D7", 1, out DeviceValue[0]);
                        DataTemperature.TS_AVG = (Math.Round(DeviceValue[0] / (double)10, 2));
                        ReturnCode = plc.ReadDeviceBlock2("D8", 1, out DeviceValue[0]);
                        DataTemperature.TS_RH = (Math.Round(DeviceValue[0] / (double)10, 2));


                        //Update settings
                        ReturnCode = plc.ReadDeviceBlock2("D67", 1, out DeviceValue[0]);
                        DataTemperature.TimeHeater = DeviceValue[0];

                        ReturnCode = plc.ReadDeviceBlock2("D502", 1, out DeviceValue[0]);
                        DataTemperature.TimeSET = DeviceValue[0];

                        ReturnCode = plc.ReadDeviceBlock2("D500", 1, out DeviceValue[0]);
                        DataTemperature.TemperatureSET = (Math.Round(DeviceValue[0] / (double)10, 2));
                         
                        ReturnCode = plc.ReadDeviceBlock2("D501", 1, out DeviceValue[0]);
                        DataTemperature.HumiditySET = (Math.Round(DeviceValue[0] / (double)10, 2));

                        //Update data + time of PLC (READ DateTime)
                        ReturnCode = plc.ReadDeviceBlock2("D60", 1, out DeviceValue[0]);
                        DataTimePLC.second = DeviceValue[0];
                        ReturnCode = plc.ReadDeviceBlock2("D61", 1, out DeviceValue[0]);
                        DataTimePLC.minute = DeviceValue[0];
                        ReturnCode = plc.ReadDeviceBlock2("D62", 1, out DeviceValue[0]);
                        DataTimePLC.hour = DeviceValue[0];
                        ReturnCode = plc.ReadDeviceBlock2("D63", 1, out DeviceValue[0]);
                        DataTimePLC.day = DeviceValue[0];
                        ReturnCode = plc.ReadDeviceBlock2("D64", 1, out DeviceValue[0]);
                        DataTimePLC.month = DeviceValue[0];
                        ReturnCode = plc.ReadDeviceBlock2("D65", 1, out DeviceValue[0]);
                        DataTimePLC.year = DeviceValue[0];

                    }
                    catch { }
                }
            }
        }
        #endregion


        #region Set SERVO UP - DOWN
        public void SetServo1Up()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M329", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M329", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetServo1Down()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M330", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M330", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetServo2Up()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M331", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M331", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetServo2Down()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M332", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M332", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetServo3Up()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M333", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M333", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetServo3Down()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M334", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M334", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetServo4Up()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M335", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M335", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetServo4Down()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M336", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M336", 1, ref DeviceValue[0]);
            }
            catch { }

        }

        #endregion

        #region SET XI-LANH UP - DOWN
        public void SetXiLanh1Up()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M321", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M321", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetXiLanh1Down()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M322", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M322", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetXiLanh2Up()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M323", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M323", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetXiLanh2Down()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M324", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M324", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetXiLanh3Up()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M325", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M325", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetXiLanh3Down()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M326", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M326", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetXiLanh4Up()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M327", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M327", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetXiLanh4Down()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M328", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M328", 1, ref DeviceValue[0]);
            }
            catch { }

        }

        #endregion

        #region Set PUMP ON OFF
        public void SetPumpON()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M342", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M342", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetPumpOFF()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M350", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M350", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        #endregion

        #region Set Control for Main Home
        public void SetSCROn()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M341", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M341", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetSCROff()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M349", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M349", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetFANOn()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M340", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M340", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetFANOff()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M348", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M348", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetHumidityOn()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M343", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M343", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetHumidityOff()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M351", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M351", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetHeaterOn()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M344", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M344", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        public void SetHeaterOff()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M345", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M345", 1, ref DeviceValue[0]);
            }
            catch { }

        }
        //
        public void SetSoundReset()
        {
            if (!isConnected) return;
            //
            try
            {
                DeviceValue[0] = 1;
                ReturnCode = plc.WriteDeviceRandom2("M313", 1, ref DeviceValue[0]);
                DeviceValue[0] = 0;
                ReturnCode = plc.WriteDeviceRandom2("M313", 1, ref DeviceValue[0]);
            }
            catch { }

        }

        #endregion

        #region Update data SETTINGs 
        public void SetTimeOut(short value)
        {
            if (!isConnected) return;
            try
            {
                DeviceValue[0] = value;
                ReturnCode = plc.WriteDeviceBlock2("D502", 1, ref DeviceValue[0]);
            }
            catch { }
        }
        public void SetTempSET(float fTempSET)
        {
            if (!isConnected) return;
            //
            var bytes = BitConverter.GetBytes(fTempSET); //42.2 = 0x CD CC 28 42 => 0x4228CCCD ; 0x4228 ->D541 ; 0xCCCD -> D540
            int iTempSET1 = (bytes[3] << 8) | bytes[2];  //D541
            int iTempSET2 = (bytes[1] << 8) | bytes[0];  //D540
            //
            try
            {
                DeviceValue[0] = (short)iTempSET1;
                ReturnCode = plc.WriteDeviceBlock2("D541", 1, ref DeviceValue[0]);
                //
                DeviceValue[0] = (short)iTempSET2;
                ReturnCode = plc.WriteDeviceBlock2("D540", 1, ref DeviceValue[0]);
            }
            catch { }
        }
        public void SetHumiditySET(float fHumiditySET)
        {
            if (!isConnected) return;
            //
            var bytes = BitConverter.GetBytes(fHumiditySET); //42.2 = 0x CD CC 28 42 => 0x4228CCCD ; 0x4228 ->D541 ; 0xCCCD -> D540
            int iHumiditySET1 = (bytes[3] << 8) | bytes[2];  //D543
            int iHumiditySET2 = (bytes[1] << 8) | bytes[0];  //D542
            //
            try
            {
                DeviceValue[0] = (short)iHumiditySET1;
                ReturnCode = plc.WriteDeviceBlock2("D543", 1, ref DeviceValue[0]);
                //
                DeviceValue[0] = (short)iHumiditySET2;
                ReturnCode = plc.WriteDeviceBlock2("D542", 1, ref DeviceValue[0]);
            }
            catch { }
        }
        #endregion
    }
}
