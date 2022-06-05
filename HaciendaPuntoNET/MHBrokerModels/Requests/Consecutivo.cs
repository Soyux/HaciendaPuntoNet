using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerContracts.Enums;
using MHBrokerContracts.Requests.Security;

namespace MHBrokerModels.Requests
{
    public class Consecutivo : IConsecutivo
    {
        private bool disposedValue;

        public int IDDocumento { get; set; }
        public int Terminal { get; set; }
        public int NumeroLocal { get; set; }
        public eTipoComprobante TipoComprobante { get; set; }
        public eSituacionComprobante SituacionComprobante { get; set; }

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
        // ~Consecutivo()
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
    }
}
