using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class Descuento : IDescuento
    {
        private double _montodescuento;
        public double MontoDescuento {
            get => _montodescuento;
            set { _montodescuento = value.FormatLimit(18, 5); }
        }
        private string _naturalezaDescuento;
        public string NaturalezaDescuento
        {
            get => _naturalezaDescuento;
            set { _naturalezaDescuento = value.LengthLimit(80);}
        }
    }
}
