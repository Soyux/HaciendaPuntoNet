using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerUtilities.ExtensionMethods;
using MHBrokerContracts.Requests.IDocumento.Detalle;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class LineaDetalle : ILineaDetalle
    {
        public int NumeroLinea { get; set; }
        public string PartidaArancelaria { get =>PartidaArancelaria; set => value.LengthLimit(12); }
        public string Codigo { get => Codigo; set => value.LengthLimit(13); }
        public ICodigoComercial CodigoComercial { get; set; }
        public double Cantidad { get => Cantidad; set => value.LengthLimit(13,3); }
        public string UnidadMedida { get => UnidadMedida; set => value.LengthLimit(15); }
        public string UnidadMedidaComercial { get => UnidadMedidaComercial; set => value.LengthLimit(15); }
        public string Detalle { get => Detalle; set => value.LengthLimit(200); }
        public double PrecioUnitario { get => PrecioUnitario; set => value.LengthLimit(13, 5); }
        public double MontoTotal { get => MontoTotal; set => value.LengthLimit(13, 5); }
        public IDescuento Descuento { get; set; }
        public double SubTotal { get => SubTotal; set => value.LengthLimit(13, 5); }
        public double BaseImponible { get => BaseImponible; set => value.LengthLimit(13, 5); }
        public IImpuesto Impuesto { get; set; }
        public IExoneracion Exoneracion { get; set; }
        public double ImpuestoNeto { get => ImpuestoNeto; set => value.LengthLimit(13, 5); }
        public double MontoTotalLinea { get => MontoTotalLinea; set => value.LengthLimit(13, 5); }
    }//end of class
}//end of namespace
