using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.IDocumento.Encabezado
{
    public interface IFax
    {

        public int CodigoPais { get; set; }
        public int NumTelefono { get; set; }

    }
}
