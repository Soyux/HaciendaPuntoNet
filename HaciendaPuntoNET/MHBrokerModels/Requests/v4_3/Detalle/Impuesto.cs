using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class Impuesto : IImpuesto
    {
        private string _codigo;
        public string Codigo {
            get => _codigo;
            set { _codigo = value.LengthLimit(2); }
        }
        private string _codigotarifa;
        public string CodigoTarifa {
            get => _codigotarifa;
            set { _codigotarifa = value.LengthLimit(2); }
        }

        private double _tarifa;
        public double Tarifa
        {
            get => _tarifa;
            set { _tarifa = value.FormatLimit(4,2); }
        }

        public double _factorIva;
        public double FactorIVA
        {
            get => _factorIva;
            set { _factorIva = value.FormatLimit(5, 4); }
        }
        private double _monto;
        public double Monto
        {
            get => _monto;
            set { _monto = value.FormatLimit(18, 5); }
        }
        private double _montoexportacion;
        public double MontoExportacion
        {
            get => _montoexportacion;
            set { _montoexportacion = value.FormatLimit(18, 5); }
        }
    }
}
