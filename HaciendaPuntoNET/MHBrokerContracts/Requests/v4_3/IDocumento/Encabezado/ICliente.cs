using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado
{
public interface ICliente
    {
        public string Nombre { get; set; }
        public IIdentificacion Identificacion { get; set; }
        public IUbicacion Ubicacion { get; set; }
        public ITelefono Telefono { get; set; }
        public IFax Fax { get; set; }
        public string CorreoElectronico { get; set; }
        public string IdentificacionExtranjero { get; set; }
        public string NombreComercial { get; set; }


    }//end of interface
}
