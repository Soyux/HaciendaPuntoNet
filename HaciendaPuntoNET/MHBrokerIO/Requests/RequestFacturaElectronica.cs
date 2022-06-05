
using MHBrokerContracts.Requests.IDocumento;
using MHBrokerContracts.Requests.Security;

namespace MHBrokerIO.Requests
{
    public struct RequestFacturaElectronica 
    {
        public ISecurity? ISecurity;
        public IDocumento? IDocumento;

    }//end of struct

}//end of namespace
