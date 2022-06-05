using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryVault;
using MHBrokerContracts.Enums;
using MHBrokerIO.Requests;
using MHBrokerLogic.Contracts;
using MHBrokerUtilities.Contracts;
using MHBrokerUtilities.ExtensionMethods;

namespace MHBrokerLogic.Connectivity
{
    public class Broker
    {
        readonly Contracts.Builders.IBuilder _ibuilder;
        readonly Contracts.ITokenManager _itokenmanager;
        readonly IMasterJSON _imasterjson;
        readonly IHandler _ihandler;
        readonly IMasterFile _imasterfile;
        readonly IMasterEmail _imasteremail;
        public Broker(
            Contracts.Builders.IBuilder ibuilder,
            Contracts.ITokenManager itokenmanager,
            IMasterJSON imasterjson,
            IHandler ihandler,
            IMasterFile imasterfile,
            IMasterEmail imasteremail

            )
        {
            this._ihandler = ihandler;
            this._ibuilder = ibuilder;
            this._itokenmanager = itokenmanager;
            this._imasterjson = imasterjson;
            this._imasterfile= imasterfile;
        }

        
        /// <summary>
        /// Construye el documento xml , el token para hacienda
        /// </summary>
        /// <returns>Clave,Documento XMl, Token,Correo Cliente</returns>
        async Task<(string,string,IToken,string)> ConstruirRequisitos()
        {
            var tupladocumento= await _ibuilder.ConstruirDocumento();
            IToken itoken = await _itokenmanager.GetToken();

            return (tupladocumento.Item1,tupladocumento.Item2, itoken,tupladocumento.Item3);
        }//end of ConstruirRequisitos

        async void TaskProcesarDocumento()
        {
            var requisitos = await ConstruirRequisitos();
            eDocumentState state = await EnviarJSON(requisitos.Item2, requisitos.Item3);

            if(state == eDocumentState.JSONEnviado)
            {
                state = await RecibirComprobante(requisitos.Item1,requisitos.Item3);
                if (state == eDocumentState.AceptadoHacienda || initial)
                {
                    if (state != eDocumentState.ErrorHacienda)
                    {
                        //Email si existe
                        if (!blank(requisitos.Item4))
                        {
                            asdsad
                        }//end of if email si existe
                    }//end of if error 

                }
            
            }//end of if
            else
            {

            }//end of else

        }//end of EnviarDocumento

        async Task<eDocumentState> RecibirComprobante(string clave, IToken token)
        {
            eDocumentState currentState = eDocumentState.ProcesandoHacienda;
            var dir_comprobante = await _ihandler.GetValueMemory("");

            _imasterjson.GetJSONAsync(dir_comprobante+"/"+clave, token.access_token);
            var response = await _imasterjson.GetStringResponse();

            var estado = _imasterjson.GetValueJSON(response, "results");
            if (estado.Contains("aceptado"))
            {
                currentState = eDocumentState.AceptadoHacienda;
                
            }//end of if
            else
            {
                if (estado.Contains("procesando"))
                {
                    currentState = await RecibirComprobante(clave, token);

                }//end of if
                else
                {
                    currentState = eDocumentState.ErrorHacienda;
                    var mensaje = _imasterjson.GetValueJSON(response, "respuesta-xml");
                    var mensajerror = _imasterfile.Base64DeEncode(mensaje);

                    

                }//end of else

            }//end of else
            return currentState;

        }//end of RecibirComprobante

        async Task<eDocumentState> EnviarJSON(string xml, IToken token)
        {
            eDocumentState state=eDocumentState.XMLGenerado;
            var json_data = PlantillaJSON(xml);
            var dir_comprobante = await _ihandler.GetValueMemory("");
            _imasterjson.PostJSONAsync(dir_comprobante, json_data, token.access_token);

            if (_imasterjson.GetRawResponse().IsSuccessStatusCode)
            {
                state = eDocumentState.JSONEnviado;
            }//end of if
            else
            {
                var content = _imasterjson.GetRawResponse().Content;
                if (_imasterjson.GetRawResponse().StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    var mensajeerror = _imasterjson.GetRawResponse().Headers.GetValues("X-Error-Cause").FirstOrDefault() ?? "";
                    
                    state = (mensajeerror.Contains("ya fue recibido")?eDocumentState.JSONRecibidoAnterior:eDocumentState.JSONError
                
                }//end of if 
            }//end of else

            return state;
        }//end of EnviarJSON

        string PlantillaJSON(string xml)
        {
            string resultado = "";
            
            resultado = "{\n" + comillasdobles("clave") + ":" + comillasdobles(_ibuilder._idocumento.IDocumento.IEncabezado.Clave) + ",\n" +
                comillasdobles("fecha") + ":" + comillasdobles(DateTime.Now.ToRfc3339String()) + ",\n" +
                comillasdobles("emisor") + ": {\n" +
                comillasdobles("tipoIdentificacion") + ":" + comillasdobles(_ibuilder._idocumento.IDocumento.IEncabezado.Emisor.Identificacion.Tipo) + ",\n" +
                comillasdobles("numeroIdentificacion") + ":" + comillasdobles(_ibuilder._idocumento.IDocumento.IEncabezado.Emisor.Identificacion.Numero) + "},\n";
            if (!_ibuilder._idocumento.IDocumento.IEncabezado.Receptor.Identificacion.Numero.Blank())
            {
                resultado +=
                comillasdobles("receptor") + ": {\n" +
                comillasdobles("tipoIdentificacion") + ":" + comillasdobles((_ibuilder._idocumento.IDocumento.IEncabezado.Receptor.Identificacion.Tipo.Length > 9) ? "02" : "01") + ",\n" +
                comillasdobles("numeroIdentificacion") + ":" + comillasdobles(_ibuilder._idocumento.IDocumento.IEncabezado.Receptor.Identificacion.Numero) + "},\n";


            }
            else
            {
                resultado +=
                comillasdobles("receptor") + ": {\n" +
                comillasdobles("tipoIdentificacion") + ":" + comillasdobles("01") + ",\n" +
                comillasdobles("numeroIdentificacion") + ":" + comillasdobles("000000000") + "},\n";
            }

            resultado += comillasdobles("comprobanteXml") + ":" + comillasdobles(xml) + "\n}";

            return resultado;

        }

        async Task<eDocumentState> SendClientEmail()
        {
            eDocumentState resultado;
            try
            {
                var host = _ihandler.GetValueMemory(""); 
                var port= _ihandler.GetValueMemory(""); 
                var pwd = _ihandler.GetValueMemory(""); 
                var user = _ihandler.GetValueMemory(""); 
                var tempdir = _ihandler.GetValueMemory("");

                

            }
            catch (Exception ex)
            {

            }


            return resultado;

        }//end of SendClienteEmail

        string comillasdobles(string value)
        {
            return "\"" + value + "\"";
        }
        
        bool blank(string value)
        { 
            return value == null || value.Trim().Length == 0; 
        }

    }//end of class

}//end of namespace
