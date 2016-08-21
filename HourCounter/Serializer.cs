using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using HabitUtils;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Utils;

namespace HourCounter
{
    [Serializable]
    class Serializer : ISerializable
    {
        public Activity _activityContainer;
        public HabitController _habitController;
        private static readonly string SerializedFileName = "data.bin";

        public Serializer ()
        {
        }

        public void Save ()
        {
            SaveEverythingToDisk (Settings.Get.General.isAutomaticSave);
            SaveEverythingToGDrive (Settings.Get.General.isGDriveSave);
        }

        public void Load ()
        {

        }
        /// TODO Hibakezelest hozzaadni! Ha valtoik a struktura nemfogja betlteni az adott objektumot.
        protected Serializer (SerializationInfo info, StreamingContext context)
        {
            _activityContainer = (Activity)info.GetValue ("activityContainer", typeof (Activity));
            _habitController   = (HabitController)info.GetValue ("habitController", typeof (HabitController));
            Settings settings  = Settings.Get;
            settings           = (Settings)info.GetValue ("settings", typeof(Settings));
        }

        public void GetObjectData (SerializationInfo info, StreamingContext context)
        {
            info.AddValue ("activityContainer", _activityContainer);
            info.AddValue ("habitController", _habitController);
            info.AddValue ("settings", Settings.Get);
        }

        private void SaveEverythingToDisk (bool allowedToSave)
        {
            if (allowedToSave)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream (SerializedFileName,
                                                FileMode.Create,
                                                FileAccess.Write,
                                                FileShare.None);
                formatter.Serialize (stream, this);
                stream.Close ();
            }
        }

        public static Serializer loadEverythingFromDisk ()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream (SerializedFileName,
                                                FileMode.Open,
                                                FileAccess.Read,
                                                FileShare.Read);
                Serializer ser = (Serializer)formatter.Deserialize (stream);
                stream.Close ();
                
                return ser;
            }
            catch (SerializationException exc)
            {
                Console.WriteLine (exc.ToString ());
                return null;
            }
            catch (FileNotFoundException /*exc*/)
            {
                return null;
            }
        }

        public static Serializer loadEverythingFromGDrive ()
        {
            GDrive.CommandExecuter drive = new GDrive.CommandExecuter (SerializedFileName);
            if (drive.IsFileExist ())
            {
                drive.DownloadFile ();
                return loadEverythingFromDisk ();
            }
            else
                return null;
        }

        public void SaveEverythingToGDrive (bool allowedToSave)
        {
            if (allowedToSave)
            {
                GDrive.CommandExecuter drive = new GDrive.CommandExecuter (SerializedFileName);
                if( drive.IsFileExist ())
                {
                    drive.UpdateFile ();//Update
                }
                else
                {
                    drive.UploadFile ();//upload
                }
            }
        }
    }
}
