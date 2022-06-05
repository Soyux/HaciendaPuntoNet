using MHBrokerUtilities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerUtilities.Net
{
    public class MasterXML:IMasterXML
    {
        XmlDocument doc;
        public void CrearNuevoDocumento()
        {
            doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
        }

        public XmlNode CrearNodo(string nombre, XmlNode nodo = null, string nspace = "")
        {
            XmlNode nodoFE;
            if (nspace.Blank())
                nodoFE = doc.CreateElement(nombre);
            else
                nodoFE = doc.CreateElement(nombre, nspace);

            if (nodo == null)
                doc.AppendChild(nodoFE);
            else
                nodo.AppendChild(nodoFE);
            return nodoFE;
        }//fin de CrearNodo

        public XmlNode AgregarSubElemento(string nombre, string valor, XmlNode nodo)
        {
            XmlNode ClaveNodo = doc.CreateElement(nombre);
            ClaveNodo.AppendChild(doc.CreateTextNode(valor.ToString()));
            nodo.AppendChild(ClaveNodo);
            return ClaveNodo;
        }

        public XmlNode AgregarSubElemento(string nombre, int valor, XmlNode nodo)
        {
            return AgregarSubElemento(nombre, valor.ToString(), nodo);
        }

        public XmlNode AgregarSubElemento(string nombre, double valor, XmlNode nodo)
        {

            return AgregarSubElemento(nombre, valor.ToString(), nodo);
        }

        public XmlNode AgregarSubElemento(string nombre, DateTime valor, XmlNode nodo)
        {
            return AgregarSubElemento(nombre, valor.ToRfc3339String(), nodo);
        }

        public void GuardarDocumento(string nombre)
        {
            doc.Save(nombre);
        }

        public XmlDocument GetXML()
        {
            return doc;
        }

        public override string ToString()
        {
            return doc.ToString()??"";
        }//end of ToString



    }//end class

}//end of namespace
