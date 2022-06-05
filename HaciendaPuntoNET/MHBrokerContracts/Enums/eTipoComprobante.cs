using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerContracts.Enums
{
    public enum eTipoComprobante
    {
        Factura_Electronica = 1,
        NotaDebitoElectronica = 2,
        NotaCreditoElectronica = 3,
        TiqueteElectronico = 4,
        ConfirmacionAceptacionComprobanteElectronico = 5, //Compra
        ConfirmacionAceptacionParcialComprobanteElectronico = 6,
        ConfirmacionRechazoComprobanteElectronico = 7
    }//fin de TipoComprobante
}
