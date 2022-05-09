using MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado;
using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Encabezado
{
    public class Telefono : ITelefono
    {
        private int _codigopais;
        public int CodigoPais {

            get => _codigopais;
            set { _codigopais = value.LengthLimit(3);}        
        }
        int _numerotelefono;
        public int NumTelefono
        {
            get => _numerotelefono;
            set { _numerotelefono = value.LengthLimit(20); }
        }
    }
}
