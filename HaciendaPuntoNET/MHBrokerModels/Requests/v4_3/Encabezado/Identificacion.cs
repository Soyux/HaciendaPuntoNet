using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Encabezado;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Encabezado
{
    public class Identificacion : IIdentificacion
    {
        public string Tipo { get => Tipo; set => value.LengthLimit(2); }
        public string Numero { get => Numero; set => value.LengthLimit(12); }
    }
}
