using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Enums;

namespace MHBrokerContracts.Requests.Security
{
    public interface ISecurity
    {
        public byte[] Certificate { get; set; }
        public string environment { get; set; }
        public string PINCertificado { get; set; }
        public string UserName { get; set; }
        public IConsecutivo Consecutivo { get; set; }
        public string cedula_emisor { get; set; }
    
      
    }//end of class

}//end of namespace
