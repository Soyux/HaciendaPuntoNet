using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Detalle;
using MHBrokerContracts.Requests.IDocumento.Encabezado;
using MHBrokerContracts.Requests.IDocumento.Resumen;
namespace MHBrokerContracts.Requests.IDocumento
{
    public interface IDocumento:IDisposable
    {
        public IDocumentoEncabezado IEncabezado { get; set; }
        public IDocumentoDetalle IDetalle { get; set; }
        public IDocumentoResumen IResumen { get; set; }
    }
}
