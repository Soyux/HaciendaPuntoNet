using MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Encabezado
{
    public class DocumentoEncabezado : IDocumentoEncabezado
    {
        //Encabezado
        private string _codigoactividad;
        public string CodigoActividad
        {
            get => _codigoactividad;
            set { _codigoactividad = value.LengthLimit(6); }
        }

        private string _clave;
        public string Clave
        {
            get => _clave;
            set { _clave = value.LengthLimit(50); }
        }
        private string _numeroconsecutivo;
        public string NumeroConsecutivo
        {
            get => _numeroconsecutivo;
            set { _numeroconsecutivo = value.LengthLimit(20); }
        }
        public DateTime FechaEmision { get; set; }
        public ICliente Emisor { get; set; }
        public ICliente Receptor { get; set; }
        private string _condicionventa;
        public string CondicionVenta
        {
            get => _condicionventa;
            set { _condicionventa = value.LengthLimit(2); }
        }
        private string _plazocredito;
        public string PlazoCredito
        {
            get => _plazocredito;
            set { _plazocredito = value.LengthLimit(10); }

        }

        private string _mediopago;
        public string MedioPago
        {
            get => _mediopago;
            set { _mediopago = value.LengthLimit(2); }
        }
        private string _nombrecomercial;
        public string NombreComercial
        {
            get => _nombrecomercial;
            set { _nombrecomercial = value.LengthLimit(80); }
        }
        public IUbicacion Ubicacion { get; set; }
        public ITelefono Telefono { get; set; }
        public IFax Fax { get; set; }
        private string _identificacionExtranjero;
        public string IdentificacionExtranjero
        {
            get => _identificacionExtranjero;
            set { _identificacionExtranjero = value.LengthLimit(20); }
        }

    }
}
