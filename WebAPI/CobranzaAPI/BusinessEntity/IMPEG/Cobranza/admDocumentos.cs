using System;
using System.Data;

namespace BusinessEntity.IMPEG.Cobranza
{
    public class admDocumentos : EntityBase
	{
        public admDocumentos()
		{
			_CSERIEDOCUMENTO = string.Empty;
			_CRAZONSOCIAL = string.Empty;
			_CRFC = string.Empty;
			_CREFERENCIA = string.Empty;
			_COBSERVACIONES = string.Empty;
			_CTEXTOEXTRA1 = string.Empty;
			_CTEXTOEXTRA2 = string.Empty;
			_CTEXTOEXTRA3 = string.Empty;
			_CDESTINATARIO = string.Empty;
			_CNUMEROGUIA = string.Empty;
			_CMENSAJERIA = string.Empty;
			_CCUENTAMENSAJERIA = string.Empty;
			_CTIMESTAMP = string.Empty;
			_CLUGAREXPE = string.Empty;
			_CMETODOPAG = string.Empty;
			_CCONDIPAGO = string.Empty;
			_CNUMCTAPAG = string.Empty;
			_CGUIDDOCUMENTO = string.Empty;
			_CUSUARIO = string.Empty;
			_CTRANSACTIONID = string.Empty;
		}

		System.Int32 _CIDDOCUMENTO;
		public System.Int32 CIDDOCUMENTO { get { return _CIDDOCUMENTO; } set { if (value >= 0) _CIDDOCUMENTO = value; } }

		System.Int32 _CIDDOCUMENTODE;
		public System.Int32 CIDDOCUMENTODE { get { return _CIDDOCUMENTODE; } set { if (value >= 0) _CIDDOCUMENTODE = value; } }

		System.Int32 _CIDCONCEPTODOCUMENTO;
		public System.Int32 CIDCONCEPTODOCUMENTO { get { return _CIDCONCEPTODOCUMENTO; } set { if (value >= 0) _CIDCONCEPTODOCUMENTO = value; } }

		System.String _CSERIEDOCUMENTO;
		public System.String CSERIEDOCUMENTO { get { return _CSERIEDOCUMENTO; } set { if (value.Length >= 11) _CSERIEDOCUMENTO = value.Substring(0, 11); else _CSERIEDOCUMENTO = value; } }

		System.Double _CFOLIO;
		public System.Double CFOLIO { get { return _CFOLIO; } set { if (value >= 0) _CFOLIO = value; } }

		System.DateTime? _CFECHA;
		public System.DateTime? CFECHA { get { return _CFECHA; } set { _CFECHA = value; } }

		System.Int32 _CIDCLIENTEPROVEEDOR;
		public System.Int32 CIDCLIENTEPROVEEDOR { get { return _CIDCLIENTEPROVEEDOR; } set { if (value >= 0) _CIDCLIENTEPROVEEDOR = value; } }

		System.String _CRAZONSOCIAL;
		public System.String CRAZONSOCIAL { get { return _CRAZONSOCIAL; } set { if (value.Length >= 60) _CRAZONSOCIAL = value.Substring(0, 60); else _CRAZONSOCIAL = value; } }

		System.String _CRFC;
		public System.String CRFC { get { return _CRFC; } set { if (value.Length >= 20) _CRFC = value.Substring(0, 20); else _CRFC = value; } }

		System.Int32 _CIDAGENTE;
		public System.Int32 CIDAGENTE { get { return _CIDAGENTE; } set { if (value >= 0) _CIDAGENTE = value; } }

		System.DateTime? _CFECHAVENCIMIENTO;
		public System.DateTime? CFECHAVENCIMIENTO { get { return _CFECHAVENCIMIENTO; } set { _CFECHAVENCIMIENTO = value; } }

		System.DateTime? _CFECHAPRONTOPAGO;
		public System.DateTime? CFECHAPRONTOPAGO { get { return _CFECHAPRONTOPAGO; } set { _CFECHAPRONTOPAGO = value; } }

		System.DateTime? _CFECHAENTREGARECEPCION;
		public System.DateTime? CFECHAENTREGARECEPCION { get { return _CFECHAENTREGARECEPCION; } set { _CFECHAENTREGARECEPCION = value; } }

