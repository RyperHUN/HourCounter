using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public class TimeConverter
    {
        static readonly long MINTOSEC  = 60;  //Multiplying MINTOSEC Dividing SecToMin
        static readonly long HOURTOSEC = 3600;
        //TODO Maybe add optional parameter : hh[:mm[:ss]]
        //Format: min, mm:ss, hh:mm:ss
        public static Time StringToTime (string timeStr)
        {
            String[] timeArray = timeStr.Split(':');
            switch(timeArray.Length)
            {
                case 1:
                    return StringToTimeMM (timeStr);
                case 2:
                    return StringToTimeMMSS (timeStr);
                case 3:
                    return StringToTimeHHMMSS (timeStr);
                default:
                    throw new InvalidOperationException ("Wrong time string format");
            }
        }
        public static Time StringToTimeMM (string time)
        {
            long timeSeconds = ConvertStringToLongSafe (time) * MINTOSEC;
            return new Time (timeSeconds);
        }
        public static Time StringToTimeHHMMSS (string time)
        {
            String[] timeArray = time.Split(':');
            long timeSeconds = 0;
            try
            {
                if (timeArray.Length < 3)
                    throw new InvalidOperationException ("Not contains 2 :");

                timeSeconds += ConvertStringToLongSafe (timeArray[0]) * HOURTOSEC;
                timeSeconds += ConvertStringToLongSafe (timeArray[1]) * MINTOSEC;
                timeSeconds += ConvertStringToLongSafe (timeArray[2]); 
            }
            catch (InvalidOperationException exc)
            {
                throw exc;
            }

            return new Time (timeSeconds);
        }
        public static string TimeToStringHHMMSS (Time time)
        {
            long timeInSeconds = time.Seconds;

            long hour     = timeInSeconds / HOURTOSEC;
            timeInSeconds = timeInSeconds % HOURTOSEC; //Only time remains which is less than a hour
            long min      = timeInSeconds / MINTOSEC;
            timeInSeconds = timeInSeconds % MINTOSEC;  //Only seconds remains which is less than a minute
            long sec      = timeInSeconds;

            string hourStr = "" + hour;
            string minStr  = "" + min;
            string secStr  = "" + sec;
            if (hour <= 9)
                hourStr = "0" + hour;
            if (min <= 9)
                minStr = "0" + min;
            if (sec <= 9)
                secStr = "0" + sec;

            string result = hourStr + ":" + minStr + ":" + secStr;

            return result;
        }
        public static Time StringToTimeMMSS (string time)
        {
            String[] timeArray = time.Split(':');
            long timeSeconds = 0;
            try
            {
                if (timeArray.Length < 2)
                    throw new InvalidOperationException ("Not contains 1 :");

                timeSeconds += ConvertStringToLongSafe (timeArray[0]) * MINTOSEC;
                timeSeconds += ConvertStringToLongSafe (timeArray[1]);
            }
            catch (InvalidOperationException exc)
            {
                throw exc;
            }

            return new Time (timeSeconds);
        }
        //TODO Maybe add optional parameter : mm[:ss]
        public static string TimeToStringMMSS (Time time)
        {
            long timeInSeconds = time.Seconds;

            long min      = timeInSeconds / MINTOSEC;
            timeInSeconds = timeInSeconds % MINTOSEC; //Only seconds remains which is less than a minute
            long sec      = timeInSeconds;

            string minStr  = "" + min;
            string secStr  = "" + sec;
            if (min <= 9)
                minStr = "0" + min;
            if (sec <= 9)
                secStr = "0" + sec;

            string result = minStr + ":" + secStr;

            return result;
        }
        public static long ConvertStringToLongSafe (string num)
        {
            long result;
            if (Int64.TryParse (num, out result))
            {
                return result;
            }
            else
            {
                throw new InvalidOperationException ("Invalid string argument given");
            }
        }
        public static long ConvertMinToSec (long min)
        {
            return min * MINTOSEC;
        }
    }
}
