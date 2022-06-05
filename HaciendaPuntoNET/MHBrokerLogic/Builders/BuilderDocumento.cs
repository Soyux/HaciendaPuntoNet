using MemoryVault;
using MHBrokerContracts.Requests;
using MHBrokerLogic.Contracts;
using MHBrokerLogic.Contracts.Builders;
using MHBrokerUtilities.Contracts;

namespace MHBrokerLogic.Builders
{
    public abstract class BuilderDocumento : IBuilder
    {
        public IRequestDocumento _idocumento { get; set; }
        protected readonly ISecurityManager _isecuritymanager;
        protected readonly IMasterFirma _imasterfirma;
        protected readonly IHandler _ihandler;
        protected readonly IMasterFile _imasterfile;
        protected readonly IMasterXML _imasterxml;
         
        public BuilderDocumento(
            IRequestDocumento idocumento,
            IHandler ihandler,
            IMasterFile imasterfile,
            ISecurityManager isecuritymanager,
            IMasterXML imasterxml,
            IMasterFirma imasterfirma)
        {
            _idocumento = idocumento;
            _isecuritymanager = isecuritymanager;
            _ihandler = ihandler;
            _imasterfile = imasterfile;
            _imasterxml = imasterxml;
            _imasterfirma = imasterfirma;//new MasterFirma(_idocumento.ISecurity,_imasterfile,ihandler);
        }//end of constructor 

        /// <summary>
        /// 
        /// </summary>
        /// <returns>clave de xml,correo cliente</returns>
        public abstract (string,string) GenerarDocumento();
        
        //private async void SaveXMLFile(IMasterXML documento)
        //{
        //    string dirtempfiles = await _ihandler.GetValueMemory("3454ab48-3241-4c35-a9af-530c217eda30");
        //    string filename = dirtempfiles + _imasterfile.GenerarGUID();
        //    documento.GuardarDocumento(filename);
        //}//end of SaveXMLFiles
        void FirmarXML()
        {
            _imasterfirma.FirmarDocumento(_imasterxml.GetXML());
        }//end of FirmarXML

        string Encoding()
        {
            return _imasterfile.Base64Encode(_imasterxml.ToString());
        }//end of ProcesarDocumento

        /// <summary>
        /// 
        /// </summary>
        /// <returns>clave, xml,correo cliente</returns>
        (string,string,string) _ConstruirDocumento()
        {
            var data=GenerarDocumento();
            FirmarXML();
            return (data.Item1,Encoding(),data.Item2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>clave,xml,correo cliente</returns>
        public async Task<(string,string,string)> ConstruirDocumento()
        {
            var xml = await Task.FromResult(_ConstruirDocumento());
            return xml;
        }


    }//end of class

}//end of namespace
