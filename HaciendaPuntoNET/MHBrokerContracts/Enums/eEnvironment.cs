using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerContracts.Enums
{
    public static class eEnvironment
    {
        public static string Produccion { get => "api-prod"; }

        public static string Staging{ get => "api-cert"; }

    }
}
