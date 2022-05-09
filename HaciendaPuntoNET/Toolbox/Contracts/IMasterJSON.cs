using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Contracts
{
    public interface IMasterJSON
    {
        public string PostJSON(string url, dynamic requestItem);
        public Task<string> PostJSONAsync(string url, dynamic requestItem);
        public Task<string> GetJSONAsync(string url);
        public void LoadJSON(string originalJSON);
        public string LookupItem(string searchParam);
        public object DeconvertJSONToObject(string jsonresponse);
        public dynamic DeconvertJSONToDynamic(string jsonresponse);
        public string ConvertObjectoToJSON(dynamic input);
        public string GetValueJSON(string jsonresponse, string titulo);
        
    }//end of class
}//end of namespace
