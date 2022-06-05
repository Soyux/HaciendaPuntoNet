using MHBrokerContracts.Requests.IDocumento.Detalle;
using MHBrokerContracts.Requests.IDocumento.Encabezado;
using MHBrokerContracts.Requests.IDocumento.Resumen;
using System;
using System.Collections.Generic;
using System.Text;


namespace MHBrokerContracts.Requests.IDocumento
{
    public interface IFacturaElectronica : IDocumento
    {
        public IDocumentoEncabezado IEncabezado { get; set; }
        public IDocumentoDetalle IDetalle { get; set; }
        public IDocumentoResumen IResumen { get; set; }
    }//end of class

}//end of namespace
