using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Detalle;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class Exoneracion : IExoneracion
    {
        public string TipoDocumento { get => TipoDocumento; set => value.LengthLimit(2); }
        public string NumeroDocumento { get => NumeroDocumento; set => value.LengthLimit(40); }
        public string NombreInstitucion { get => NombreInstitucion; set => value.LengthLimit(160); }
        public DateTime FechaEmision { get; set; }
        public int PorcentajeExoneracion { get =>PorcentajeExoneracion; set =>  value.LengthLimit(3); }
        public double MontoExoneracion { get => MontoExoneracion; set =>  value.LengthLimit(13,5); }
    }
}
