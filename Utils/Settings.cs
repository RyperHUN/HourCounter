using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Settings
    {
        private Settings ()
        {
        }
        static private Settings _instance = null;
        static public Settings Get //Singleton
        {
            get
            {
                if (_instance == null)
                    _instance = new Settings ();

                return _instance;
            }
            private set { }
        }

        public GeneralSettings General;

        public class GeneralSettings
        {
            public bool isGDriveSave;
        }
    }
}
