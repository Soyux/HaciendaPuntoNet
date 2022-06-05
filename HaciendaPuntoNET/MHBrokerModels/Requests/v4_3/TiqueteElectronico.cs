using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento;
using MHBrokerContracts.Requests.IDocumento.Encabezado;
using MHBrokerContracts.Requests.IDocumento.Detalle;
using MHBrokerContracts.Requests.IDocumento.Resumen; 

namespace MHBrokerModels.Requests.v4_3
{
    public class TiqueteElectronico : ITiqueteElectronico
    {
        private bool disposedValue;

        public IDocumentoEncabezado IEncabezado { get; set; }
        public IDocumentoDetalle IDetalle { get; set; }
        public IDocumentoResumen IResumen { get; set; }

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
        // ~TiqueteElectronico()
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
    }//end of class

}//end of namespace
