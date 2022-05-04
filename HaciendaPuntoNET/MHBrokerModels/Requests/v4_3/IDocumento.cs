using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerModels.Requests.v4_3
{
    public interface IDocumento
    {
        public string CodigoActividad { get; set; }
        public string Clave { get; set; }
        public string NumeroConsecutivo { get; set; }
        public DateTime FechaEmision { get; set; }
        public ICliente Emisor { get; set; }
        public string NombreComercial { get; set; }
        public IUbicacion Ubicacion{get;set;}
        public ITelefono Telefono { get; set; }
        public IFax Fax { get; set; }
        public ICliente Receptor { get; set; }
        public string IdentificacionExtranjero { get; set; }



    }//end of interface
    public interface IUbicacion
    {
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Barrio { get; set; }
        public string OtrasSenas { get; set; }
    }

    public interface IFax { 
        
        public int CodigoPais { get; set; }
        public int NumTelefono { get; set; }
    
    }
    public interface ITelefono {

        public int CodigoPais { get; set; }
        public NumTelefono{get;set;}

    
    }//end of ITelefono

}//end of namespace
