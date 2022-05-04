using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado
{
    public interface IFax
    {

        public int CodigoPais { get; set; }
        public int NumTelefono { get; set; }

    }
}
