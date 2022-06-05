using System;
using System.Collections.Generic;
using System.Text; 
using MHBrokerContracts.Requests.IDocumento.Encabezado;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerModels.Requests.Encabezado{

    public class Cliente : ICliente
    {
        public string Nombre { get => Nombre; set => value.LengthLimit(100); }
        public IIdentificacion Identificacion { get; set; }
        public IUbicacion Ubicacion { get; set; }
        public ITelefono Telefono { get; set; }
        public IFax Fax { get; set; }
        public string CorreoElectronico { get => CorreoElectronico; set => value.LengthLimit(160); }
        public string IdentificacionExtranjero { get => IdentificacionExtranjero; set => value.LengthLimit(20); }
        public string NombreComercial { get => NombreComercial; set => value.LengthLimit(80); }
    }//end of cliente

    

}//end of namespace
