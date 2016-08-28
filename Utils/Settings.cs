using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    [Serializable]
    public class Settings : ISerializable
    {
        private Settings ()
        {
        }
        private static readonly Object syncObject = new Object();
        private static          Settings _instance = null;

        public  static Settings Get //Singleton
        {
            get
            {
                lock (syncObject) ///TODO maybe more safer
                {
                    if (_instance == null)
                        _instance = new Settings ();

                    return _instance;
                }
            }
        }

        public GeneralSettings General = new GeneralSettings ();
        public TimerSettings   Timers  = new TimerSettings ();

        [Serializable] //TODO megcsinalni rendes serializalast
        public class GeneralSettings
        {
            public bool isGDriveSave        = false;
            public bool isGDriveLoad        = false;
            public bool loadAlwaysLoadNewer = true;
            public bool loadLetMeDecide     = false;
        }

        [Serializable] //TODO megcsinalni rendes serializalast
        public class TimerSettings
        {
            public bool timerRememberLastTime = true;
            public bool timerSetDefaultTime   = false;
            public long timerSetTime = 0;

            public bool pomodRememberLastTime = true;
            public bool pomodSetDefaultTime   = false;
            public long pomodWorkSetTime = 0;
            public long pomodRestSetTime = 0;
        }

        ///////////////
        //Serialization
        public void GetObjectData (SerializationInfo info, StreamingContext context)
        {
            info.AddValue ("SettingsInstance", _instance);
            info.AddValue ("GeneralSettings", General);   
        }
        protected Settings (SerializationInfo info, StreamingContext context)
        {
            _instance = (Settings)info.GetValue ("SettingsInstance", typeof(Settings));
            General   = (GeneralSettings)info.GetValue ("GeneralSettings", typeof(GeneralSettings));
        }
    }
}
