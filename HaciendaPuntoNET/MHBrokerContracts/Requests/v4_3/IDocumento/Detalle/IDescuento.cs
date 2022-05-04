using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Detalle
{
    public interface IDescuento
    {
        public double MontoDescuento { get; set; }
        public string NaturalezaDescuento { get; set; }
        
    }//end of interface

}//end of namespace
