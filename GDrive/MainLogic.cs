using Google.Apis.Auth.OAuth2;
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

namespace GDrive
{
    //All commands are executed at the set file name
    class CommandExecuter
    {
        ///TODO Update file names to be able to use File Paths and Extensions easier
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes        = {  DriveService.Scope.DriveFile }; //Here you can set what can access the program
        static string ApplicationName = "Hour Counter";

        private string       _fileName = null;
        private DriveService _service  = null;
        private string       _fileId   = null;

        public CommandExecuter (String fileName)
        {
            SetFileName (fileName);
            InitializeDrive ();
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

        private void InitializeDrive ()
        {
            UserCredential credential;

            using (var stream =
                new System.IO.FileStream ("client_secret.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
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
                //Console.WriteLine ("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            _service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public void DownloadFile ()
        {
            CommandStatic.DownloadFile (_service, _fileName);
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
    }
    class CommandStatic
    {
        public static string GetFileId (DriveService service, string fileName)
        {
            var requestList       = service.Files.List ();
            requestList.Corpus    = FilesResource.ListRequest.CorpusEnum.User;
            requestList.Q         = $"name = '{fileName}'";
            FileList foundedFiles = requestList.Execute ();

            IList<File> foundedFileList = foundedFiles.Files;

            if( foundedFileList.Count > 1)
                throw new Exception ("Error : More files found when downloading");

            string fileId = foundedFileList.First ().Id;
            return fileId;
        }

        public static void DownloadFile (DriveService service, string fileName)// string _saveTo) //TODO SAVE TO
        {
            String fileId = GetFileId (service, fileName);

            var stream = new System.IO.MemoryStream();

            var request = service.Files.Get(fileId);
            request.MediaDownloader.ProgressChanged +=
            (IDownloadProgress progress) =>
            {
                switch (progress.Status)
                {
                    case DownloadStatus.Downloading:
                        {
                            Console.WriteLine (progress.BytesDownloaded);
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

            using (System.IO.FileStream destinationFile = new System.IO.FileStream (fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                stream.WriteTo (destinationFile);
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
