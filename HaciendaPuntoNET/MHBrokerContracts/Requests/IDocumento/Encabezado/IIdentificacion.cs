using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.IDocumento.Encabezado
{
    public interface IIdentificacion
    {
        public string Tipo { get; set; }
        public string Numero { get; set; }

    }
}
