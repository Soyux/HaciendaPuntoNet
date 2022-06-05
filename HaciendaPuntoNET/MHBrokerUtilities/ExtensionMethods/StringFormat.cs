using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerUtilities.ExtensionMethods
{
    public static class StringFormat
    {
        public static string ComillasDobles(this string texto)
        {
            return "\"" + texto + "\"";
        }
        public static string ComillasSimples(this string texto)
        {
            return "\'" + texto + "\'";
        }
        public static string FillWithZeros(this string str,int largo = 0)
        {
            var resultado = str.ToString();

            if (largo > 0)
            {
                var diferencia = largo - str.ToString().Trim().Length;
                for (int i = 0; diferencia > i; i++)
                {
                    resultado = "0" + resultado;
                }

            }
            return resultado;

        }//end of FillWithZeros

        public static bool Blank(this string str)
        {
            return str.Trim().Length==0;
        }


    }//end of class

}//end of namespace
