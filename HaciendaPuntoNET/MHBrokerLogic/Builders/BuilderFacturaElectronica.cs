using MemoryVault;
using MHBrokerContracts.Requests;
using MHBrokerContracts.Requests.IDocumento;
using MHBrokerContracts.Requests.IDocumento.Detalle;
using MHBrokerLogic.Contracts;
using MHBrokerUtilities.Contracts;
using MHBrokerUtilities.ExtensionMethods;


namespace MHBrokerLogic.Builders
{
    public class BuilderFacturaElectronica:BuilderDocumento
    {
        public BuilderFacturaElectronica(IRequestDocumento idocumento, IHandler ihandler, IMasterFile imasterfile, ISecurityManager isecuritymanager, IMasterXML imasterxml, IMasterFirma imasterfirma) : base(idocumento, ihandler, imasterfile, isecuritymanager, imasterxml, imasterfirma)
        {

        }

        public override (string,string) GenerarDocumento()
        {
            var nspace = "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica";
            var nodoRoot = _imasterxml.CrearNodo("FacturaElectronica", null, nspace);
         
            using (IDocumento doc = _idocumento.IDocumento)
            {
                //----------------Encabezado------------------------//
                _imasterxml.AgregarSubElemento("Clave", doc.IEncabezado.Clave, nodoRoot);
                _imasterxml.AgregarSubElemento("CodigoActividad", doc.IEncabezado.CodigoActividad, nodoRoot);
                _imasterxml.AgregarSubElemento("NumeroConsecutivo", _isecuritymanager.GenerarConsecutivo(), nodoRoot);
                _imasterxml.AgregarSubElemento("FechaEmision", DateTime.Now.ToRfc3339String(), nodoRoot);

                //-------------ClienteEmisor------------------------//
                var nodoEmisor = _imasterxml.CrearNodo("Emisor", nodoRoot);
                _imasterxml.AgregarSubElemento("Nombre", doc.IEncabezado.Emisor.Nombre, nodoEmisor);

                var nodoEmisorIdentificacion = _imasterxml.CrearNodo("Identificacion", nodoEmisor);
                _imasterxml.AgregarSubElemento("Tipo", doc.IEncabezado.Emisor.Identificacion.Tipo, nodoEmisorIdentificacion);
                _imasterxml.AgregarSubElemento("Numero", doc.IEncabezado.Emisor.Identificacion.Numero, nodoEmisorIdentificacion);

                _imasterxml.AgregarSubElemento("NombreComercial", doc.IEncabezado.Emisor.NombreComercial, nodoEmisor);
                var nodoEmisorUbicacion = _imasterxml.CrearNodo("Ubicacion", nodoEmisor);
                _imasterxml.AgregarSubElemento("Provincia", doc.IEncabezado.Emisor.Ubicacion.Provincia.DefaultValue("01"), nodoEmisorUbicacion);
                _imasterxml.AgregarSubElemento("Canton", doc.IEncabezado.Emisor.Ubicacion.Canton.DefaultValue("01"), nodoEmisorUbicacion);
                _imasterxml.AgregarSubElemento("Distrito", doc.IEncabezado.Emisor.Ubicacion.Distrito.DefaultValue("01"), nodoEmisorUbicacion);
                _imasterxml.AgregarSubElemento("Barrio", doc.IEncabezado.Emisor.Ubicacion.Barrio.DefaultValue("01"), nodoEmisorUbicacion);
                _imasterxml.AgregarSubElemento("OtrasSenas", doc.IEncabezado.Emisor.Ubicacion.OtrasSenas.DefaultValue("01"), nodoEmisorUbicacion);

                var nodoEmisorTelefono = _imasterxml.CrearNodo("Telefono", nodoEmisor);
                _imasterxml.AgregarSubElemento("CodigoPais", doc.IEncabezado.Emisor.Telefono.CodigoPais.ToString().DefaultValue("506"), nodoEmisorTelefono);
                _imasterxml.AgregarSubElemento("NumTelefono", doc.IEncabezado.Emisor.Telefono.NumTelefono.ToString().DefaultValue("11111111"), nodoEmisorTelefono);

                var nodoEmisorFax = _imasterxml.CrearNodo("Fax", nodoEmisor);
                _imasterxml.AgregarSubElemento("CodigoPais", doc.IEncabezado.Emisor.Fax.CodigoPais.ToString().DefaultValue("506"), nodoEmisorFax);
                _imasterxml.AgregarSubElemento("NumTelefono", doc.IEncabezado.Emisor.Fax.NumTelefono.ToString().DefaultValue("11111111"), nodoEmisorFax);
                _imasterxml.AgregarSubElemento("CorreoElectronico", doc.IEncabezado.Emisor.CorreoElectronico, nodoEmisor);
                //-------------Cliente Receptor------------------------//
                var nodoReceptor = _imasterxml.CrearNodo("Receptor", nodoRoot);
                _imasterxml.AgregarSubElemento("Nombre", doc.IEncabezado.Receptor.Nombre, nodoReceptor);

                var nodoReceptorIdentificacion = _imasterxml.CrearNodo("Identificacion", nodoReceptor);
                _imasterxml.AgregarSubElemento("Tipo", doc.IEncabezado.Receptor.Identificacion.Tipo, nodoReceptorIdentificacion);
                _imasterxml.AgregarSubElemento("Numero", doc.IEncabezado.Receptor.Identificacion.Numero, nodoReceptorIdentificacion);

                _imasterxml.AgregarSubElemento("NombreComercial", doc.IEncabezado.Receptor.NombreComercial, nodoReceptor);
                var nodoReceptorUbicacion = _imasterxml.CrearNodo("Ubicacion", nodoReceptor);
                _imasterxml.AgregarSubElemento("Provincia", doc.IEncabezado.Receptor.Ubicacion.Provincia.DefaultValue("01"), nodoReceptorUbicacion);
                _imasterxml.AgregarSubElemento("Canton", doc.IEncabezado.Receptor.Ubicacion.Canton.DefaultValue("01"), nodoReceptorUbicacion);
                _imasterxml.AgregarSubElemento("Distrito", doc.IEncabezado.Receptor.Ubicacion.Distrito.DefaultValue("01"), nodoReceptorUbicacion);
                _imasterxml.AgregarSubElemento("Barrio", doc.IEncabezado.Receptor.Ubicacion.Barrio.DefaultValue("01"), nodoReceptorUbicacion);
                _imasterxml.AgregarSubElemento("OtrasSenas", doc.IEncabezado.Receptor.Ubicacion.OtrasSenas.DefaultValue("01"), nodoReceptorUbicacion);

                var nodoReceptorTelefono = _imasterxml.CrearNodo("Telefono", nodoReceptor);
                _imasterxml.AgregarSubElemento("CodigoPais", doc.IEncabezado.Receptor.Telefono.CodigoPais.ToString().DefaultValue("506"), nodoReceptorTelefono);
                _imasterxml.AgregarSubElemento("NumTelefono", doc.IEncabezado.Receptor.Telefono.NumTelefono.ToString().DefaultValue("11111111"), nodoReceptorTelefono);

                var nodoReceptorFax = _imasterxml.CrearNodo("Fax", nodoReceptor);
                _imasterxml.AgregarSubElemento("CodigoPais", doc.IEncabezado.Receptor.Fax.CodigoPais.ToString().DefaultValue("506"), nodoReceptorFax);
                _imasterxml.AgregarSubElemento("NumTelefono", doc.IEncabezado.Receptor.Fax.NumTelefono.ToString().DefaultValue("11111111"), nodoReceptorFax);
                _imasterxml.AgregarSubElemento("CorreoElectronico", doc.IEncabezado.Receptor.CorreoElectronico, nodoReceptor);

                _imasterxml.AgregarSubElemento("CondicionVenta", doc.IEncabezado.CondicionVenta, nodoRoot);
                _imasterxml.AgregarSubElemento("MedioPago", doc.IEncabezado.MedioPago, nodoRoot);

                //--------------DETALLE-------------------/
                var DetalleServicio = _imasterxml.CrearNodo("DetalleServicio", nodoRoot);
                foreach (ILineaDetalle linea in doc.IDetalle.LineaDetalle)
                {
                    var LineaDetalle = _imasterxml.CrearNodo("LineaDetalle", DetalleServicio);
                    _imasterxml.AgregarSubElemento("NumeroLinea", linea.NumeroLinea, LineaDetalle);
                    _imasterxml.AgregarSubElemento("PartidaArancelaria", linea.PartidaArancelaria, LineaDetalle);
                    _imasterxml.AgregarSubElemento("Codigo", linea.Codigo, LineaDetalle);

                    var nCodigoComercial = _imasterxml.CrearNodo("CodigoComercial", LineaDetalle);
                    _imasterxml.AgregarSubElemento("Tipo", linea.CodigoComercial.Tipo, nCodigoComercial);
                    _imasterxml.AgregarSubElemento("Codigo", linea.CodigoComercial.Codigo, nCodigoComercial);

                    _imasterxml.AgregarSubElemento("Cantidad", linea.Cantidad, LineaDetalle);
                    _imasterxml.AgregarSubElemento("UnidadMedida", linea.UnidadMedida, LineaDetalle);
                    //UnidadMedidaComercial revisa si esta en document original
                    _imasterxml.AgregarSubElemento("UnidadMedidaComercial", linea.UnidadMedidaComercial, LineaDetalle);
                    _imasterxml.AgregarSubElemento("Detalle", linea.Detalle, LineaDetalle);
                    _imasterxml.AgregarSubElemento("PrecioUnitario", linea.PrecioUnitario, LineaDetalle);
                    _imasterxml.AgregarSubElemento("MontoTotal", linea.MontoTotal, LineaDetalle);

                    var nDescuento = _imasterxml.CrearNodo("Descuento", LineaDetalle);
                    _imasterxml.AgregarSubElemento("MontoDescuento", linea.Descuento.MontoDescuento, nDescuento);
                    _imasterxml.AgregarSubElemento("NaturalezaDescuento", linea.Descuento.NaturalezaDescuento, nDescuento);

                    _imasterxml.AgregarSubElemento("Subtotal", linea.SubTotal, LineaDetalle);
                    _imasterxml.AgregarSubElemento("BaseImponible", linea.BaseImponible, LineaDetalle);

                    var NImpuesto = _imasterxml.CrearNodo("Impuesto", LineaDetalle);
                    _imasterxml.AgregarSubElemento("Codigo", linea.Impuesto.Codigo, NImpuesto);
                    _imasterxml.AgregarSubElemento("CodigoTarifa", linea.Impuesto.CodigoTarifa, NImpuesto);
                    _imasterxml.AgregarSubElemento("Tarifa", linea.Impuesto.Tarifa, NImpuesto);
                    _imasterxml.AgregarSubElemento("FactorIVA", linea.Impuesto.FactorIVA, NImpuesto);
                    _imasterxml.AgregarSubElemento("Monto", linea.Impuesto.Monto, NImpuesto);
                    _imasterxml.AgregarSubElemento("MontoExportacion", linea.Impuesto.MontoExportacion, NImpuesto);

                    var NExoneracion = _imasterxml.CrearNodo("Exoneracion", LineaDetalle);
                    _imasterxml.AgregarSubElemento("TipoDocumento", linea.Exoneracion.TipoDocumento, NExoneracion);
                    _imasterxml.AgregarSubElemento("NumeroDocumento", linea.Exoneracion.NumeroDocumento, NExoneracion);
                    _imasterxml.AgregarSubElemento("NombreInstitucion", linea.Exoneracion.NombreInstitucion, NExoneracion);
                    _imasterxml.AgregarSubElemento("FechaEmision", linea.Exoneracion.FechaEmision, NExoneracion);
                    _imasterxml.AgregarSubElemento("TipoDocumento", linea.Exoneracion.TipoDocumento, NExoneracion);
                    _imasterxml.AgregarSubElemento("PorcentajeExoneracion", linea.Exoneracion.PorcentajeExoneracion, NExoneracion);
                    _imasterxml.AgregarSubElemento("MontoExoneracion", linea.Exoneracion.MontoExoneracion, NExoneracion);

                    _imasterxml.AgregarSubElemento("ImpuestoNeto", linea.ImpuestoNeto, LineaDetalle);
                    _imasterxml.AgregarSubElemento("MontoTotalLinea", linea.MontoTotalLinea, LineaDetalle);
                }//end of ILineaDetalle using

                var nOtrosCargos = _imasterxml.CrearNodo("OtrosCargos", DetalleServicio);
                foreach (IOtrosCargos linea in doc.IDetalle.OtrosCargos)
                {
                    _imasterxml.AgregarSubElemento("TipoDocumento", linea.TipoDocumento, nOtrosCargos);
                    _imasterxml.AgregarSubElemento("NumeroIdentidadTercero", linea.NumeroIdentidadTercero, nOtrosCargos);
                    _imasterxml.AgregarSubElemento("NombreTercero", linea.NombreTercero, nOtrosCargos);
                    _imasterxml.AgregarSubElemento("Detalle", linea.Detalle, nOtrosCargos);
                    _imasterxml.AgregarSubElemento("Porcentaje", linea.Porcentaje, nOtrosCargos);
                    _imasterxml.AgregarSubElemento("MontoCargo", linea.MontoCargo, nOtrosCargos);
                }//end of using OtrosCargos

                var nResumenFactura= _imasterxml.CrearNodo("ResumenFactura", nodoRoot);

                var nCodigoTipoMoneda = _imasterxml.CrearNodo("CodigoTipoMoneda", nResumenFactura);
                _imasterxml.AgregarSubElemento("CodigoMoneda", doc.IResumen.CodigoTipoMoneda.CodigoMoneda, nCodigoTipoMoneda);
                _imasterxml.AgregarSubElemento("TipoCambio", doc.IResumen.CodigoTipoMoneda.TipoCambio, nCodigoTipoMoneda);

                _imasterxml.AgregarSubElemento("TotalServGravados", doc.IResumen.TotalServGravados, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalServExentos", doc.IResumen.TotalServExentos, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalServExonerado", doc.IResumen.TotalServExonerado, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalMercanciasGravadas", doc.IResumen.TotalMercanciasGravadas, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalMercanciasExentas", doc.IResumen.TotalMercanciasExentas, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalMercExonerada", doc.IResumen.TotalMercExonerada, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalGravado", doc.IResumen.TotalGravado, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalExento", doc.IResumen.TotalExento, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalExonerado", doc.IResumen.TotalExonerado, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalVenta", doc.IResumen.TotalVenta, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalDescuentos", doc.IResumen.TotalDescuentos, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalVentaNeta", doc.IResumen.TotalVenta, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalImpuesto", doc.IResumen.TotalImpuesto, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalIVADevuelto", doc.IResumen.TotalIVADevuelto, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalOtrosCargos", doc.IResumen.TotalOtrosCargos, nResumenFactura);
                _imasterxml.AgregarSubElemento("TotalComprobante", doc.IResumen.TotalComprobante, nResumenFactura);
                return (doc.IEncabezado.Clave,doc.IEncabezado.Receptor.CorreoElectronico);
            }//end of IDocumento Using
        }//end of GenerateXMLDocument

    }//end of class

}//end of namespace