		System.DateTime? _CFECHAULTIMOINTERES;
		public System.DateTime? CFECHAULTIMOINTERES { get { return _CFECHAULTIMOINTERES; } set { _CFECHAULTIMOINTERES = value; } }

		System.Int32 _CIDMONEDA;
		public System.Int32 CIDMONEDA { get { return _CIDMONEDA; } set { if (value >= 0) _CIDMONEDA = value; } }

		System.Double _CTIPOCAMBIO;
		public System.Double CTIPOCAMBIO { get { return _CTIPOCAMBIO; } set { if (value >= 0) _CTIPOCAMBIO = value; } }

		System.String _CREFERENCIA;
		public System.String CREFERENCIA { get { return _CREFERENCIA; } set { if (value.Length >= 20) _CREFERENCIA = value.Substring(0, 20); else _CREFERENCIA = value; } }

		System.String _COBSERVACIONES;
		public System.String COBSERVACIONES { get { return _COBSERVACIONES; } set { if (value.Length >= 2147483647) _COBSERVACIONES = value.Substring(0, 2147483647); else _COBSERVACIONES = value; } }

		System.Int32 _CNATURALEZA;
		public System.Int32 CNATURALEZA { get { return _CNATURALEZA; } set { if (value >= 0) _CNATURALEZA = value; } }

		System.Int32 _CIDDOCUMENTOORIGEN;
		public System.Int32 CIDDOCUMENTOORIGEN { get { return _CIDDOCUMENTOORIGEN; } set { if (value >= 0) _CIDDOCUMENTOORIGEN = value; } }

		System.Int32 _CPLANTILLA;
		public System.Int32 CPLANTILLA { get { return _CPLANTILLA; } set { if (value >= 0) _CPLANTILLA = value; } }

		System.Int32 _CUSACLIENTE;
		public System.Int32 CUSACLIENTE { get { return _CUSACLIENTE; } set { if (value >= 0) _CUSACLIENTE = value; } }

		System.Int32 _CUSAPROVEEDOR;
		public System.Int32 CUSAPROVEEDOR { get { return _CUSAPROVEEDOR; } set { if (value >= 0) _CUSAPROVEEDOR = value; } }

		System.Int32 _CAFECTADO;
		public System.Int32 CAFECTADO { get { return _CAFECTADO; } set { if (value >= 0) _CAFECTADO = value; } }

		System.Int32 _CIMPRESO;
		public System.Int32 CIMPRESO { get { return _CIMPRESO; } set { if (value >= 0) _CIMPRESO = value; } }

		System.Int32 _CCANCELADO;
		public System.Int32 CCANCELADO { get { return _CCANCELADO; } set { if (value >= 0) _CCANCELADO = value; } }

		System.Int32 _CDEVUELTO;
		public System.Int32 CDEVUELTO { get { return _CDEVUELTO; } set { if (value >= 0) _CDEVUELTO = value; } }

		System.Int32 _CIDPREPOLIZA;
		public System.Int32 CIDPREPOLIZA { get { return _CIDPREPOLIZA; } set { if (value >= 0) _CIDPREPOLIZA = value; } }

		System.Int32 _CIDPREPOLIZACANCELACION;
		public System.Int32 CIDPREPOLIZACANCELACION { get { return _CIDPREPOLIZACANCELACION; } set { if (value >= 0) _CIDPREPOLIZACANCELACION = value; } }

		System.Int32 _CESTADOCONTABLE;
		public System.Int32 CESTADOCONTABLE { get { return _CESTADOCONTABLE; } set { if (value >= 0) _CESTADOCONTABLE = value; } }

		System.Double _CNETO;
		public System.Double CNETO { get { return _CNETO; } set { if (value >= 0) _CNETO = value; } }

		System.Double _CIMPUESTO1;
		public System.Double CIMPUESTO1 { get { return _CIMPUESTO1; } set { if (value >= 0) _CIMPUESTO1 = value; } }

		System.Double _CIMPUESTO2;
		public System.Double CIMPUESTO2 { get { return _CIMPUESTO2; } set { if (value >= 0) _CIMPUESTO2 = value; } }

