using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Detalle
{
    public interface IOtrosCargos
    {
        public string TipoDocumento { get; set; }
        public string NumeroIdentidadTercero { get; set; }
        public string NombreTercero { get; set; }
        public string Detalle { get; set; }
        public string Porcentaje { get; set; }
        public string MontoCargo { get; set; }
    }//end of interface

}//end of namespace
