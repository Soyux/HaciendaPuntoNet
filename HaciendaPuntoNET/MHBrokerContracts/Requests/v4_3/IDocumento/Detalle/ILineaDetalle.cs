using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Detalle
{
    public interface ILineaDetalle
    {
        public int NumeroLinea { get; set; }
        public string PartidaArancelaria { get; set; }
        public string Codigo { get; set; }
        public double Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public string Detalle { get; set; }
        public double PrecioUnitario { get; set; }
        public double MontoTotal { get; set; }
        public IDescuento Descuento { get; set; }

        public ICodigoComercial CodigoComercial { get; set; }
        public double SubTotal { get; set; }
        public double BaseImponible { get; set; }
        public IImpuesto Impuesto { get; set; }
        public IExoneracion Exoneracion { get; set; }
        public double ImpuestoNeto { get; set; }
        public double MontoTotalLinea{get;set;}

    }//end of interface

}//end of namespace
