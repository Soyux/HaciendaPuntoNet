using MHBrokerUtilities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerUtilities.Net
{
    public static class MasterXMLFactory
    {
        public static IMasterXML GetNewMasterXML()
        {
            var xml = new MasterXML();
            xml.CrearNuevoDocumento();
            return xml;
        }
    }
}
