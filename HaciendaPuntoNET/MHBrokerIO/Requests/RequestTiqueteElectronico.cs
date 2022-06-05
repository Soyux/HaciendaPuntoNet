using MHBrokerContracts.Requests.IDocumento;
using MHBrokerContracts.Requests.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerIO.Requests
{
    public struct RequestTiqueteElectronico
    {
        public ISecurity? IToken { get; set; }
        public IDocumento? IDocumento { get; set; }
    }//end of interface

}//end of namespace
