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
        public static DateTime GetOnDiskLastModifiedDate ()
        {
            if (File.Exists (SerializedFileName))
                return File.GetLastWriteTime (SerializedFileName);

            return DateTime.MinValue;
        }

        public static Serializer loadEverythingFromGDrive ()
        {
            GDrive.CommandExecuter drive = new GDrive.CommandExecuter (SerializedFileName);
            IsOnDriveNewer ();
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
        public static int IsOnDriveNewer ()
        {
            GDrive.CommandExecuter drive = new GDrive.CommandExecuter (SerializedFileName);
            DateTime driveTime  = drive.GetLastModifiedDate ();
            DateTime ondiskTime = GetOnDiskLastModifiedDate ();

            int isDriveBigger = DateTime.Compare (driveTime, ondiskTime);
            //Tests in a 10 minutes radius, if tey are modified in 10 minutes, it return 0 which means identical
            if ( isDriveBigger < 0)
                driveTime = driveTime.AddMinutes (10);
            else
                driveTime = driveTime.AddMinutes (-10);

            int isModifiedDriveBigger = DateTime.Compare (driveTime, ondiskTime);    
            if (isModifiedDriveBigger != isDriveBigger)
                return 0;
            
            return isDriveBigger;
        }
    }
}
