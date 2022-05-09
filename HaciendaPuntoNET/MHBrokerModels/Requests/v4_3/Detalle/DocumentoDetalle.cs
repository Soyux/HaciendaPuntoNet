using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class DocumentoDetalle : IDocumentoDetalle
    {
        public ILineaDetalle[] LineaDetalle { get; set; }
        public IOtrosCargos[] OtrosCargos { get; set; }
    }//end of class
}
