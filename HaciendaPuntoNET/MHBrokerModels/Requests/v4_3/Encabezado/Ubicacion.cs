using MHBrokerContracts.Requests.IDocumento.Encabezado;
using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Encabezado
{
    public class Ubicacion : IUbicacion
    {
        public string Provincia { get => Provincia; set => value.LengthLimit(1); }
        public string Canton { get => Canton; set => value.LengthLimit(2); }
        public string Distrito { get => Distrito; set => value.LengthLimit(2); }
        public string Barrio { get => Barrio; set => value.LengthLimit(2); }
        public string OtrasSenas { get => OtrasSenas; set => value.LengthLimit(160); }
         
    }//end of class
}//end of namespace
