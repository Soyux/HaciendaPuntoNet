using MHBrokerContracts.Requests.IDocumento.Resumen;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Resumen
{
    public class DocumentoResumen : IDocumentoResumen
    {
        public ICodigoTipoMoneda CodigoTipoMoneda { get; set; }
        public double TotalServGravados { get => TotalServGravados; set => value.LengthLimit(13, 5); }
        public double TotalServExentos{ get => TotalServExentos; set => value.LengthLimit(13, 5); }
        public double TotalServExonerado { get => TotalServExonerado; set => value.LengthLimit(13, 5); }
        public double TotalMercanciasGravadas{ get => TotalMercanciasGravadas; set => value.LengthLimit(13, 5); }
        public double TotalMercExonerada { get => TotalMercExonerada; set => value.LengthLimit(13, 5); }
        public double TotalMercanciasExentas { get => TotalMercanciasExentas; set => value.LengthLimit(13, 5); }
        public double TotalGravado{ get => TotalGravado; set => value.LengthLimit(13, 5); }
        public double TotalExento{ get => TotalExento; set => value.LengthLimit(13, 5); }
        public double TotalExonerado{ get => TotalExonerado; set => value.LengthLimit(13, 5); }
        public double TotalVenta{ get => TotalVenta; set => value.LengthLimit(13, 5); }
        public double TotalDescuentos{ get => TotalDescuentos; set => value.LengthLimit(13, 5); }
        public double TotalVentaNeta{ get => TotalVentaNeta; set => value.LengthLimit(13, 5); }
        public double TotalImpuesto{ get => TotalImpuesto; set => value.LengthLimit(13, 5); }
        public double TotalIVADevuelto{ get => TotalIVADevuelto; set => value.LengthLimit(13, 5); }
        public double TotalOtrosCargos{ get => TotalOtrosCargos; set => value.LengthLimit(13, 5); }
        public double TotalComprobante{ get => TotalComprobante; set => value.LengthLimit(13, 5); }
    }//end of class

}//end of namespace
