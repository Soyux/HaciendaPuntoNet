using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MHBrokerUtilities.Contracts;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerUtilities.Net
{
    public class MasterHTTP : IMasterHTTP
    {
        public WebRequest request { get; set; }
        public Stream dataStream { get; set; }
        public string status { set; get; }
        
        public void DownloadFile(string source, string destination)
        {

            using (var client = new WebClient())
            {
                client.DownloadFile(source, destination);
            }
        }
                 
        public string URLEncode(string valor)
        {

            return System.Net.WebUtility.UrlEncode(valor);
        }

        //https://www.quora.com/How-do-I-post-JSON-data-to-API-using-C

        public async Task<IMasterHTTP> Init(string url, string method, string data, bool json = false, string token = "")
        {
            request = WebRequest.Create(url);

            if (method.Equals("GET") || method.Equals("POST"))
            {
                // Set the Method property of the request to POST.
                request.Method = method;
            }
            else
            {
                throw new Exception("Invalid Method Type");
            }

            // Create POST data and convert it to a byte array.
            string postData = data;
            byte[] byteArray = json ? Encoding.ASCII.GetBytes(postData) : Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.
            request.ContentType = json ? "application/json" : "application/x-www-form-urlencoded;charset=utf-8";

            if (!token.Blank())
            {

                request.PreAuthenticate = true;
                request.Headers.Add("Authorization", "Bearer " + token);

            }//fin de if

            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            dataStream = await request.GetRequestStreamAsync();

            // Write the data to the request stream.
            await dataStream.WriteAsync(byteArray, 0, byteArray.Length);

            // Close the Stream object.
            dataStream.Close();

            return this;
        }
 
        public async Task<string> GetResponse()
        {

            // Get the original response.
            WebResponse response = await request.GetResponseAsync();

            status = ((HttpWebResponse)response).StatusDescription;

            // Get the stream containing all content returned by the requested server.
            dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            var reader = new StreamReader(dataStream);

            // Read the content fully up to the end.
            string responseFromServer = await reader.ReadToEndAsync();

            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }//end of endresponse
         
    }//fin de class

}//end of namespace
