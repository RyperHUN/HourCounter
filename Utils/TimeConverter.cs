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
        static readonly long MINTOSEC  = 60;
        static readonly long HOURTOSEC = 3600;
        static public long stringToTime (string time) ///TODO Sorround all stringToTime with try catch
        {
            String[] timeArray = time.Split(':');
            long timeSeconds = 0;
            try
            {
                timeSeconds += ConvertStringToLongSafe (timeArray[0]) * HOURTOSEC;
                timeSeconds += ConvertStringToLongSafe (timeArray[1]) * MINTOSEC;
                timeSeconds += ConvertStringToLongSafe (timeArray[2]); //TODO Maybe sec remove
            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show ("Invalid string argument given. Please give in the following format: hh:mm:ss"); ///TODO Talan nem az o felelossege ezt kiírni jobb lene ott kiíratni ahol hívódik
                throw exc;
            }

            return timeSeconds;
        }
        static public string timeToString (long time)
        {
            long hour = time / HOURTOSEC;
            time = time % HOURTOSEC;
            long min  = time / MINTOSEC;
            time = time % MINTOSEC;
            long sec  = time;

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
    }
}
