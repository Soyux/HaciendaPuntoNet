using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerUtilities.ExtensionMethods;
using MHBrokerContracts.Requests.IDocumento.Detalle;


namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class CodigoComercial : ICodigoComercial
    {
        public string Tipo { get => Tipo; set => value.LengthLimit(2); }
        public string Codigo { get => Codigo; set => value.LengthLimit(20); }
    }
}
