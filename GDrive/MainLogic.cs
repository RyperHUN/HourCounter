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
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes = {  DriveService.Scope.DriveFile };
        static string ApplicationName = "Hour Counter";

        static void Main (string[] args)
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
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            //downloadFile (service);
            //removeFile (service, "dataActivity.bin");
            //updateFile (service,"dataActivity.bin",".bin",getFileId (service, "dataActivity.bin"));
            UploadFile (service, "dataActivity.bin", ".bin");

            downloadFile (service);
            Console.Read ();

        }

        public static string getFileId (DriveService _service, string fieName)
        {
            var requestList = _service.Files.List ();
            requestList.Corpus = FilesResource.ListRequest.CorpusEnum.User;
            requestList.Q = $"name = '{fieName}'";
            FileList foundedFiles = requestList.Execute ();
            IList<File> foundedFileList = foundedFiles.Files;

            string fileId = null;
            foreach (var file in foundedFileList)
            {
                fileId = file.Id;  ///TODO Exception if more than one
                Console.WriteLine ("\nName: " + file.Name + "  ID: " + file.Id);
            }

            return fileId;
        }
        /// Download a file
        /// Documentation: https://developers.google.com/drive/v2/reference/files/get
        /// 

        /// a Valid authenticated DriveService
        /// File resource of the file to download
        /// location of where to save the file including the file name to save it as.
        /// 
        public static void downloadFile (DriveService _service)//, File _fileResource, string _saveTo)
        {
            String fileId = getFileId (_service, "dataActivity.bin");

            var stream = new System.IO.MemoryStream();

            var request = _service.Files.Get(fileId);
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

            using (System.IO.FileStream destinationFile = new System.IO.FileStream ("dataActivity.bin", System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                stream.WriteTo (destinationFile);
            }
        }

        public static void RemoveFile (DriveService _service, string fileName)
        {
            string fileId = getFileId (_service, fileName);

            var deleteRequest = _service.Files.Delete(fileId);
            deleteRequest.Execute ();
        }


        public static File UpdateFile (DriveService _service, string _uploadFile, string _uploadFileExtension, string _fileId)
        {
            //.Files.Update ()
            if (System.IO.File.Exists (_uploadFile))
            {
                File body = new File();
                body.Name = System.IO.Path.GetFileName (_uploadFile);
                body.Description = "File updated by Diamto Drive Sample";
                body.MimeType = MimeTypeMap.GetMimeType (_uploadFileExtension);
                //body.Parents = new List<String> ();

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

        public static File UploadFile (DriveService _service, string _uploadFile, string _uploadFileExtension)
        {
            //.Files.Update ()
            if (System.IO.File.Exists (_uploadFile))
            {
                File body = new File();
                body.Name = System.IO.Path.GetFileName (_uploadFile);
                body.Description = "File updated by Diamto Drive Sample";
                body.MimeType = MimeTypeMap.GetMimeType (_uploadFileExtension);
                //body.Parents = new List<String> ();

                // File's content.
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    var request = _service.Files.Create (body, stream, MimeTypeMap.GetMimeType (_uploadFileExtension));
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
    }
}
