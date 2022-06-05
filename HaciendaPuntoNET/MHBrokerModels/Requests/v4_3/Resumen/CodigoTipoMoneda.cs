using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Resumen;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Resumen
{
    public class CodigoTipoMoneda : ICodigoTipoMoneda
    {
        public string CodigoMoneda { get =>CodigoMoneda; set =>value.LengthLimit(3) ; }
        public double TipoCambio { get => TipoCambio; set => value.LengthLimit(13,5); }
    }
}
