using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle;
using MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado;
using MHBrokerContracts.Requests.v4_3.IDocumento.Resumen;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3{
    public class TiqueteElectronico : ITiqueteElectronico
    {
        //Encabezado
        public string CodigoActividad { get; set => value.LengthLimit();}
        public string Clave { get ; set ; }
        public string NumeroConsecutivo { get ; set ; }
        public DateTime FechaEmision { get ; set ; }
        public ICliente Emisor { get ; set ; }
        public ICliente Receptor { get ; set ; }
        public string CondicionVenta { get ; set ; }
        public string PlazoCredito { get ; set ; }
        public string MedioPago { get ; set ; }
        //Detalle
        public ILineaDetalle[] LineaDetalle { get ; set ; }
        public IOtrosCargos[] OtrosCargos { get ; set ; }
        public ICodigoTipoMoneda CodigoTipoMoneda { get ; set ; }
        
        //Resumen
        public double TotalServGravados { get ; set ; }
        public double TotalServExentos { get ; set ; }
        public double TotalMercanciasGravadas { get ; set ; }
        public double TotalMercExonerada { get ; set ; }
        public double TotalGravado { get ; set ; }
        public double TotalExento { get ; set ; }
        public double TotalExonerado { get ; set ; }
        public double TotalVenta { get ; set ; }
        public double TotalDescuentos { get ; set ; }
        public double TotalVentaNeta { get ; set ; }
        public double TotalImpuesto { get ; set ; }
        public double TotalIVADevuelto { get ; set ; }
        public double TotalOtrosCargos { get ; set ; }
        public double TotalComprobante { get ; set ; }
    }
}
