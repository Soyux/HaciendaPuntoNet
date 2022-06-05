using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.IDocumento.Detalle
{
    public interface IDocumentoDetalle
    {
        ILineaDetalle[] LineaDetalle { get; set; }
        IOtrosCargos[] OtrosCargos { get; set; }

    }//end of interface
}
