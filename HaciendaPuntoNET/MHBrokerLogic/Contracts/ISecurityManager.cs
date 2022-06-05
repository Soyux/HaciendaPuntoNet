using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerLogic.Contracts
{
    public interface ISecurityManager
    {
        public string GenerarConsecutivo();
        public string GenerarClave();
        public int GenerarCodigoSeguridad();
    }//end of interface
}//end of namespace
