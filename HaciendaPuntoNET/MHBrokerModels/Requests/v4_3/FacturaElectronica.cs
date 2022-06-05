using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento;
using MHBrokerContracts.Requests.IDocumento.Detalle;  
using MHBrokerContracts.Requests.IDocumento.Encabezado;
using MHBrokerContracts.Requests.IDocumento.Resumen;

namespace MHBrokerModels.Requests.v4_3 {
    public struct FacturaElectronica : IFacturaElectronica
    {
        public IDocumentoEncabezado IEncabezado { get; set; }
        public IDocumentoDetalle IDetalle { get; set; }
        public IDocumentoResumen IResumen { get; set; }

        public void Dispose()
        {
            
        }
    }//end of struct
}//end of namespace
