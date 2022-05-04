using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Detalle
{
    public interface IInformacionReferencia
    {
         public string TipoDoc { get; set; }

        public string Numero { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Codigo { get; set; }
        public string Razon { get; set; }
    }//end of interface

}//end of namespace
