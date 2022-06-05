using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Detalle;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class Descuento : IDescuento
    {
        public double MontoDescuento { get => MontoDescuento; set => value.LengthLimit(13,5); }
        public string NaturalezaDescuento { get => NaturalezaDescuento;set=> value.LengthLimit(80); }
    }//end of class
}//end of namespace
