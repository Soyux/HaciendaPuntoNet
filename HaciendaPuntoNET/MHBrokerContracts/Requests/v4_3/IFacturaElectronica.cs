using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle;
using MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado;
using MHBrokerContracts.Requests.v4_3.IDocumento.Resumen;

namespace MHBrokerContracts.Requests.v4_3
{
    public interface IFacturaElectronica
    {
        public IDocumentoEncabezado encabezado { get; set; }
        public IDocumentoDetalle detalle { get; set; }
        public IDocumentoResumen resumen { get; set; }
    }
}
