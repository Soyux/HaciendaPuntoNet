using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Contracts
{
    public interface IMasterHTTP
    {
        public void Setup(string url);
        public void Setup(string url, string method);
        public void Setup(string url, string method, string data, bool json = false, string token = "");
        public void DownloadFile(string source, string destination);
        public string URLEncode(string valor);
        public string GetResponse();
        public Task<string> GetResponseAsync();


    }//end of interface

}//end of namespace
