using MHBrokerContracts.Requests.Security;
using MHBrokerLogic.Contracts;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerLogic.Connectivity
{
    public class SecurityManager:ISecurityManager
    {
        public ISecurity _ISecurity { get; set; }
        
        const int codigo_pais = 506;
        public SecurityManager(ISecurity ISecurity)
        {
            _ISecurity = ISecurity;            
        }

        public string GenerarConsecutivo()
        {
            string newconsecutivo = "";
            using (IConsecutivo cons = _ISecurity.Consecutivo)
            {
                newconsecutivo =
                  cons.NumeroLocal.ToString().FillWithZeros(3) +
                  cons.Terminal.ToString().FillWithZeros(5) +
                  cons.TipoComprobante.ToString().FillWithZeros(2) +
                  cons.IDDocumento.ToString().FillWithZeros(10);
            }//end of using
            return newconsecutivo;
        }//end of GenerarConsecutivo

        public string GenerarClave()
        {
            var clave =
                codigo_pais.ToString() +
                DateTime.Now.Day.ToString().LengthLimit(2) +
                DateTime.Now.Month.ToString().LengthLimit(2) +
                DateTime.Now.Year.ToString().LengthLimit(2) +
                _ISecurity.cedula_emisor.ToString().LengthLimit(12) +
                _ISecurity.Consecutivo.NumeroLocal.LengthLimit(3) +
                _ISecurity.Consecutivo.Terminal.LengthLimit(5) +
                _ISecurity.Consecutivo.TipoComprobante.ToString().LengthLimit(2) +
                GenerarConsecutivo().LengthLimit(10) +
                _ISecurity.Consecutivo.TipoComprobante.ToString().LengthLimit(1) +
                GenerarCodigoSeguridad().LengthLimit(8);
            return clave;
        }//end of GenerarClave
        public int GenerarCodigoSeguridad()
        {
            Random rnd = new Random();
            return rnd.Next(1, 99999999);
        }

       
    }
}
