using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHBrokerModels.ExtensionMethods;
using MHBrokerContracts.Requests.v4_3.IDocumento.Resumen;

namespace MHBrokerModels.Requests.v4_3.Resumen
{
    public class DocumentoResumen : IDocumentoResumen
    {
        public ICodigoTipoMoneda CodigoTipoMoneda { get; set; }
        
        private double _totalServGravados;
        public double TotalServGravados {

            get => _totalServGravados;
            set { _totalServGravados = value.FormatLimit(18,5); }
        }
        private double _totalServExentos;
        public double TotalServExentos {
            get => _totalServExentos;
            set { _totalServExentos = value.FormatLimit(18, 5); }
        }
        private double _totalServExonerado;
        public double TotalServExonerado
        {
            get => _totalServExonerado;
            set { _totalServExonerado = value.FormatLimit(18, 5); }
        }
        private double _totalMercanciasGravadas;
        public double TotalMercanciasGravadas {
            get => _totalMercanciasGravadas;
            set { _totalMercanciasGravadas = value.FormatLimit(18, 5); }
        }
        private double _totalMercanciasExentas;
        public double TotalMercanciasExentas
        {
            get => _totalMercanciasExentas;
            set { _totalMercanciasExentas = value.FormatLimit(18, 5); }
        }
        private double _totalMercExonerada;
        public double TotalMercExonerada {
            get => _totalMercExonerada;
            set { _totalMercExonerada = value.FormatLimit(18, 5); }
        }
        private double _totalGravado;
        public double TotalGravado {
            get => _totalGravado;
            set { _totalGravado = value.FormatLimit(18, 5); }
        }
        private double _totalExento;
        public double TotalExento {
            get => _totalExento;
            set { _totalExento = value.FormatLimit(18, 5); }
        }
        private double _totalExonerado;
        public double TotalExonerado {
            get => _totalExonerado;
            set { _totalExonerado = value.FormatLimit(18, 5); }
        }
        private double _totalVenta;
        public double TotalVenta {
            get => _totalVenta;
            set { _totalVenta = value.FormatLimit(18, 5); }
        }
        private double _totalDescuentos;
        public double TotalDescuentos {
            get => _totalDescuentos;
            set { _totalDescuentos = value.FormatLimit(18, 5); }

        }
        private double _totalVentaNeta;
        public double TotalVentaNeta
        {
            get => _totalVentaNeta;
            set { _totalVentaNeta = value.FormatLimit(18, 5); }
        }
        private double _totalImpuesto;
        public double TotalImpuesto {
            get => _totalImpuesto;
            set { _totalImpuesto = value.FormatLimit(18, 5); }
        }
        private double _totalIvaDevuelto;
        public double TotalIVADevuelto {
            get => _totalIvaDevuelto;
            set { _totalIvaDevuelto = value.FormatLimit(18, 5); }
        }
        private double _totalOtrosCargos;
        public double TotalOtrosCargos {
            get => _totalOtrosCargos;
            set { _totalOtrosCargos = value.FormatLimit(18, 5); }
        }
        private double _totalComprobante;
        public double TotalComprobante {
            get => _totalComprobante;
            set { _totalComprobante = value.FormatLimit(18, 5); }
        }
    }//end of DocumentoResumen
}//end of namespace
