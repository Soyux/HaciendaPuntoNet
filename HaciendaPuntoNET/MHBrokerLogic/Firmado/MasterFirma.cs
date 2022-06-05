using FirmaXadesNet;
using FirmaXadesNet.Crypto;
using FirmaXadesNet.Signature.Parameters;
using MemoryVault;
using MHBrokerContracts.Requests.Security;
using MHBrokerLogic.Contracts;
using MHBrokerUtilities.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace MHBrokerLogic.Firmado
{

    public class MasterFirma :IMasterFirma, IDisposable
    {
        private bool disposedValue;
        private ISecurity _isecurity;
        private IMasterFile _imasterfile;
        private IHandler _ihandler;
        public MasterFirma(ISecurity isecurity,IMasterFile imasterfile,IHandler ihandler)
        {
            _isecurity= isecurity;
            _imasterfile= imasterfile;
            _ihandler= ihandler;
        }

        private async Task<ReturnValue> GetCertificate()
        {
            string dirtempfiles = await _ihandler.GetValueMemory("3454ab48-3241-4c35-a9af-530c217eda30");
            string certdir = dirtempfiles + _imasterfile.GenerarGUID();
            
            _imasterfile.WriteBytes(certdir,_isecurity.Certificate);

            return new ReturnValue()
            {
                cert = new X509Certificate2(certdir, _isecurity.PINCertificado),
                direccion = certdir
            };
        }//end of GetCertificate

        public async Task<XmlDocument> FirmarDocumento(XmlDocument documentoOriginal)
        {
            var selectedCertificate = await GetCertificate();
            XadesService xadesService = new XadesService();
            SignatureParameters parametri = new SignatureParameters();
            parametri.SignatureMethod = SignatureMethod.RSAwithSHA512;
            parametri.SigningDate = DateTime.Now;
            Signer signer2 = parametri.Signer = new Signer(selectedCertificate.cert);
            using (signer2)
            {
                using (var fs = new FileStream(selectedCertificate.direccion, FileMode.Open))
                {
                    var _signatureDocument = xadesService.Sign(fs, parametri);
                    //_signatureDocument.Save(nomeFileXmlFirmato);
                    return _signatureDocument.Document;
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MasterFirma()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }//end of class

}//end of namespace
