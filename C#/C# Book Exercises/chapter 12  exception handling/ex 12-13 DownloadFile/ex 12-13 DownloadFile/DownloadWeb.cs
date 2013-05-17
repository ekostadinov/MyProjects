using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ex_12_13_DownloadFile
{
    class DownloadWeb
    {
        static void Main()
        {
            //store location
            string localFilepath = @"D:\file.jpg";
            //create new web client
            WebClient client = new WebClient();
            try
            {
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", localFilepath);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }           
        }

        //In brief, the method below makes a request for the file, verifies that the response code is one of OK,
        //Moved or Redirect and also that the ContentType is an image. If those conditions are true,
        //the file is downloaded.
        
         private static void DownloadRemoteImageFile(string uri, string fileName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        
            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ((response.StatusCode == HttpStatusCode.OK || 
                response.StatusCode == HttpStatusCode.Moved || 
                response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image",StringComparison.OrdinalIgnoreCase))
            {
        
                // if the remote file was found, download oit
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }
            }
        }
         



    }
}
