using MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado;
using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Fax
{
    public class Fax : IFax
    {
        int _codigopais;
        public int CodigoPais
        {
            get => _codigopais;
            set { _codigopais = value.LengthLimit(3); }
        }
        int _numtelefono;
        public int NumTelefono
        {
            get => _numtelefono;
            set { _numtelefono = value.LengthLimit(20); }
        }
            
    }
}
