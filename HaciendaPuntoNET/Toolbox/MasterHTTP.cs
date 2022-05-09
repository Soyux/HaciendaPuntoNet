using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Toolbox.Contracts;

namespace Toolbox
{
    public class MasterHTTP:IMasterHTTP
    {
        private WebRequest request;
        private Stream dataStream;
        public string Status { get; set; }

        public void DownloadFile(string source, string destination)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(source, destination);
            }
        }

        public void Setup(string url)
        {
            request = WebRequest.Create(url);
        }

        public void Setup(string url, string method)            
        {

            Setup(url);
            if (method.Equals("GET") || method.Equals("POST"))
            {
                // Set the Method property of the request to POST.
                request.Method = method;
            }
            else
            {
                throw new Exception("Invalid Method Type");
            }
        }

        public void Setup(string url, string method, string data, bool json = false, string token = "")
        {
            Setup(url, method);
            var myhttpwebrequest = (HttpWebRequest)request;

            // Create POST data and convert it to a byte array.
            string postData = data;
            byte[] byteArray = json ? Encoding.ASCII.GetBytes(postData) : Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.
            request.ContentType = json ? "application/json" : "application/x-www-form-urlencoded;charset=utf-8";

            if (token.Trim().Length > 0)
            {

                request.PreAuthenticate = true;
                request.Headers.Add("Authorization", "Bearer " + token);

            }//fin de if

            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            dataStream = request.GetRequestStream();

            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);

            // Close the Stream object.
            dataStream.Close();
        }
        
        public string URLEncode(string valor)
        {
            return System.Net.WebUtility.UrlEncode(valor);
        }
        public string GetResponse()
        {
            // Get the original response.
            WebResponse response = request.GetResponse();

            this.Status = ((HttpWebResponse)response).StatusDescription;

            // Get the stream containing all content returned by the requested server.
            dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content fully up to the end.
            string responseFromServer = reader.ReadToEnd();

            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }

        public async Task<string> GetResponseAsync()
        {
            // Get the original response.
            var response = request.GetResponse();

            this.Status = ((HttpWebResponse)response).StatusDescription;

            // Get the stream containing all content returned by the requested server.
            dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content fully up to the end.
            string responseFromServer = reader.ReadToEnd();

            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }

    }//end of class
}//end of namespace
