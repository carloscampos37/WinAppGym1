using System;

namespace Class
{
    public class ModParametrosGenerales
    {
        public static Parametrosdeempresa VGParametros;

        public struct Parametrosdeempresa
        {
            public string monedabase;
            public string direccionempresa;

            public bool multifacturas;
            public short multicajas;
            public bool permite_tc;
            public short codigosduplicados;
            public string NomEmpresa;
            public string RucEmpresa;
            public string puntovta;
            public string empresacodigo;
            public string mesproceso;
            public string nombrefactura;
            public bool auxaut;
            public bool sistemamultiempresas;

            public double SistemaMinimoRetencion;
            public double porcentajeretencion;

            public double Porcentajeimpto;
            public short numeauto;
            public short controlacodigocaja;
            public string empresacodigoretencion;
            public string empresacodigodetraccion;
            public short empresaretencion;
            public short diacierrerendicion;
            public bool PermiteRequerimientos;
            public bool PermiteIngresosconRequerimientos;
            public string tipocreacioncodigo;
            public bool ventasAuto;
            public bool NumDocumentos;
            public string listaPuntoVtas;
            public string listacajas;
            public string descripcion;
            public short ControlaTipoCambio;
            public short controlarefe;
            public double ValorUit;

            public string PuntoVtaserie;
            public string EmpresaFacturaselectronicas;

            public bool cierremes;
            public string sistemactaajustehab;
            public string sistemactaajustedeb;
            public bool Empresaasientosautomaticos;
            public bool ConsolidaPtosVtasFE;

            public string Clienteeventual;
            public bool EnvioSedePrincipal;
            public bool Esquemainafecto;
        }

        public static ParametrosdeSistema VGParamSistem;

        public struct ParametrosdeSistema
        {
            public string mesproceso;
            public string AnoProceso;
            public DateTime fechatrabajo;
            public string RutaReport;
            public string UsuarioReporte;

            public string Servidor;
            public string BDEmpresa;
            public string Usuario;
            public string Pwd;
            public string Equipo;

            public string ServidorE;
            public string BDEmpresaE;
            public string USUARIOE;
            public string PwdE;

            public string ServidorMY;
            public string BDEmpresaMY;
            public string UsuarioMY;
            public string PwdMY;

            public string BDEmpresaCONF;
            public string ServidorCT;
            public string BDEmpresaCT;
            public string UsuarioCT;
            public string PwdCT;

            public string ServidorGEN;
            public string BDEmpresaGEN;
            public string UsuarioGEN;
            public string PwdGEN;

            public string Mensaje;
            public string listapre;
            public string carpetareportes;
            public string almacen;
            public int comivende;
            public string nombre;
            public string moneda;
            public string tieneigv;
            public double Igv;
            public string CarpetaLibrosElectronicos;
            public string CarpetaFacturasElectronicas;

            public double tipocambio;
            public int formaemi;
            public string paraboleta;
            public int paramvtamasivo;
            public int stockcomp;
            public int kitvirtual;
            public bool Tesoreriaenlinea;

            public bool tienedscto;
            public bool descuento;

            public bool CodigoProductoUnico;
            public double ImporteMinimoDni;
        }

        public static modoventa VGModoVenta;

        public struct modoventa // Crea modoventa
        {
            public string descuento;
            public bool impuestos;
            public double nroitem;
            public bool numeraauto;
            public bool ctrlinventario;
            public string unidadmedida;
            public double copiasfac;
            public double copiasbol;
            public double copiashoja;
            public double copiasBO;
            public double copiasguiarem;
            public bool ctacte;
            public bool ingcliente;
            public bool ingforma;
            public bool emiteguia;
            public bool emitefact;
            public bool modificaguia;
            public bool ingpedido;
            public string inghoja;
            public bool ingguia;
            public bool usafactor;
            public string documento;
            public string almacenes;
            public short copiastic;
            public short copiasGr;
            public bool emitehoja;
            public string valorizaliqcompra;
            public bool canje;
            public bool modovtanumautom;
        }
    }
}
