using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubber_Sheet.Models
{
    public class BitStatus
    {
        // =======================read D ===============================
        //public double TS1 = 0;
        //public double TS2 = 0;
        //public double TS3 = 0;
        //public double TS4 = 0;
        //public double TS5 = 0;
        //public double TS6 = 0;

        //public double tempInSide = 0;
        //public double humidity = 0;

        // ==========================READ M =========================
        static public bool FanRun;   // M0
        static public bool FanErr;   // M1
        static public bool ScrRun;  // M2
        static public bool ScrErr;   // M3
        static public bool HumidityRun;  // M4
        static public bool HumidityStop;  // M5
        static public bool HeaterRun;    // M6
        static public bool HeaterErr;
        static public bool HeaterStop;
        static public bool PumpRun;
        static public bool PumpErr;  // M10
        static public bool SoundAlarm;  //M11

        // status mote
        static public bool SelectManualAuto;   // M100
        static public bool SelectAtSite;   // M101
        static public bool SelectHMI;  // M102
        static public bool SelectRemote;   // M103


        // status door motor
        static public bool Door1;
        static public bool Door2;
        static public bool Door3;
        static public bool Door4;
        //
        static public bool Servo1Up;
        static public bool Servo1Down;
        static public bool Servo2Up;
        static public bool Servo2Down;
        static public bool Servo3Up;
        static public bool Servo3Down;
        static public bool Servo4Up;
        static public bool Servo4Down;
        //
        static public bool XiLanh1Up;
        static public bool XiLanh1Down;
        static public bool XiLanh2Up;
        static public bool XiLanh2Down;
        static public bool XiLanh3Up;
        static public bool XiLanh3Down;
        static public bool XiLanh4Up;
        static public bool XiLanh4Down;
        //
        static public bool bLimitXiLanh1UP;     //LIMITED XILANH 1 FORWARD
        static public bool bLimitXiLanh1Down;   //LIMITED XILANH 1 BACKWARD;
        static public bool bLimitXiLanh2UP;     //LIMITED XILANH 2 FORWARD
        static public bool bLimitXiLanh2Down;   //LIMITED XILANH 2 BACKWARD
        static public bool bLimitXiLanh3UP;     //LIMITED XILANH 3 FORWARD
        static public bool bLimitXiLanh3Down;   //LIMITED XILANH 3 BACKWARD
        static public bool bLimitXiLanh4UP;     //LIMITED XILANH 4 FORWARD
        static public bool bLimitXiLanh4Down;   //LIMITED XILANH 4 BACKWARD
        //
        static public bool bLimitSERVO1UP;      //LIMITED  SERVO 1 FORWARD
        static public bool bLimitSERVO1Down;    //LIMITED SERVO 1 BACKWARD
        static public bool bLimitSERVO2UP;      //LIMITED SERVO 2 FORWARD
        static public bool bLimitSERVO2Down;    //LIMITED SERVO 2 BACKWARD  
        static public bool bLimitSERVO3UP;      //LIMITED SERVO 3 FORWARD
        static public bool bLimitSERVO3Down;    //LIMITED SERVO 3 BACKWARD
        static public bool bLimitSERVO4UP;      //LIMITED SERVO 4 FORWARD
        static public bool bLimitSERVO4Down;    //LIMITED SERVO 4 BACKWARD



    }

    public class DataTemperature
    {
        static public double TS1 = 0;
        static public double TS2 = 0;
        static public double TS3 = 0;
        static public double TS4 = 0;
        static public double TS5 = 0;
        static public double TS6 = 0;
        static public double TS_AVG = 0;   //trung binh
        static public double TS_RH = 0;
        //
        static public short TimeHeater = 0;
        static public short TimeSET = 0;
        static public double TemperatureSET = 0;
        static public double HumiditySET = 0;
    }

    public class ControlPlc
    {
        public bool XiLanh1UpControl;
        public bool XiLanh1DownControl;
        public bool XiLanh2UpControl;
        public bool XiLanh2DownControl;
        public bool XiLanh3UpControl;
        public bool XiLanh3DownControl;
        public bool XiLanh4UpControl;
        public bool XiLanh4DownControl;
        public bool Servo1FowardControl;
        public bool Servo1BackWardControl;
        public bool Servo2FowardControl;
        public bool Servo2BackWardControl;
        public bool Servo3FowardControl;
        public bool Servo3BackWardControl;
        public bool Servo4FowardControl;
        public bool Servo4BackWardControl;

        public bool FanControl;
        public bool ScrControl;
        public bool PumpControl;
        public bool HumidityControl;
        public bool HeaterRunControl;
        public bool HeaterStopControl;
        public bool ModManualAuto;   // 0 manual ; 1 Auto

    }
    public class DataTimePLC
    {
        static public short day = 01;
        static public short month = 01;
        static public short year = 2020;
        static public short hour = 00;
        static public short minute = 00;
        static public short second = 00;
    }

    public class UserData
    {
        //User
        static public string stUserName = null;
        static public string stUserPasswork = null;
        static public string stUserPosition = null;
        static public string stUserPhone = null;
        static public int stUserId = 0;
    }
}
