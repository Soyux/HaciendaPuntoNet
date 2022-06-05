using MHBrokerUtilities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerUtilities.FileManagement
{
    public class MasterFile : IMasterFile, IDisposable
    {
        private bool disposedValue;

        public string GenerarGUID()
        {
            return Guid.NewGuid().ToString();
        }
        public bool ExisteArchivo(string direccion)
        {
            return File.Exists(direccion);
        }//end of ExisteArchivo
        public void RemoveCRLF(string direccion)
        {
            var temp = LeerArchivoSinCRLF(direccion);
            File.WriteAllText(direccion, temp); //temp.Replace("\n", "").Replace("\r", "");
        }
        public void EscribirArchivo(string direccion, dynamic contenido)
        {

            File.AppendAllText(direccion, contenido + "\r\n");
        }

        public void EscribirStream(string direccion, Stream content)
        {
            FileStream fs = File.Create(direccion);
            content.CopyTo(fs);
            fs.Close();
        }


        public string LeerArchivoSinCRLF(string direccion)
        {
            var temp = File.ReadAllText(direccion);
            return temp.Replace("\n", string.Empty).Replace("\r", string.Empty).Replace("xmlns=" +  "".ComillasDobles, "");
        }
        public void EliminarArchivo(string direccion)
        {
            File.Delete(direccion);
        }
        public void WriteBytes(string direccion, byte[] data)
        {
            File.WriteAllBytes(direccion, data);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MasterFile()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public string Base64DeEncode(string plainText)
        {
            var plainTextBytes = System.Convert.FromBase64String(plainText);
            return System.Text.ASCIIEncoding.UTF8.GetString(plainTextBytes);
        }

    }//end of class

}//end of namespace
