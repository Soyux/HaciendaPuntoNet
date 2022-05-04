﻿using System;
using System.Collections.Generic;
using System.Text;
using MHBrokerContracts.Requests.v4_3.IDocumento.Detalle;
using MHBrokerContracts.Requests.v4_3.IDocumento.Resumen;
using MHBrokerContracts.Requests.v4_3.IDocumento.Encabezado;

namespace MHBrokerContracts.Requests.v4_3
{
    public interface ITiqueteElectronico:
        IDocumentoEncabezado,IDocumentoDetalle,IDocumentoResumen
    {

    }//end of interface

}//end of namespace