		System.Double _CIMPUESTO3;
		public System.Double CIMPUESTO3 { get { return _CIMPUESTO3; } set { if (value >= 0) _CIMPUESTO3 = value; } }

		System.Double _CRETENCION1;
		public System.Double CRETENCION1 { get { return _CRETENCION1; } set { if (value >= 0) _CRETENCION1 = value; } }

		System.Double _CRETENCION2;
		public System.Double CRETENCION2 { get { return _CRETENCION2; } set { if (value >= 0) _CRETENCION2 = value; } }

		System.Double _CDESCUENTOMOV;
		public System.Double CDESCUENTOMOV { get { return _CDESCUENTOMOV; } set { if (value >= 0) _CDESCUENTOMOV = value; } }

		System.Double _CDESCUENTODOC1;
		public System.Double CDESCUENTODOC1 { get { return _CDESCUENTODOC1; } set { if (value >= 0) _CDESCUENTODOC1 = value; } }

		System.Double _CDESCUENTODOC2;
		public System.Double CDESCUENTODOC2 { get { return _CDESCUENTODOC2; } set { if (value >= 0) _CDESCUENTODOC2 = value; } }

		System.Double _CGASTO1;
		public System.Double CGASTO1 { get { return _CGASTO1; } set { if (value >= 0) _CGASTO1 = value; } }

		System.Double _CGASTO2;
		public System.Double CGASTO2 { get { return _CGASTO2; } set { if (value >= 0) _CGASTO2 = value; } }

		System.Double _CGASTO3;
		public System.Double CGASTO3 { get { return _CGASTO3; } set { if (value >= 0) _CGASTO3 = value; } }

		System.Double _CTOTAL;
		public System.Double CTOTAL { get { return _CTOTAL; } set { if (value >= 0) _CTOTAL = value; } }

		System.Double _CPENDIENTE;
		public System.Double CPENDIENTE { get { return _CPENDIENTE; } set { if (value >= 0) _CPENDIENTE = value; } }

		System.Double _CTOTALUNIDADES;
		public System.Double CTOTALUNIDADES { get { return _CTOTALUNIDADES; } set { if (value >= 0) _CTOTALUNIDADES = value; } }

		System.Double _CDESCUENTOPRONTOPAGO;
		public System.Double CDESCUENTOPRONTOPAGO { get { return _CDESCUENTOPRONTOPAGO; } set { if (value >= 0) _CDESCUENTOPRONTOPAGO = value; } }

		System.Double _CPORCENTAJEIMPUESTO1;
		public System.Double CPORCENTAJEIMPUESTO1 { get { return _CPORCENTAJEIMPUESTO1; } set { if (value >= 0) _CPORCENTAJEIMPUESTO1 = value; } }

		System.Double _CPORCENTAJEIMPUESTO2;
		public System.Double CPORCENTAJEIMPUESTO2 { get { return _CPORCENTAJEIMPUESTO2; } set { if (value >= 0) _CPORCENTAJEIMPUESTO2 = value; } }

		System.Double _CPORCENTAJEIMPUESTO3;
		public System.Double CPORCENTAJEIMPUESTO3 { get { return _CPORCENTAJEIMPUESTO3; } set { if (value >= 0) _CPORCENTAJEIMPUESTO3 = value; } }

		System.Double _CPORCENTAJERETENCION1;
		public System.Double CPORCENTAJERETENCION1 { get { return _CPORCENTAJERETENCION1; } set { if (value >= 0) _CPORCENTAJERETENCION1 = value; } }

		System.Double _CPORCENTAJERETENCION2;
		public System.Double CPORCENTAJERETENCION2 { get { return _CPORCENTAJERETENCION2; } set { if (value >= 0) _CPORCENTAJERETENCION2 = value; } }

		System.Double _CPORCENTAJEINTERES;
		public System.Double CPORCENTAJEINTERES { get { return _CPORCENTAJEINTERES; } set { if (value >= 0) _CPORCENTAJEINTERES = value; } }

