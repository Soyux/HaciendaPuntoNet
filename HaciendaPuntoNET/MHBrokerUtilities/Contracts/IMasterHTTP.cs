using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerUtilities.Contracts
{
    public interface IMasterHTTP
    {
        public WebRequest request { get; set; }
        public Stream dataStream  { get; set; }
        public string status { set; get; }
        public Task<IMasterHTTP> Init(string url,string method, string data, bool json = false, string token = "");
        public string URLEncode(string valor);
        public Task<string> GetResponse();
        public void DownloadFile(string source, string destination);

    }//end of interface

}//end of namespace
