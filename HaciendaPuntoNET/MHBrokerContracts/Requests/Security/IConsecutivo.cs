using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerContracts.Enums;

namespace MHBrokerContracts.Requests.Security
{
    public interface IConsecutivo :IDisposable
    {
        public int IDDocumento { get; set; }
        public int Terminal { get; set; }
        public int NumeroLocal { get; set; }
        public eTipoComprobante TipoComprobante{ get; set; }
        public eSituacionComprobante SituacionComprobante { get; set; }

    }//end of interface

}//end of namespace
