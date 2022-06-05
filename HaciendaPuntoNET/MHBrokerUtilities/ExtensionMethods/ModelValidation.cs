using System;
using System.Collections.Generic;
using System.Text;

namespace MHBrokerUtilities.ExtensionMethods
{
    public static class ModelValidation
    {
        public static string LengthLimit(this string str,int maxlength) {

            if (str.Length > maxlength)
            {
                return str.Substring(0, maxlength);
            }
            
            return str;

        }//end of method StringLimiter

        public static int LengthLimit(this int number, int maxlength)
        {
            return int.Parse(LengthLimit(number.ToString(), maxlength));
        }//end of method IntergerLimit

        //Need to optimize
        public static double LengthLimit(this double number, int maxintegers, int maxdecimals) {

            double tempIntegers=Math.Truncate(number);
            tempIntegers = double.Parse(LengthLimit(tempIntegers.ToString(), maxintegers));

            double decimals = number - tempIntegers;
            decimals= double.Parse(LengthLimit(decimals.ToString(), maxdecimals));

            return tempIntegers + decimals;
        }//end of DecimalLimit

        public static string DefaultValue(this string str,string default_value)
        {
            return str.Blank() ? default_value : str;

        }//end of DefaultValue

    }//end of ModelValidation
}//end of namespace
