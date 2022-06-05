using MHBrokerContracts.Requests.Security;
using System.Xml;

namespace MHBrokerLogic.Contracts
{
    public interface IMasterFirma
    {
        public Task<XmlDocument> FirmarDocumento(XmlDocument documentoOriginal);

    }//end of interface

}//end of namespace
