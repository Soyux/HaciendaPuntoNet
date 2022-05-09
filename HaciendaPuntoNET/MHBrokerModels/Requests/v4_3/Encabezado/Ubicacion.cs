using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado;
using MHBrokerModels.ExtensionMethods;

namespace MHBrokerModels.Requests.v4_3.Encabezado
{
    public class Ubicacion : IUbicacion
    {
        private string _provincia;
        public string Provincia
        {
            get => _provincia;
            set { _provincia = value.LengthLimit(1); }
        }
        private string _canton;
        public string Canton
        {
            get => _canton;
            set { _canton = value.LengthLimit(2); }
        }
        private string _distrito;
        public string Distrito
        {
            get => _distrito;
            set { _distrito = value.LengthLimit(2); }
        }
        private string _barrio;
        public string Barrio
        {
            get => _barrio;
            set { _barrio = value.LengthLimit(2); }
        }
        private string _otrasenas;
        public string OtrasSenas
        {
            get => _otrasenas;
            set { _otrasenas = value.LengthLimit(250); }
        }
    }
}
