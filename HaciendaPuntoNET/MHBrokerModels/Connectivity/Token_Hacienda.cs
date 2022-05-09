using MHBrokerContracts.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox.Contracts;

namespace MHBrokerModels.Connectivity
{
    public  class Token_Hacienda : IToken_Hacienda
    {
        private IMasterJSON mjson;

        public Token_Hacienda(IMasterJSON mjson) { 
            this.mjson= mjson;
        }

        public string access_token { get; set; }
        public string expires_in { get; set; }
        public string refresh_expires_in { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public string id_token { get; set; }
        public string not_before_policy { get; set; }
        public string session_state { get; set; }
        public void ParseJSON(string response) {
            mjson.LoadJSON(response);
            access_token = mjson.LookupItem("access_token");
            expires_in = mjson.LookupItem("expires_in");
            refresh_expires_in = mjson.LookupItem("refresh_expires_in");
            refresh_token = mjson.LookupItem("refresh_token");
            token_type = mjson.LookupItem("token_type");
            id_token = mjson.LookupItem("access_token");
            //id_token = tempJSON.LookupItem("id_token");
            not_before_policy = mjson.LookupItem("not-before-policy");
            session_state = mjson.LookupItem("session_state");
        }//end of ParseJson
    }//end of class
}//end of namespace
