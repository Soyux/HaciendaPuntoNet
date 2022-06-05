using MHBrokerContracts.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerLogic.Contracts.Builders
{
    public interface IBuilder
    {
        public IRequestDocumento _idocumento { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>clave,xml</returns>
        public Task<(string,string,string)> ConstruirDocumento();
            
    }//end of interface

}//end of namespace
