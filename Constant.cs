using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Ionic.Zip;
using static Google.Apis.Drive.v3.DriveService;

namespace RDPClientApplication
{
    class Constant
    {
        public static System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, Size size)
        {
            // Get the image current width

            int sourceWidth = imgToResize.Width;
            // Get the image current height
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            // Calculate width and height with new desired size
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);
            // New Width and Height
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        public static string zipFile(List<string> filePaths)
        {
            try
            {
                using (ZipFile zipFile = new ZipFile())
                {
                    foreach (string filename in filePaths)
                    {
                        zipFile.AddFile(filename);
                    }
                    if (System.IO.File.Exists("ZippedCopy.zip"))
                    {
                        System.IO.File.Delete("ZippedCopy.zip");
                    }
                    zipFile.Save("ZippedCopy.zip");
                }
                return "ZippedCopy.zip";
            }
            catch (Exception ex)
            {
                return null;
            }

            using (ZipFile zipFile = new ZipFile())
            {
                foreach (string filename in filePaths)
                {
                    zipFile.AddFile(filename);
                }
                if (System.IO.File.Exists("ZippedCopy.zip"))
                {
                    System.IO.File.Delete("ZippedCopy.zip");
                }
                zipFile.Save("ZippedCopy.zip");
            }
        }

        public static DriveService ConnectToDrive()
        {
            IDictionary<string, string> tokens = ReadXMLForGoogleAPIToken();

            try
            {
                var tokenResponse = new TokenResponse
                {
                    AccessToken = tokens["AccessToken"],
                    RefreshToken = tokens["RefreshToken"],
                };


                var applicationName = tokens["applicationName"]; // Use the name of the project in Google Cloud
                var username = tokens["username"]; // Use your email


                var apiCodeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
                {
                    ClientSecrets = new ClientSecrets
                    {
                        ClientId = tokens["ClientId"],
                        ClientSecret = tokens["ClientSecret"]
                    },
                    Scopes = new[] { Scope.Drive },
                    DataStore = new FileDataStore(applicationName)
                });


                var credential = new UserCredential(apiCodeFlow, username, tokenResponse);


                var service = new DriveService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = applicationName
                });
                return service;
            }
            catch (
            Exception ex)
            {

                return null;
            }


        }

        public static List<string> UploadFileOnDrive(string fileName)
        {

            var service = ConnectToDrive();

            if (service != null)
            {

                var body = new Google.Apis.Drive.v3.Data.File();
                body.Name = System.IO.Path.GetFileName(fileName);
                body.Description = "File uploaded by Diamto Drive Sample";
                body.MimeType = GetMimeType(fileName);

                // File's content.
                byte[] byteArray = System.IO.File.ReadAllBytes(fileName);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);

                try
                {

                    var request = service.Files.Create(body, stream, GetMimeType(fileName));
                    request.Fields = "id, webContentLink, name";
                    request.Upload();

                    var permission = new Permission { AllowFileDiscovery = true, Type = "anyone", Role = "reader" };
                    var fileId = request.ResponseBody.Id;
                    service.Permissions.Create(permission, fileId).Execute();

                    Console.WriteLine(request.ResponseBody.WebContentLink);
                    List<string> details = new List<string>();
                    //details.Add("test");
                    details.Add(request.ResponseBody.Name.ToString());
                    details.Add(request.ResponseBody.WebContentLink.ToString());



                    return details;

                    //return request.ResponseBody;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);

                    return null;
                }
            }
            else
            {
                return null;
            }
            //var uploadFile = fileName;


        }
        public static string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            Console.WriteLine("Mime type of file - " + mimeType);
            return mimeType;
        }

        private static IDictionary<string, string> ReadXMLForGoogleAPIToken()
        {
            IDictionary<string, string> tokens = new Dictionary<string, string>();
            using (XmlReader reader = XmlReader.Create("GoogleAPITokens.xml"))
            {
                Console.WriteLine("reading xml");

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {

                        switch (reader.Name.ToString())
                        {
                            case "AccessToken":
                                // Console.WriteLine(reader.ReadString());
                                tokens.Add("AccessToken", reader.ReadString());
                                //Console.WriteLine("datbase = " + databaseName);
                                break;
                            case "RefreshToken":
                                //Console.WriteLine(reader.ReadString());
                                tokens.Add("RefreshToken", reader.ReadString());
                                break;
                            case "ClientId":
                                //Console.WriteLine(reader.ReadString());
                                tokens.Add("ClientId", reader.ReadString());
                                break;
                            case "ClientSecret":
                                tokens.Add("ClientSecret", reader.ReadString());
                                break;
                            case "applicationName":
                                tokens.Add("applicationName", reader.ReadString());
                                break;
                            case "username":
                                tokens.Add("username", reader.ReadString());
                                break;


                        }
                    }
                }
                return tokens;
            }
        }
    }
}
