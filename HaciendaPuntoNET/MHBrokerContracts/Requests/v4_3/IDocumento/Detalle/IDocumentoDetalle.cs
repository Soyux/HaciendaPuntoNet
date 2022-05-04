using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Detalle
{
    public interface IDocumentoDetalle
    {
        ILineaDetalle[] LineaDetalle { get; set; }
        IOtrosCargos[] OtrosCargos { get; set; }

    }//end of interface
}
