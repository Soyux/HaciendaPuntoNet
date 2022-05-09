using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle; 
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class LineaDetalle : ILineaDetalle
    {
        public int NumeroLinea { get; set; }
        private string _partidaArancelaria;
        public string PartidaArancelaria
        {
            get => _partidaArancelaria;
            set { _partidaArancelaria = value.LengthLimit(12); }
        }
        private string _codigo;
        public string Codigo
        {
            get => _codigo;
            set { _codigo = value.LengthLimit(13); }
        }
        public ICodigoComercial CodigoComercial { get; set; }
        private double _cantidad;
        public double Cantidad
        {
            get => _cantidad;
            set { _cantidad= value.FormatLimit(16,2); }
        }
        private string _unidadmedida;
        public string UnidadMedida
        {
            get => _unidadmedida;
            set { _unidadmedida = value.LengthLimit(15); }
        }

        private string _unidadmedidacomercial;
        public string UnidadMedidaComercial
        {
            get => _unidadmedidacomercial;
            set { _unidadmedidacomercial = value.LengthLimit(20); }
        }
        private string _detalle;
        public string Detalle
        {
            get => _detalle;
            set { _detalle = value.LengthLimit(200); }
        }
        private double _preciounitario;
        public double PrecioUnitario
        {
            get => _preciounitario;
            set { _preciounitario = value.FormatLimit(18,5); }
        }
        private double _montototal;
        public double MontoTotal {
            get => _montototal;
            set { _montototal = value.FormatLimit(18, 5); }
        }
        public IDescuento Descuento { get; set; }
        private double _subtotal;
        public double SubTotal
        {
            get => _subtotal;
            set { _subtotal = value.FormatLimit(18, 5); }
        }
        private double _baseimponible;
        public double BaseImponible
        {
            get => _baseimponible;
            set { _baseimponible = value.FormatLimit(18, 5); }
        }
        public IImpuesto Impuesto { get; set; }
        public IExoneracion Exoneracion { get; set; }
        private double _impuestoneto;
        public double ImpuestoNeto
        {
            get => _impuestoneto;
            set { _impuestoneto = value.FormatLimit(18, 5); }
        }
        private double _montoTotalLinea;
        public double MontoTotalLinea
        {
            get => _montoTotalLinea;
            set { _montoTotalLinea = value.FormatLimit(18, 5); }
        }
    }
}
