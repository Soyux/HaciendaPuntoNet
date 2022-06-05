using System.Security.Cryptography.X509Certificates;

namespace MHBrokerLogic.Firmado
{
    partial struct ReturnValue
    {
        public X509Certificate2 cert { get; set; }
        public string direccion { get; set; }
    }

}//end of namespace
