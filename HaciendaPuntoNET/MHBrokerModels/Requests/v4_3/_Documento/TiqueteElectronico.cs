using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.v4_3;
using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle;
using MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado;
using MHBrokerContracts.Requests.v4_3.IDocumento.Resumen;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Documento{
    public class TiqueteElectronico : ITiqueteElectronico
    {
        public IDocumentoEncabezadoSinReceptor encabezado { get; set; }
        public IDocumentoDetalle detalle { get; set; }
        public IDocumentoResumen resumen { get; set; }
    
    }//end of TiqueteElectronico

}//end of namespace
