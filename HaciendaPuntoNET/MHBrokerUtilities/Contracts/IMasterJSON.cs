using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerUtilities.Contracts
{
    public interface IMasterJSON
    {        
        public string URLEncode(string value);
        public Task<string> GetStringResponse();
        public HttpResponseMessage GetRawResponse();
         public void LoadJSON(string originalJSON);
        public string LookupItem(string searchParam);
        public object DeconvertJSON(string jsonresponse);
        public string GetValueJSON(string jsonresponse, string titulo);
        public void PostJSONAsync(string url, string data, string accessToken="");
        public void GetJSONAsync(string url, string accessToken);
    }
}
