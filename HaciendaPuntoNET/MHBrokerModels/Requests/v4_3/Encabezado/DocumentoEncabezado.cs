using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento.Encabezado;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Encabezado
{
    public class DocumentoEncabezado : IDocumentoEncabezado
    {
        public string CodigoActividad { get => CodigoActividad; set => value.LengthLimit(6); }
        public string Clave { get => Clave; set => value.LengthLimit(50); }
        public string NumeroConsecutivo { get => NumeroConsecutivo; set => value.LengthLimit(20); }
        public DateTime FechaEmision { get; set; }
        public ICliente Emisor { get; set; }
        public ICliente Receptor { get; set; }
        public string CondicionVenta { get => CondicionVenta; set => value.LengthLimit(2); }
        public string PlazoCredito { get => PlazoCredito; set => value.LengthLimit(10); }
        public string MedioPago { get => MedioPago; set => value.LengthLimit(2); }
    }
}
