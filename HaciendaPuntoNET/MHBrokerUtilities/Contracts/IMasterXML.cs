using System.Xml;

namespace MHBrokerUtilities.Contracts
{
    public interface IMasterXML
    {
        public void CrearNuevoDocumento();
        public XmlNode CrearNodo(string nombre, XmlNode nodo = null, string nspace = "");
        public XmlNode AgregarSubElemento(string nombre, string valor, XmlNode nodo);
        public XmlNode AgregarSubElemento(string nombre, DateTime valor, XmlNode nodo);
        public XmlNode AgregarSubElemento(string nombre, int valor, XmlNode nodo);
        public XmlNode AgregarSubElemento(string nombre, double valor, XmlNode nodo);
        public void GuardarDocumento(string nombre);
        public XmlDocument GetXML();
        public string ToString();
    }//end interface
}//end namespace 
