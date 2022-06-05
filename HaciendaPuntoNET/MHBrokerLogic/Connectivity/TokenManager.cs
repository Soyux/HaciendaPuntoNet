using MemoryVault;
using MHBrokerContracts.Requests.Security;
using MHBrokerLogic.Contracts;
using MHBrokerUtilities.Contracts;

namespace MHBrokerLogic.Connectivity
{
    public class TokenManager:ITokenManager
    {
        ISecurity _isecurity { get; set; }
        //public IMasterHTTP _imasterhttp { get; set; }
        IMasterJSON _imasterjson { get; set; }
        IHandler _ihandler { get; set; }
        string URLToken { get; set; }
        string _grant_type { get; set; }

        public TokenManager(ISecurity isecurity, IMasterJSON ijson,IHandler ihandler)
        {
            _isecurity = isecurity;
            _imasterjson = ijson;
            _ihandler = ihandler;
        }

        public async Task<IToken> GetToken()
        {
            URLToken = await _ihandler.GetValueMemory("");
            _grant_type = "password";
            var username = _imasterjson.URLEncode(_isecurity.UserName);
            var password = _imasterjson.URLEncode(_isecurity.PINCertificado);
             
            _imasterjson.PostJSONAsync(URLToken, "grant_type=" + _grant_type +
                "&client_id=" + _isecurity.environment +
                "&username=" + username +
                "&password=" + password);

            var response = await _imasterjson.GetStringResponse();
            return ParseJSON(response);
        }//end of GetToken

        public async Task<IToken> RefreshToken(string token)
        {
            URLToken = await _ihandler.GetValueMemory("");
            _grant_type = "refresh_token";
            _imasterjson.PostJSONAsync(URLToken, "POST", "grant_type=" + _grant_type + "&client_id=" + _isecurity.environment + "&refresh_token=" + token);
           
            var response = await _imasterjson.GetStringResponse();
            return ParseJSON(response);
        }

        public async void CerrarSesion(string token)
        {
            URLToken = await _ihandler.GetValueMemory("");
            _imasterjson.PostJSONAsync(URLToken, "POST", "client_id=" + _isecurity.environment + "&refresh_token=" + token);

            var response = await _imasterjson.GetStringResponse();
        }

        public IToken ParseJSON(string response)
        {
            IToken token = new Token();
            _imasterjson.LoadJSON(response);
            token.access_token = _imasterjson.LookupItem("access_token");
            token.expires_in = _imasterjson.LookupItem("expires_in");
            token.refresh_expires_in = _imasterjson.LookupItem("refresh_expires_in");
            token.refresh_token = _imasterjson.LookupItem("refresh_token");
            token.token_type = _imasterjson.LookupItem("token_type");
            token.id_token = _imasterjson.LookupItem("access_token");
            //id_token = tempJSON.LookupItem("id_token");
            token.not_before_policy = _imasterjson.LookupItem("not-before-policy");
            token.session_state = _imasterjson.LookupItem("session_state");

            return token;
        }
    }//end of class

}//end of namespace
