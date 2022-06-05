using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.IDocumento.Detalle
{
    public interface IImpuesto
    {
        public string Codigo { get; set; }
        public string CodigoTarifa { get; set; }
        public double Tarifa { get; set; }
        public double FactorIVA { get; set; }
        public double Monto { get; set; }
        public double MontoExportacion { get; set; }

    }//end of interface

}//end of namespace
