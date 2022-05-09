using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Resumen
{
    public interface IDocumentoResumen
    {
        public ICodigoTipoMoneda CodigoTipoMoneda { get; set; }
        public double TotalServGravados { get; set; }
        public double TotalServExentos { get; set; }
        public double TotalMercanciasGravadas { get; set; }
        public double TotalMercExonerada { get; set; }
        public double TotalGravado { get; set; }
        public double TotalExento { get; set; }
        public double TotalExonerado { get; set;}
        public double TotalVenta { get; set; }
        public double TotalDescuentos { get; set; }
        public double TotalVentaNeta { get; set; }
        public double TotalImpuesto { get; set; }
        public double TotalIVADevuelto { get; set; }
        public double TotalOtrosCargos { get; set; }
        public double TotalComprobante { get; set; }

    }//end of interface

}//end of namespace
