using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado
{
    public interface ICodigoComercial
    {
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        
    }
}
