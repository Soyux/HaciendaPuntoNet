using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerUtilities.ExtensionMethods;
using MHBrokerContracts.Requests.IDocumento.Encabezado;

namespace MHBrokerModels.Requests.v4_3.Encabezado
{
    public class Telefono : ITelefono
    {
        public int CodigoPais { get => CodigoPais; set => value.LengthLimit(3); }
        public int NumTelefono { get => NumTelefono; set => value.LengthLimit(20); }
    }
}
