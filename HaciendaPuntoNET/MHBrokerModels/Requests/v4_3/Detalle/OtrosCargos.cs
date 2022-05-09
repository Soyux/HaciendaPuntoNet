using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Detalle
{
    public class OtrosCargos : IOtrosCargos
    {
        private string _tipoDocumento;
        public string TipoDocumento {
            get => _tipoDocumento;
            set { _tipoDocumento = value.LengthLimit(2); }
        }
        private string _numeroIdentidadTercero;
        public string NumeroIdentidadTercero
        {
            get => _numeroIdentidadTercero;
            set { _numeroIdentidadTercero = value.LengthLimit(12); }
        }
        private string _nombreTercero;
        public string NombreTercero {

            get => _nombreTercero;
            set { _nombreTercero = value.LengthLimit(100); }
        }
        private string _detalle;
        public string Detalle
        {
            get => _detalle;
            set { _detalle = value.LengthLimit(160); }
        }

        private double _porcentaje;
        public double Porcentaje {
            get => _porcentaje;
            set { _porcentaje= value.FormatLimit(6,5); }
        }
        private double _montoCargo;
        public double MontoCargo
        {
            get => _montoCargo;
            set { _montoCargo = value.FormatLimit(18, 5); }
        }
    }
}
