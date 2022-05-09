using System;

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
            //Limit decimals
            //number = -7878287.6787
            //limiteddecimals = -7878287.678 if maxdecimals are 3
            if (number == Math.Abs(number))
            {//if it's positive 
                double limiteddecimals = Math.Round(number, maxdecimals);
                //positive_number = 7878287.678
                double positive_number = Math.Abs(limiteddecimals);
                //string number_temp = Math.Truncate(positive_number).ToString();
                double limitedintegers = Math.Truncate(positive_number) % Math.Pow(10, maxdecimals);
                return limitedintegers + (limiteddecimals - limitedintegers);
            }//end of 
            else {
                double limiteddecimals = Math.Round(number, maxdecimals);
                //positive_number = 7878287.678
                double positive_number = Math.Abs(limiteddecimals);
                //string number_temp = Math.Truncate(positive_number).ToString();
                double limitedintegers = Math.Truncate(positive_number) % Math.Pow(10, maxdecimals);
                return (limitedintegers + (limiteddecimals - limitedintegers))*-1;
            }//end of else
        }//end of FormatLimit

    }//end of ModelValidation
}//end of namespace
