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
        static private Settings _instance = null;
        static public  Settings Get //Singleton
        {
            get
            {
                if (_instance == null)
                    _instance = new Settings ();

                return _instance;
            }
            private set { }
        }

        public GeneralSettings General = new GeneralSettings ();

        [Serializable] //TODO megcsinalni rendes serializalast
        public class GeneralSettings
        {
            public bool isGDriveSave    = false;
            public bool isGDriveLoad    = false;
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
