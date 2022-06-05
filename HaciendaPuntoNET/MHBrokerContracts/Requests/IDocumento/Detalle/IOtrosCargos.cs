using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.IDocumento.Detalle
{
    public interface IOtrosCargos
    {
        public string TipoDocumento { get; set; }
        public string NumeroIdentidadTercero { get; set; }
        public string NombreTercero { get; set; }
        public string Detalle { get; set; }
        public double Porcentaje { get; set; }
        public double MontoCargo { get; set; }
    }//end of interface

}//end of namespace