		System.String _CTEXTOEXTRA1;
		public System.String CTEXTOEXTRA1 { get { return _CTEXTOEXTRA1; } set { if (value.Length >= 50) _CTEXTOEXTRA1 = value.Substring(0, 50); else _CTEXTOEXTRA1 = value; } }

		System.String _CTEXTOEXTRA2;
		public System.String CTEXTOEXTRA2 { get { return _CTEXTOEXTRA2; } set { if (value.Length >= 50) _CTEXTOEXTRA2 = value.Substring(0, 50); else _CTEXTOEXTRA2 = value; } }

		System.String _CTEXTOEXTRA3;
		public System.String CTEXTOEXTRA3 { get { return _CTEXTOEXTRA3; } set { if (value.Length >= 50) _CTEXTOEXTRA3 = value.Substring(0, 50); else _CTEXTOEXTRA3 = value; } }

		System.DateTime? _CFECHAEXTRA;
		public System.DateTime? CFECHAEXTRA { get { return _CFECHAEXTRA; } set { _CFECHAEXTRA = value; } }

		System.Double _CIMPORTEEXTRA1;
		public System.Double CIMPORTEEXTRA1 { get { return _CIMPORTEEXTRA1; } set { if (value >= 0) _CIMPORTEEXTRA1 = value; } }

		System.Double _CIMPORTEEXTRA2;
		public System.Double CIMPORTEEXTRA2 { get { return _CIMPORTEEXTRA2; } set { if (value >= 0) _CIMPORTEEXTRA2 = value; } }

		System.Double _CIMPORTEEXTRA3;
		public System.Double CIMPORTEEXTRA3 { get { return _CIMPORTEEXTRA3; } set { if (value >= 0) _CIMPORTEEXTRA3 = value; } }

		System.Double _CIMPORTEEXTRA4;
		public System.Double CIMPORTEEXTRA4 { get { return _CIMPORTEEXTRA4; } set { if (value >= 0) _CIMPORTEEXTRA4 = value; } }

		System.String _CDESTINATARIO;
		public System.String CDESTINATARIO { get { return _CDESTINATARIO; } set { if (value.Length >= 60) _CDESTINATARIO = value.Substring(0, 60); else _CDESTINATARIO = value; } }

		System.String _CNUMEROGUIA;
		public System.String CNUMEROGUIA { get { return _CNUMEROGUIA; } set { if (value.Length >= 60) _CNUMEROGUIA = value.Substring(0, 60); else _CNUMEROGUIA = value; } }

		System.String _CMENSAJERIA;
		public System.String CMENSAJERIA { get { return _CMENSAJERIA; } set { if (value.Length >= 20) _CMENSAJERIA = value.Substring(0, 20); else _CMENSAJERIA = value; } }

		System.String _CCUENTAMENSAJERIA;
		public System.String CCUENTAMENSAJERIA { get { return _CCUENTAMENSAJERIA; } set { if (value.Length >= 120) _CCUENTAMENSAJERIA = value.Substring(0, 120); else _CCUENTAMENSAJERIA = value; } }

		System.Double _CNUMEROCAJAS;
		public System.Double CNUMEROCAJAS { get { return _CNUMEROCAJAS; } set { if (value >= 0) _CNUMEROCAJAS = value; } }

		System.Double _CPESO;
		public System.Double CPESO { get { return _CPESO; } set { if (value >= 0) _CPESO = value; } }

		System.Int32 _CBANOBSERVACIONES;
		public System.Int32 CBANOBSERVACIONES { get { return _CBANOBSERVACIONES; } set { if (value >= 0) _CBANOBSERVACIONES = value; } }

		System.Int32 _CBANDATOSENVIO;
		public System.Int32 CBANDATOSENVIO { get { return _CBANDATOSENVIO; } set { if (value >= 0) _CBANDATOSENVIO = value; } }

		System.Int32 _CBANCONDICIONESCREDITO;
		public System.Int32 CBANCONDICIONESCREDITO { get { return _CBANCONDICIONESCREDITO; } set { if (value >= 0) _CBANCONDICIONESCREDITO = value; } }

		System.Int32 _CBANGASTOS;
		public System.Int32 CBANGASTOS { get { return _CBANGASTOS; } set { if (value >= 0) _CBANGASTOS = value; } }

