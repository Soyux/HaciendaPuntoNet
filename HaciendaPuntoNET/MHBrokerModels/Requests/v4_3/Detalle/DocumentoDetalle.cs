using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Detalle; 

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class DocumentoDetalle : IDocumentoDetalle
    {
        public ILineaDetalle[] LineaDetalle { get; set; }
        public IOtrosCargos[] OtrosCargos { get; set; }
    }
}
