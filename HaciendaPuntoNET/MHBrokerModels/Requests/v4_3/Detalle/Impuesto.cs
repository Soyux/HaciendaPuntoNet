using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Detalle;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class Impuesto : IImpuesto
    {
        public string Codigo { get => Codigo; set => value.LengthLimit(2); }
        public string CodigoTarifa { get => CodigoTarifa; set => value.LengthLimit(2); }
        public double Tarifa { get =>Tarifa; set =>value.LengthLimit(2,2); }
        public double FactorIVA { get => FactorIVA; set => value.LengthLimit(1, 4); }
        public double Monto { get => Monto; set => value.LengthLimit(13, 5); }
        public double MontoExportacion { get => MontoExportacion; set => value.LengthLimit(13, 5); }
    }
}
