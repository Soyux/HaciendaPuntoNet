using MHBrokerUtilities.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerUtilities.Net
{
    public class MasterJSON:IMasterJSON
    {
        HttpResponseMessage httpresponse { get; set; }
        public JsonTextReader reader { get; set; }
        public async Task<string> GetStringResponse()
        {
            var temp= await httpresponse.Content.ReadAsStringAsync();
            return temp.ToString();
        }

        public HttpResponseMessage GetRawResponse()
        {
            return httpresponse;
        }

        //public async string PostJSON(string url, dynamic requestItem)
        //{
        //    string request = JsonConvert.SerializeObject(requestItem);
        //    IMasterHTTP webhelper =await new MasterHTTP().Init(url, "POST", request, true);
        //    string response = webhelper.GetResponse();
        //    return response;
        //}
              
        public void LoadJSON(string originalJSON)
        {
            reader = new JsonTextReader(new StringReader(originalJSON));
        }
        public string LookupItem(string searchParam)
        {

            var lastitem = "";
            var resultado = "";
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    var valor = reader.Value.ToString();

                    if (reader.TokenType.ToString() == "PropertyName")
                    {
                        lastitem = valor;
                    }
                    else
                    {
                        if (lastitem.Equals(searchParam))
                        {
                            resultado = valor;
                            break;
                        }
                    }//fin de if
                }//fin de while
            }
            return resultado;

        }//end of LookupItem
        public object DeconvertJSON(string jsonresponse)
        {
            var request = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(jsonresponse);
            return request;
            //var webhelper = new MasterHTTP(url, "POST", request, true);
            //string response = webhelper.GetResponse();

            //return response;
        }

        public string GetValueJSON(string jsonresponse, string titulo)
        {
            try
            {
                var request = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(jsonresponse);

                return request.GetValue(titulo).ToString();
            }
            catch (Exception e)
            {
                return "";
            }
            
        }

        public async void PostJSONAsync(string url, string data, string accessToken="")
        {
            var client = new HttpClient();
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (!accessToken.Blank())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }
            httpresponse = await client.PostAsync(url, new StringContent(data, Encoding.UTF8, "application/json"));
  
        }//end of PostJSONAsync

        public async void GetJSONAsync(string url, string accessToken)
        {
            HttpClient client = new HttpClient();
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
              httpresponse = await client.GetAsync(url); 
        }//fin de metodo

        public string URLEncode(string value)
        {
            return System.Net.WebUtility.UrlEncode(value);
        }
    }//fin de class
}//fin denamespace
 
