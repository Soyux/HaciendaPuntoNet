using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.IDocumento.Detalle
{
    public interface IExoneracion
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public string NombreInstitucion { get; set; }

        public DateTime FechaEmision { get; set; }

        public int PorcentajeExoneracion { get; set; }

        public double MontoExoneracion { get; set; }

    }//end of interface

}//end of namespace
