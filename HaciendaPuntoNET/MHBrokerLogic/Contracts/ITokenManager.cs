using MemoryVault;
using MHBrokerContracts.Requests.Security;
using MHBrokerUtilities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerLogic.Contracts
{
    public interface ITokenManager
    {
         
        public Task<IToken> GetToken();
        public Task<IToken> RefreshToken(string token);
        public void CerrarSesion(string token);
        
        public IToken ParseJSON(string response);

    }//end of interface

}//end of namespace
