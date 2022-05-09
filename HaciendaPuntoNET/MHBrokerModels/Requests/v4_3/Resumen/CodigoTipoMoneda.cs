using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerModels.ExtensionMethods;
using MHBrokerContracts.Requests.v4_3.IDocumento.Resumen;

namespace MHBrokerModels.Requests.v4_3.Resumen
{
    public class CodigoTipoMoneda : ICodigoTipoMoneda
    {
        private string _codigoMoneda;
        public string CodigoMoneda {
            get => _codigoMoneda;
            set { _codigoMoneda = value.LengthLimit(3); }

        }
        private double _tipoCambio;
        public double TipoCambio {
            get => _tipoCambio;
            set { _tipoCambio= value.FormatLimit(18,5); }


        }
    }//end of CodigoMoneda
}
