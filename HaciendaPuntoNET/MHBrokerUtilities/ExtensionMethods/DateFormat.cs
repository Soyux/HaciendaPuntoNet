using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerUtilities.ExtensionMethods
{
    public static class DateFormat
    {
        public static string ToRfc3339String(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd'T'HH:mm:sszzz", DateTimeFormatInfo.InvariantInfo);
        }
    }
}