		System.Double _CUNIDADESPENDIENTES;
		public System.Double CUNIDADESPENDIENTES { get { return _CUNIDADESPENDIENTES; } set { if (value >= 0) _CUNIDADESPENDIENTES = value; } }

		System.String _CTIMESTAMP;
		public System.String CTIMESTAMP { get { return _CTIMESTAMP; } set { if (value.Length >= 23) _CTIMESTAMP = value.Substring(0, 23); else _CTIMESTAMP = value; } }

		System.Double _CIMPCHEQPAQ;
		public System.Double CIMPCHEQPAQ { get { return _CIMPCHEQPAQ; } set { if (value >= 0) _CIMPCHEQPAQ = value; } }

		System.Int32 _CSISTORIG;
		public System.Int32 CSISTORIG { get { return _CSISTORIG; } set { if (value >= 0) _CSISTORIG = value; } }

		System.Int32 _CIDMONEDCA;
		public System.Int32 CIDMONEDCA { get { return _CIDMONEDCA; } set { if (value >= 0) _CIDMONEDCA = value; } }

		System.Double _CTIPOCAMCA;
		public System.Double CTIPOCAMCA { get { return _CTIPOCAMCA; } set { if (value >= 0) _CTIPOCAMCA = value; } }

		System.Int32 _CESCFD;
		public System.Int32 CESCFD { get { return _CESCFD; } set { if (value >= 0) _CESCFD = value; } }

		System.Int32 _CTIENECFD;
		public System.Int32 CTIENECFD { get { return _CTIENECFD; } set { if (value >= 0) _CTIENECFD = value; } }

		System.String _CLUGAREXPE;
		public System.String CLUGAREXPE { get { return _CLUGAREXPE; } set { if (value.Length >= 380) _CLUGAREXPE = value.Substring(0, 380); else _CLUGAREXPE = value; } }

		System.String _CMETODOPAG;
		public System.String CMETODOPAG { get { return _CMETODOPAG; } set { if (value.Length >= 100) _CMETODOPAG = value.Substring(0, 100); else _CMETODOPAG = value; } }

		System.Int32 _CNUMPARCIA;
		public System.Int32 CNUMPARCIA { get { return _CNUMPARCIA; } set { if (value >= 0) _CNUMPARCIA = value; } }

		System.Int32 _CCANTPARCI;
		public System.Int32 CCANTPARCI { get { return _CCANTPARCI; } set { if (value >= 0) _CCANTPARCI = value; } }

		System.String _CCONDIPAGO;
		public System.String CCONDIPAGO { get { return _CCONDIPAGO; } set { if (value.Length >= 253) _CCONDIPAGO = value.Substring(0, 253); else _CCONDIPAGO = value; } }

		System.String _CNUMCTAPAG;
		public System.String CNUMCTAPAG { get { return _CNUMCTAPAG; } set { if (value.Length >= 100) _CNUMCTAPAG = value.Substring(0, 100); else _CNUMCTAPAG = value; } }

		System.String _CGUIDDOCUMENTO;
		public System.String CGUIDDOCUMENTO { get { return _CGUIDDOCUMENTO; } set { if (value.Length >= 40) _CGUIDDOCUMENTO = value.Substring(0, 40); else _CGUIDDOCUMENTO = value; } }

		System.String _CUSUARIO;
		public System.String CUSUARIO { get { return _CUSUARIO; } set { if (value.Length >= 15) _CUSUARIO = value.Substring(0, 15); else _CUSUARIO = value; } }

		System.Int32 _CIDPROYECTO;
		public System.Int32 CIDPROYECTO { get { return _CIDPROYECTO; } set { if (value >= 0) _CIDPROYECTO = value; } }

		System.Int32 _CIDCUENTA;
		public System.Int32 CIDCUENTA { get { return _CIDCUENTA; } set { if (value >= 0) _CIDCUENTA = value; } }

		System.String _CTRANSACTIONID;
		public System.String CTRANSACTIONID { get { return _CTRANSACTIONID; } set { if (value.Length >= 26) _CTRANSACTIONID = value.Substring(0, 26); else _CTRANSACTIONID = value; } }

	}
}
