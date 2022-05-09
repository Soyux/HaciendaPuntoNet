using MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado;
using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Encabezado
{    public class Identificacion : IIdentificacion
    {
        private string _tipo;
        public string Tipo
        {
            get => _tipo;
            set { _tipo = value.LengthLimit(2); }
        }
        private string _numero;
        public string Numero
        {
            get => _numero;
            set { _numero = value.LengthLimit(12); }
        }

    }//end of Identificacion
}
