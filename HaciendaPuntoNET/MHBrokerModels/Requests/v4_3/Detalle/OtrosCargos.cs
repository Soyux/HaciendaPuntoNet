using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Detalle;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class OtrosCargos : IOtrosCargos
    {
        public string TipoDocumento { get =>TipoDocumento; set => value.LengthLimit(2); }
        public string NumeroIdentidadTercero { get => NumeroIdentidadTercero; set => value.LengthLimit(12); }
        public string NombreTercero { get => NombreTercero; set => value.LengthLimit(100); }
        public string Detalle { get => Detalle; set => value.LengthLimit(160); }
        public double Porcentaje { get => Porcentaje; set => value.LengthLimit(4,5); }
        public double MontoCargo { get => MontoCargo; set => value.LengthLimit(13,5); }
    }//end of class

}//end of namespace
