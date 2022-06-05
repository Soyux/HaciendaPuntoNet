using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.IDocumento;
using MHBrokerContracts.Requests.Security;

namespace MHBrokerContracts.Requests
{
    public interface IRequestDocumento:IDisposable
    {
        public ISecurity? ISecurity { get; set; }
        public IDocumento.IDocumento? IDocumento { get; set; }

    }
}
