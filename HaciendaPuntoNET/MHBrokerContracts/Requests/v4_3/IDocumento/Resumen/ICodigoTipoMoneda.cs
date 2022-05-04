using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Resumen
{
    public interface ICodigoTipoMoneda
    {
        public string CodigoMoneda { get; set; }
        public double TipoCambio { get; set; }
        
    }//end of interface

}//end of namespace
