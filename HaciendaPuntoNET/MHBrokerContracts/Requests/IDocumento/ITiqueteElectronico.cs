using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Detalle;
using MHBrokerContracts.Requests.IDocumento.Resumen;
using MHBrokerContracts.Requests.IDocumento.Encabezado;

namespace MHBrokerContracts.Requests.IDocumento
{
    public interface ITiqueteElectronico : IDocumento
    {
        public IDocumentoEncabezado IEncabezado { get; set; }
        public IDocumentoDetalle IDetalle { get; set; }
        public IDocumentoResumen IResumen { get; set; }
         
    }//end of interface

}//end of namespace
