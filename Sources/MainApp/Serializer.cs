﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using HabitUtils;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Utils;
using System.Windows.Forms;
using System.Threading;

namespace HourCounter
{
    [Serializable]
    class Serializer : ISerializable
    {
        public Activity _activityContainer;
        public HabitController _habitController;
        public static readonly string SerializedFileName = "data.bin";
        private System.Windows.Forms.Timer automaticSaveTimer = new System.Windows.Forms.Timer();

        public Serializer ()
        {
        }
        public void TurnOnAutomaticSaveTimer ()
        {
            //TODO Automatic save turn on/off on settings
            automaticSaveTimer.Interval = (int)TIME.Minutes (30).Miliseconds;
            automaticSaveTimer.Tick +=  (object a, EventArgs e) => Save();
            automaticSaveTimer.Start ();
        }

        public void Save ()
        {
            Thread background = new Thread ( () =>
            {
                SaveEverythingToDisk (true);
                SaveEverythingToGDrive (Settings.Get.General.isGDriveSave);
            });
            background.IsBackground = true;
            background.Start ();
        }

        public static Serializer Load ()
        {
            try
            {
                Serializer diskLoaded = loadEverythingFromDisk ();
                if (Settings.Get.General.isGDriveLoad && Settings.Get.General.loadLetMeDecide) 
                {
                    DialogResult result = MessageBox.Show("Do you want to load from GDrive?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        return loadEverythingFromGDrive ();
                    }
                    else
                    {
                        return diskLoaded;
                    }
                }
                else
                {
                    if (diskLoaded != null)
                    {
                        if (Settings.Get.General.isGDriveLoad)
                        {
                            if (IsOnDriveNewer () > 0)
                            {
                                return loadEverythingFromGDrive (); //If this is newer
                            }
                        }
                        return diskLoaded; //If this is newer
                    }
                    else //File not found
                    {
                        DialogResult result = MessageBox.Show("No save file found. Do you want to load from Google Drive?", "Confirmation", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                        {
                            return loadEverythingFromGDrive ();
                        }
                    }
                }
            }
            //catch (Google)
            catch (AggregateException /*exc*/)
            {
                MessageBox.Show ("Error accessing Google Drive, loading from disk");
                return loadEverythingFromDisk ();
            }
            
            return null;
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
                string tempFileName = SerializedFileName + "temp.bin";
                using (Stream stream = new FileStream (tempFileName,
                                                        FileMode.Create,
                                                        FileAccess.Write,
                                                        FileShare.None))
                {
                    formatter.Serialize (stream, this);
                }
                MyFile.OverwriteFile (SerializedFileName, tempFileName);
            }
        }
        public static Serializer loadEverythingFromDisk ()
        {
            return loadEverythingFromDisk (SerializedFileName);
        }
        public static Serializer loadEverythingFromDisk (string fileName)
        {
            try
            {
                Serializer ser = null;
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream (fileName,
                                                        FileMode.Open,
                                                        FileAccess.Read,
                                                        FileShare.Read))
                {
                    stream.Position = 0;
                    ser = (Serializer)formatter.Deserialize (stream);
                }
                
                return ser;
            }
            catch (SerializationException exc)
            {
                MessageBox.Show (exc.ToString ());
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
        public static Serializer forceLoadFromGdrive (string saveFileName)
        {
            GDrive.CommandExecuter drive = new GDrive.CommandExecuter (SerializedFileName);
            if (drive.IsFileExist ())
            {
                drive.DownloadFile (saveFileName);
                return loadEverythingFromDisk (saveFileName);
            }
            
            return null;
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

    public static class MyFile
    {
        /// <summary>
        /// Replaces destination with from, if destination don't exist just renames from
        /// FROM WILL BE DELETED!
        /// </summary>
        public static void OverwriteFile (string destination, string from)
        {
            if (File.Exists (destination))
            {
                File.Replace (from, destination, "toDelete.bin");
                File.Delete ("toDelete.bin");
            }
            else
            {
                File.Move(from, destination);
            }
        }
    }
}
