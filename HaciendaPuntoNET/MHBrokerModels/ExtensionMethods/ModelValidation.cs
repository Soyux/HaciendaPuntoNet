using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerModels.ExtensionMethods
{
    public static class ModelValidation
    {
        public static string LengthLimit(this string str,int maxlength) {


            if (str.Length <= maxlength)
            {
                return str;

            }
            else {
                return str.Substring(0, maxlength);            
            }
        
        }//end of method StringLimiter

        public static int LengthLimit(this int number, int maxlength)
        {

            return int.Parse(LengthLimit(number.ToString(), maxlength));

        }//end of method StringLimiter

        public static double FormatLimit(this double number, int maxintegers, int maxdecimals) { 
            
            
        
        }

    }//end of ModelValidation
}//end of namespace
