using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class Exoneracion : IExoneracion
    {
        private string _tipoDocumento;
        public string TipoDocumento
        {
            get => _tipoDocumento;
            set { _tipoDocumento = value.LengthLimit(2); }
        }
        private string _numeroDocumento;
        public string NumeroDocumento {
            get => _numeroDocumento;
            set { _numeroDocumento = value.LengthLimit(40); }
        }
        private string _nombreInstitucion;
        public string NombreInstitucion
        {
            get => _nombreInstitucion;
            set { _nombreInstitucion = value.LengthLimit(160); }
        }
        private DateTime _fechaEmision;
        public DateTime FechaEmision { get; set; }
        private int _porcentajeExoneracion;
        public int PorcentajeExoneracion
        {
            get => _porcentajeExoneracion;
            set { _porcentajeExoneracion = value.LengthLimit(3); }
        }
        private double _montoExoneracion;
        public double MontoExoneracion
        {
            get => _montoExoneracion;
            set { _montoExoneracion = value.FormatLimit(18,5); }
        }
    }
}
