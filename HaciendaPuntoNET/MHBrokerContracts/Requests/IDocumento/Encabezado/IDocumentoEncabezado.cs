using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.IDocumento.Encabezado
{
    public interface IDocumentoEncabezado
    {
        public string CodigoActividad { get; set; }
        public string Clave { get; set; }
        public string NumeroConsecutivo { get; set; }
        public DateTime FechaEmision { get; set; }
        public ICliente Emisor { get; set; }
        public ICliente Receptor { get; set; }
        public string CondicionVenta { get; set; }
        public string PlazoCredito { get; set; }
        public string MedioPago { get; set; }

    }//end of interface
  

}//end of namespace
