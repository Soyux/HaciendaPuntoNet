using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerContracts.Enums
{
    public enum eDocumentState
    {
        None=-1,
        Pending = 0,
        XMLGenerado = 1,
        JSONEnviado = 2,
        JSONError = 3,
        JSONRecibidoAnterior = 4,
        ProcesandoHacienda = 5,
        ErrorHacienda = 6,
        AceptadoHacienda = 7,
        PendienteEnvioCorreo = 8,
        CorreoEnviado = 9,
        Completo = 10,
        ErrorCorreo = 11
    }
}
