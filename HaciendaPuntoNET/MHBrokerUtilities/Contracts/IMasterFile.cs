using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerUtilities.Contracts
{
    public interface IMasterFile
    {
        public string GenerarGUID();        
        public bool ExisteArchivo(string direccion);
        public void RemoveCRLF(string direccion);
        public void EscribirArchivo(string direccion, dynamic contenido);
        public void EscribirStream(string direccion, Stream content);
        public string LeerArchivoSinCRLF(string direccion);
        public void EliminarArchivo(string direccion);
        public void WriteBytes(string direccion, byte[] data);
        public string Base64Encode(string plainText);
        public string Base64DeEncode(string plainText);       

    }
}
