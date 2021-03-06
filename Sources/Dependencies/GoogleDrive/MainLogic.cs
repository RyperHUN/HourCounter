﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MimeTypes;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GDrive
{
    //All commands are executed at the set file name
    public class CommandExecuter
    {
        ///TODO Update file names to be able to use File Paths and Extensions easier
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
         //Here you can set what can access the program
        static string ApplicationName = "Hour Counter";
        static string[] Scopes        = {  DriveService.Scope.DriveFile };

        private string       _fileName = null;
        private DriveService _service  = null;
        private string       _fileId   = null;

        public CommandExecuter (String fileName)
        {
            InitializeDrive ();
            SetFileName (fileName);
        }

        public DateTime GetLastModifiedDate ()
        {
            if(!IsFileExist ())
                return DateTime.MinValue;

            var request                  = _service.Revisions.List (_fileId);
            RevisionList ListContainer   = request.Execute ();
            IList<Revision> revisionList = ListContainer.Revisions;

            Revision last = revisionList.Last ();
            return (DateTime)last.ModifiedTime;
        }

        public void SetFileName (string fileName)
        {
            _fileName = fileName;
            UpdateFileId ();
        }

        public void UpdateFileId ()
        {
            _fileId = CommandStatic.GetFileId (_service, _fileName); ///TODO Check hogy mivan ha nem létező fájlt adsz meg!
        }

        public bool IsFileExist ()
        {
            if (_fileId != null)
                return true;
            return false;
        }

        private void InitializeDrive ()
        {  ///TODO Lekezelni System Aggregate exceptiont! ha user nem ad hozzaferest
            UserCredential credential = CommandStatic.Authenticate (Scopes);

            // Create Drive API service.
            _service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
        public void DownloadFile ()
        {
            CommandStatic.DownloadFile (_service, _fileId, _fileName);
        }
        public void DownloadFile (string toSaveFileName)
        {
            CommandStatic.DownloadFile (_service, _fileId, toSaveFileName);
        }

        public void RemoveFile ()
        {
            CommandStatic.RemoveFile (_service, _fileId);
            _fileId = null;
        }

        public void UpdateFile ()
        {
           CommandStatic.UpdateFile (_service, _fileName, ".bin", _fileId);
        }

        public void UploadFile ()
        {
            CommandStatic.UploadFile (_service, _fileName, ".bin"); ///TODO Extension
        }

        public static bool IsAuthenticated ()
        {
            UserCredential credential = CommandStatic.Authenticate (Scopes);

            if (credential == null)
                return false;

            return true;
        }
    }
    public class CommandStatic
    {
        //Throws AggregateException if authenticaton fails
        public static UserCredential Authenticate (string[] Scopes)
        {
            UserCredential credential;

            using (var stream =
                new System.IO.FileStream ("Data/client_secret.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                        System.Environment.SpecialFolder.Personal);
                credPath = System.IO.Path.Combine (credPath, ".credentials/drive-hourcounter.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync (
                    GoogleClientSecrets.Load (stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore (credPath, true)).Result;
                Console.WriteLine ("Credential file saved to: " + credPath);
            }

            return credential;
        }

        public static string GetFileId (DriveService service, string fileName)
        {
            var requestList       = service.Files.List ();
            requestList.Corpus    = FilesResource.ListRequest.CorpusEnum.User;
            requestList.Q         = $"name = '{fileName}'";
            FileList foundedFiles = requestList.Execute ();

            IList<File> foundedFileList = foundedFiles.Files;

            if( foundedFileList.Count > 1)
                throw new Exception ("Error : More files found when downloading");
            if( foundedFileList.Count == 0)
                return null;

            return foundedFileList.First ().Id;
        }

        public static void DownloadFile (DriveService service, string fileId, string saveTo)// string _saveTo) //TODO SAVE TO
        {
            using (var stream = new System.IO.MemoryStream ())
            {
                
                var request = service.Files.Get(fileId);
                request.Fields = "size"; //Specify which fields to include in the response
                var test = request.Execute ();
                var fileSizeInBytes = test.Size;

                request.MediaDownloader.ProgressChanged +=
                (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Downloading:
                            {
                                Console.WriteLine($"Progress = {progress.BytesDownloaded/fileSizeInBytes}");
                                break;
                            }
                        case DownloadStatus.Completed:
                            {
                                Console.WriteLine ("Download complete.");
                                break;
                            }
                        case DownloadStatus.Failed:
                            {
                                Console.WriteLine ("Download failed.");
                                break;
                            }
                    }
                };
                request.Download (stream);

                using (System.IO.FileStream destinationFile = new System.IO.FileStream (saveTo, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    stream.WriteTo (destinationFile);
                }
            }
        }

        public static void RemoveFile (DriveService _service, string fileId)
        {
            var deleteRequest = _service.Files.Delete(fileId);
            deleteRequest.Execute ();
        }

        public static File UpdateFile (DriveService _service, string _uploadFile, string _uploadFileExtension, string _fileId)
        {
            if (System.IO.File.Exists (_uploadFile))
            {
                File body = SetFileAttributes (_uploadFile, _uploadFileExtension);
                // File's content.
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    FilesResource.UpdateMediaUpload request = _service.Files.Update(body, _fileId, stream, MimeTypeMap.GetMimeType(_uploadFileExtension));
                    request.Upload ();
                    return request.ResponseBody;
                }
                catch (Exception e)
                {
                    Console.WriteLine ("An error occurred: " + e.Message);
                    return null;
                }
            }
            else
            {
                Console.WriteLine ("File does not exist: " + _uploadFile);
                return null;
            }
        }

        public static File SetFileAttributes (string uploadFile, string uploadFileExtension)
        {
            File body = new File();
            body.Name = System.IO.Path.GetFileName (uploadFile);
            body.Description = "File uploaded by HourCounter";
            body.MimeType = MimeTypeMap.GetMimeType (uploadFileExtension);
            //body.Parents = new List<String> ();  ///TODO Set valid parent
            return body;
        }

        public static File UploadFile (DriveService service, string uploadFile, string uploadFileExtension)
        {
            if (System.IO.File.Exists (uploadFile))
            {
                File body = SetFileAttributes (uploadFile, uploadFileExtension);
                // File's content.
                byte[] byteArray = System.IO.File.ReadAllBytes(uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    var request = service.Files.Create (body, stream, MimeTypeMap.GetMimeType (uploadFileExtension));
                    request.Upload ();
                    return request.ResponseBody;
                }
                catch (Exception e)
                {
                    Console.WriteLine ("An error occurred: " + e.Message);
                    return null;
                }
            }
            else
            {
                Console.WriteLine ("File does not exist: " + uploadFile);
                return null;
            }
        }
    }
}
