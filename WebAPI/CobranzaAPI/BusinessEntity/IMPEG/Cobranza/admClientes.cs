using System;
using System.Data;

namespace BusinessEntity.IMPEG.Cobranza
{
	public class admClientes : EntityBase
	{
        public admClientes()
		{
			_CCODIGOCLIENTE = string.Empty;
			_CRAZONSOCIAL = string.Empty;
			_CRFC = string.Empty;
			_CCURP = string.Empty;
			_CDENCOMERCIAL = string.Empty;
			_CREPLEGAL = string.Empty;
			_CMENSAJERIA = string.Empty;
			_CCUENTAMENSAJERIA = string.Empty;
			_CSEGCONTCLIENTE1 = string.Empty;
			_CSEGCONTCLIENTE2 = string.Empty;
			_CSEGCONTCLIENTE3 = string.Empty;
			_CSEGCONTCLIENTE4 = string.Empty;
			_CSEGCONTCLIENTE5 = string.Empty;
			_CSEGCONTCLIENTE6 = string.Empty;
			_CSEGCONTCLIENTE7 = string.Empty;
			_CSEGCONTPROVEEDOR1 = string.Empty;
			_CSEGCONTPROVEEDOR2 = string.Empty;
			_CSEGCONTPROVEEDOR3 = string.Empty;
			_CSEGCONTPROVEEDOR4 = string.Empty;
			_CSEGCONTPROVEEDOR5 = string.Empty;
			_CSEGCONTPROVEEDOR6 = string.Empty;
			_CSEGCONTPROVEEDOR7 = string.Empty;
			_CTEXTOEXTRA1 = string.Empty;
			_CTEXTOEXTRA2 = string.Empty;
			_CTEXTOEXTRA3 = string.Empty;
			_CTIMESTAMP = string.Empty;
			_CEMAIL1 = string.Empty;
			_CEMAIL2 = string.Empty;
			_CEMAIL3 = string.Empty;
			_CTEXTOEXTRA4 = string.Empty;
			_CTEXTOEXTRA5 = string.Empty;
			_CCON1NOM = string.Empty;
			_CCON1TEL = string.Empty;
			_CSITIOFTP = string.Empty;
			_CUSRFTP = string.Empty;
			_CMETODOPAG = string.Empty;
			_CNUMCTAPAG = string.Empty;
			_CUSOCFDI = string.Empty;
		}

		System.Int32 _CIDCLIENTEPROVEEDOR;
		public System.Int32 CIDCLIENTEPROVEEDOR { get { return _CIDCLIENTEPROVEEDOR; } set { if (value >= 0) _CIDCLIENTEPROVEEDOR = value; } }

		System.String _CCODIGOCLIENTE;
		public System.String CCODIGOCLIENTE { get { return _CCODIGOCLIENTE; } set { if (value.Length >= 30) _CCODIGOCLIENTE = value.Substring(0, 30); else _CCODIGOCLIENTE = value; } }

		System.String _CRAZONSOCIAL;
		public System.String CRAZONSOCIAL { get { return _CRAZONSOCIAL; } set { if (value.Length >= 60) _CRAZONSOCIAL = value.Substring(0, 60); else _CRAZONSOCIAL = value; } }

		System.DateTime? _CFECHAALTA;
		public System.DateTime? CFECHAALTA { get { return _CFECHAALTA; } set { _CFECHAALTA = value; } }

		System.String _CRFC;
		public System.String CRFC { get { return _CRFC; } set { if (value.Length >= 20) _CRFC = value.Substring(0, 20); else _CRFC = value; } }

		System.String _CCURP;
		public System.String CCURP { get { return _CCURP; } set { if (value.Length >= 20) _CCURP = value.Substring(0, 20); else _CCURP = value; } }

		System.String _CDENCOMERCIAL;
		public System.String CDENCOMERCIAL { get { return _CDENCOMERCIAL; } set { if (value.Length >= 50) _CDENCOMERCIAL = value.Substring(0, 50); else _CDENCOMERCIAL = value; } }

		System.String _CREPLEGAL;
		public System.String CREPLEGAL { get { return _CREPLEGAL; } set { if (value.Length >= 50) _CREPLEGAL = value.Substring(0, 50); else _CREPLEGAL = value; } }

		System.Int32 _CIDMONEDA;
		public System.Int32 CIDMONEDA { get { return _CIDMONEDA; } set { if (value >= 0) _CIDMONEDA = value; } }

		System.Int32 _CLISTAPRECIOCLIENTE;
		public System.Int32 CLISTAPRECIOCLIENTE { get { return _CLISTAPRECIOCLIENTE; } set { if (value >= 0) _CLISTAPRECIOCLIENTE = value; } }

		System.Double _CDESCUENTODOCTO;
		public System.Double CDESCUENTODOCTO { get { return _CDESCUENTODOCTO; } set { if (value >= 0) _CDESCUENTODOCTO = value; } }

		System.Double _CDESCUENTOMOVTO;
		public System.Double CDESCUENTOMOVTO { get { return _CDESCUENTOMOVTO; } set { if (value >= 0) _CDESCUENTOMOVTO = value; } }

		System.Int32 _CBANVENTACREDITO;
		public System.Int32 CBANVENTACREDITO { get { return _CBANVENTACREDITO; } set { if (value >= 0) _CBANVENTACREDITO = value; } }

		System.Int32 _CIDVALORCLASIFCLIENTE1;
		public System.Int32 CIDVALORCLASIFCLIENTE1 { get { return _CIDVALORCLASIFCLIENTE1; } set { if (value >= 0) _CIDVALORCLASIFCLIENTE1 = value; } }

		System.Int32 _CIDVALORCLASIFCLIENTE2;
		public System.Int32 CIDVALORCLASIFCLIENTE2 { get { return _CIDVALORCLASIFCLIENTE2; } set { if (value >= 0) _CIDVALORCLASIFCLIENTE2 = value; } }

		System.Int32 _CIDVALORCLASIFCLIENTE3;
		public System.Int32 CIDVALORCLASIFCLIENTE3 { get { return _CIDVALORCLASIFCLIENTE3; } set { if (value >= 0) _CIDVALORCLASIFCLIENTE3 = value; } }

		System.Int32 _CIDVALORCLASIFCLIENTE4;
		public System.Int32 CIDVALORCLASIFCLIENTE4 { get { return _CIDVALORCLASIFCLIENTE4; } set { if (value >= 0) _CIDVALORCLASIFCLIENTE4 = value; } }

		System.Int32 _CIDVALORCLASIFCLIENTE5;
		public System.Int32 CIDVALORCLASIFCLIENTE5 { get { return _CIDVALORCLASIFCLIENTE5; } set { if (value >= 0) _CIDVALORCLASIFCLIENTE5 = value; } }

		System.Int32 _CIDVALORCLASIFCLIENTE6;
		public System.Int32 CIDVALORCLASIFCLIENTE6 { get { return _CIDVALORCLASIFCLIENTE6; } set { if (value >= 0) _CIDVALORCLASIFCLIENTE6 = value; } }

		System.Int32 _CTIPOCLIENTE;
		public System.Int32 CTIPOCLIENTE { get { return _CTIPOCLIENTE; } set { if (value >= 0) _CTIPOCLIENTE = value; } }

		System.Int32 _CESTATUS;
		public System.Int32 CESTATUS { get { return _CESTATUS; } set { if (value >= 0) _CESTATUS = value; } }

		System.DateTime? _CFECHABAJA;
		public System.DateTime? CFECHABAJA { get { return _CFECHABAJA; } set { _CFECHABAJA = value; } }

		System.DateTime? _CFECHAULTIMAREVISION;
		public System.DateTime? CFECHAULTIMAREVISION { get { return _CFECHAULTIMAREVISION; } set { _CFECHAULTIMAREVISION = value; } }

		System.Double _CLIMITECREDITOCLIENTE;
		public System.Double CLIMITECREDITOCLIENTE { get { return _CLIMITECREDITOCLIENTE; } set { if (value >= 0) _CLIMITECREDITOCLIENTE = value; } }

		System.Int32 _CDIASCREDITOCLIENTE;
		public System.Int32 CDIASCREDITOCLIENTE { get { return _CDIASCREDITOCLIENTE; } set { if (value >= 0) _CDIASCREDITOCLIENTE = value; } }

		System.Int32 _CBANEXCEDERCREDITO;
		public System.Int32 CBANEXCEDERCREDITO { get { return _CBANEXCEDERCREDITO; } set { if (value >= 0) _CBANEXCEDERCREDITO = value; } }

		System.Double _CDESCUENTOPRONTOPAGO;
		public System.Double CDESCUENTOPRONTOPAGO { get { return _CDESCUENTOPRONTOPAGO; } set { if (value >= 0) _CDESCUENTOPRONTOPAGO = value; } }

		System.Int32 _CDIASPRONTOPAGO;
		public System.Int32 CDIASPRONTOPAGO { get { return _CDIASPRONTOPAGO; } set { if (value >= 0) _CDIASPRONTOPAGO = value; } }

		System.Double _CINTERESMORATORIO;
		public System.Double CINTERESMORATORIO { get { return _CINTERESMORATORIO; } set { if (value >= 0) _CINTERESMORATORIO = value; } }

		System.Int32 _CDIAPAGO;
		public System.Int32 CDIAPAGO { get { return _CDIAPAGO; } set { if (value >= 0) _CDIAPAGO = value; } }

		System.Int32 _CDIASREVISION;
		public System.Int32 CDIASREVISION { get { return _CDIASREVISION; } set { if (value >= 0) _CDIASREVISION = value; } }

		System.String _CMENSAJERIA;
		public System.String CMENSAJERIA { get { return _CMENSAJERIA; } set { if (value.Length >= 20) _CMENSAJERIA = value.Substring(0, 20); else _CMENSAJERIA = value; } }

		System.String _CCUENTAMENSAJERIA;
		public System.String CCUENTAMENSAJERIA { get { return _CCUENTAMENSAJERIA; } set { if (value.Length >= 60) _CCUENTAMENSAJERIA = value.Substring(0, 60); else _CCUENTAMENSAJERIA = value; } }

		System.Int32 _CDIASEMBARQUECLIENTE;
		public System.Int32 CDIASEMBARQUECLIENTE { get { return _CDIASEMBARQUECLIENTE; } set { if (value >= 0) _CDIASEMBARQUECLIENTE = value; } }

		System.Int32 _CIDALMACEN;
		public System.Int32 CIDALMACEN { get { return _CIDALMACEN; } set { if (value >= 0) _CIDALMACEN = value; } }

		System.Int32 _CIDAGENTEVENTA;
		public System.Int32 CIDAGENTEVENTA { get { return _CIDAGENTEVENTA; } set { if (value >= 0) _CIDAGENTEVENTA = value; } }

		System.Int32 _CIDAGENTECOBRO;
		public System.Int32 CIDAGENTECOBRO { get { return _CIDAGENTECOBRO; } set { if (value >= 0) _CIDAGENTECOBRO = value; } }

		System.Int32 _CRESTRICCIONAGENTE;
		public System.Int32 CRESTRICCIONAGENTE { get { return _CRESTRICCIONAGENTE; } set { if (value >= 0) _CRESTRICCIONAGENTE = value; } }

		System.Double _CIMPUESTO1;
		public System.Double CIMPUESTO1 { get { return _CIMPUESTO1; } set { if (value >= 0) _CIMPUESTO1 = value; } }

		System.Double _CIMPUESTO2;
		public System.Double CIMPUESTO2 { get { return _CIMPUESTO2; } set { if (value >= 0) _CIMPUESTO2 = value; } }

		System.Double _CIMPUESTO3;
		public System.Double CIMPUESTO3 { get { return _CIMPUESTO3; } set { if (value >= 0) _CIMPUESTO3 = value; } }

		System.Double _CRETENCIONCLIENTE1;
		public System.Double CRETENCIONCLIENTE1 { get { return _CRETENCIONCLIENTE1; } set { if (value >= 0) _CRETENCIONCLIENTE1 = value; } }

		System.Double _CRETENCIONCLIENTE2;
		public System.Double CRETENCIONCLIENTE2 { get { return _CRETENCIONCLIENTE2; } set { if (value >= 0) _CRETENCIONCLIENTE2 = value; } }

		System.Int32 _CIDVALORCLASIFPROVEEDOR1;
		public System.Int32 CIDVALORCLASIFPROVEEDOR1 { get { return _CIDVALORCLASIFPROVEEDOR1; } set { if (value >= 0) _CIDVALORCLASIFPROVEEDOR1 = value; } }

		System.Int32 _CIDVALORCLASIFPROVEEDOR2;
		public System.Int32 CIDVALORCLASIFPROVEEDOR2 { get { return _CIDVALORCLASIFPROVEEDOR2; } set { if (value >= 0) _CIDVALORCLASIFPROVEEDOR2 = value; } }

		System.Int32 _CIDVALORCLASIFPROVEEDOR3;
		public System.Int32 CIDVALORCLASIFPROVEEDOR3 { get { return _CIDVALORCLASIFPROVEEDOR3; } set { if (value >= 0) _CIDVALORCLASIFPROVEEDOR3 = value; } }

		System.Int32 _CIDVALORCLASIFPROVEEDOR4;
		public System.Int32 CIDVALORCLASIFPROVEEDOR4 { get { return _CIDVALORCLASIFPROVEEDOR4; } set { if (value >= 0) _CIDVALORCLASIFPROVEEDOR4 = value; } }

		System.Int32 _CIDVALORCLASIFPROVEEDOR5;
		public System.Int32 CIDVALORCLASIFPROVEEDOR5 { get { return _CIDVALORCLASIFPROVEEDOR5; } set { if (value >= 0) _CIDVALORCLASIFPROVEEDOR5 = value; } }

		System.Int32 _CIDVALORCLASIFPROVEEDOR6;
		public System.Int32 CIDVALORCLASIFPROVEEDOR6 { get { return _CIDVALORCLASIFPROVEEDOR6; } set { if (value >= 0) _CIDVALORCLASIFPROVEEDOR6 = value; } }

		System.Double _CLIMITECREDITOPROVEEDOR;
		public System.Double CLIMITECREDITOPROVEEDOR { get { return _CLIMITECREDITOPROVEEDOR; } set { if (value >= 0) _CLIMITECREDITOPROVEEDOR = value; } }

		System.Int32 _CDIASCREDITOPROVEEDOR;
		public System.Int32 CDIASCREDITOPROVEEDOR { get { return _CDIASCREDITOPROVEEDOR; } set { if (value >= 0) _CDIASCREDITOPROVEEDOR = value; } }

		System.Int32 _CTIEMPOENTREGA;
		public System.Int32 CTIEMPOENTREGA { get { return _CTIEMPOENTREGA; } set { if (value >= 0) _CTIEMPOENTREGA = value; } }

		System.Int32 _CDIASEMBARQUEPROVEEDOR;
		public System.Int32 CDIASEMBARQUEPROVEEDOR { get { return _CDIASEMBARQUEPROVEEDOR; } set { if (value >= 0) _CDIASEMBARQUEPROVEEDOR = value; } }

		System.Double _CIMPUESTOPROVEEDOR1;
		public System.Double CIMPUESTOPROVEEDOR1 { get { return _CIMPUESTOPROVEEDOR1; } set { if (value >= 0) _CIMPUESTOPROVEEDOR1 = value; } }

		System.Double _CIMPUESTOPROVEEDOR2;
		public System.Double CIMPUESTOPROVEEDOR2 { get { return _CIMPUESTOPROVEEDOR2; } set { if (value >= 0) _CIMPUESTOPROVEEDOR2 = value; } }

		System.Double _CIMPUESTOPROVEEDOR3;
		public System.Double CIMPUESTOPROVEEDOR3 { get { return _CIMPUESTOPROVEEDOR3; } set { if (value >= 0) _CIMPUESTOPROVEEDOR3 = value; } }

		System.Double _CRETENCIONPROVEEDOR1;
		public System.Double CRETENCIONPROVEEDOR1 { get { return _CRETENCIONPROVEEDOR1; } set { if (value >= 0) _CRETENCIONPROVEEDOR1 = value; } }

		System.Double _CRETENCIONPROVEEDOR2;
		public System.Double CRETENCIONPROVEEDOR2 { get { return _CRETENCIONPROVEEDOR2; } set { if (value >= 0) _CRETENCIONPROVEEDOR2 = value; } }

		System.Int32 _CBANINTERESMORATORIO;
		public System.Int32 CBANINTERESMORATORIO { get { return _CBANINTERESMORATORIO; } set { if (value >= 0) _CBANINTERESMORATORIO = value; } }

		System.Double _CCOMVENTAEXCEPCLIENTE;
		public System.Double CCOMVENTAEXCEPCLIENTE { get { return _CCOMVENTAEXCEPCLIENTE; } set { if (value >= 0) _CCOMVENTAEXCEPCLIENTE = value; } }

		System.Double _CCOMCOBROEXCEPCLIENTE;
		public System.Double CCOMCOBROEXCEPCLIENTE { get { return _CCOMCOBROEXCEPCLIENTE; } set { if (value >= 0) _CCOMCOBROEXCEPCLIENTE = value; } }

		System.Int32 _CBANPRODUCTOCONSIGNACION;
		public System.Int32 CBANPRODUCTOCONSIGNACION { get { return _CBANPRODUCTOCONSIGNACION; } set { if (value >= 0) _CBANPRODUCTOCONSIGNACION = value; } }

		System.String _CSEGCONTCLIENTE1;
		public System.String CSEGCONTCLIENTE1 { get { return _CSEGCONTCLIENTE1; } set { if (value.Length >= 50) _CSEGCONTCLIENTE1 = value.Substring(0, 50); else _CSEGCONTCLIENTE1 = value; } }

		System.String _CSEGCONTCLIENTE2;
		public System.String CSEGCONTCLIENTE2 { get { return _CSEGCONTCLIENTE2; } set { if (value.Length >= 50) _CSEGCONTCLIENTE2 = value.Substring(0, 50); else _CSEGCONTCLIENTE2 = value; } }

		System.String _CSEGCONTCLIENTE3;
		public System.String CSEGCONTCLIENTE3 { get { return _CSEGCONTCLIENTE3; } set { if (value.Length >= 50) _CSEGCONTCLIENTE3 = value.Substring(0, 50); else _CSEGCONTCLIENTE3 = value; } }

		System.String _CSEGCONTCLIENTE4;
		public System.String CSEGCONTCLIENTE4 { get { return _CSEGCONTCLIENTE4; } set { if (value.Length >= 50) _CSEGCONTCLIENTE4 = value.Substring(0, 50); else _CSEGCONTCLIENTE4 = value; } }

		System.String _CSEGCONTCLIENTE5;
		public System.String CSEGCONTCLIENTE5 { get { return _CSEGCONTCLIENTE5; } set { if (value.Length >= 50) _CSEGCONTCLIENTE5 = value.Substring(0, 50); else _CSEGCONTCLIENTE5 = value; } }

		System.String _CSEGCONTCLIENTE6;
		public System.String CSEGCONTCLIENTE6 { get { return _CSEGCONTCLIENTE6; } set { if (value.Length >= 50) _CSEGCONTCLIENTE6 = value.Substring(0, 50); else _CSEGCONTCLIENTE6 = value; } }

		System.String _CSEGCONTCLIENTE7;
		public System.String CSEGCONTCLIENTE7 { get { return _CSEGCONTCLIENTE7; } set { if (value.Length >= 50) _CSEGCONTCLIENTE7 = value.Substring(0, 50); else _CSEGCONTCLIENTE7 = value; } }

		System.String _CSEGCONTPROVEEDOR1;
		public System.String CSEGCONTPROVEEDOR1 { get { return _CSEGCONTPROVEEDOR1; } set { if (value.Length >= 50) _CSEGCONTPROVEEDOR1 = value.Substring(0, 50); else _CSEGCONTPROVEEDOR1 = value; } }

		System.String _CSEGCONTPROVEEDOR2;
		public System.String CSEGCONTPROVEEDOR2 { get { return _CSEGCONTPROVEEDOR2; } set { if (value.Length >= 50) _CSEGCONTPROVEEDOR2 = value.Substring(0, 50); else _CSEGCONTPROVEEDOR2 = value; } }

		System.String _CSEGCONTPROVEEDOR3;
		public System.String CSEGCONTPROVEEDOR3 { get { return _CSEGCONTPROVEEDOR3; } set { if (value.Length >= 50) _CSEGCONTPROVEEDOR3 = value.Substring(0, 50); else _CSEGCONTPROVEEDOR3 = value; } }

		System.String _CSEGCONTPROVEEDOR4;
		public System.String CSEGCONTPROVEEDOR4 { get { return _CSEGCONTPROVEEDOR4; } set { if (value.Length >= 50) _CSEGCONTPROVEEDOR4 = value.Substring(0, 50); else _CSEGCONTPROVEEDOR4 = value; } }

		System.String _CSEGCONTPROVEEDOR5;
		public System.String CSEGCONTPROVEEDOR5 { get { return _CSEGCONTPROVEEDOR5; } set { if (value.Length >= 50) _CSEGCONTPROVEEDOR5 = value.Substring(0, 50); else _CSEGCONTPROVEEDOR5 = value; } }

		System.String _CSEGCONTPROVEEDOR6;
		public System.String CSEGCONTPROVEEDOR6 { get { return _CSEGCONTPROVEEDOR6; } set { if (value.Length >= 50) _CSEGCONTPROVEEDOR6 = value.Substring(0, 50); else _CSEGCONTPROVEEDOR6 = value; } }

		System.String _CSEGCONTPROVEEDOR7;
		public System.String CSEGCONTPROVEEDOR7 { get { return _CSEGCONTPROVEEDOR7; } set { if (value.Length >= 50) _CSEGCONTPROVEEDOR7 = value.Substring(0, 50); else _CSEGCONTPROVEEDOR7 = value; } }

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

		System.Int32 _CBANDOMICILIO;
		public System.Int32 CBANDOMICILIO { get { return _CBANDOMICILIO; } set { if (value >= 0) _CBANDOMICILIO = value; } }

		System.Int32 _CBANCREDITOYCOBRANZA;
		public System.Int32 CBANCREDITOYCOBRANZA { get { return _CBANCREDITOYCOBRANZA; } set { if (value >= 0) _CBANCREDITOYCOBRANZA = value; } }

		System.Int32 _CBANENVIO;
		public System.Int32 CBANENVIO { get { return _CBANENVIO; } set { if (value >= 0) _CBANENVIO = value; } }

		System.Int32 _CBANAGENTE;
		public System.Int32 CBANAGENTE { get { return _CBANAGENTE; } set { if (value >= 0) _CBANAGENTE = value; } }

		System.Int32 _CBANIMPUESTO;
		public System.Int32 CBANIMPUESTO { get { return _CBANIMPUESTO; } set { if (value >= 0) _CBANIMPUESTO = value; } }

		System.Int32 _CBANPRECIO;
		public System.Int32 CBANPRECIO { get { return _CBANPRECIO; } set { if (value >= 0) _CBANPRECIO = value; } }

		System.String _CTIMESTAMP;
		public System.String CTIMESTAMP { get { return _CTIMESTAMP; } set { if (value.Length >= 23) _CTIMESTAMP = value.Substring(0, 23); else _CTIMESTAMP = value; } }

		System.Int32 _CFACTERC01;
		public System.Int32 CFACTERC01 { get { return _CFACTERC01; } set { if (value >= 0) _CFACTERC01 = value; } }

		System.Double _CCOMVENTA;
		public System.Double CCOMVENTA { get { return _CCOMVENTA; } set { if (value >= 0) _CCOMVENTA = value; } }

		System.Double _CCOMCOBRO;
		public System.Double CCOMCOBRO { get { return _CCOMCOBRO; } set { if (value >= 0) _CCOMCOBRO = value; } }

		System.Int32 _CIDMONEDA2;
		public System.Int32 CIDMONEDA2 { get { return _CIDMONEDA2; } set { if (value >= 0) _CIDMONEDA2 = value; } }

		System.String _CEMAIL1;
		public System.String CEMAIL1 { get { return _CEMAIL1; } set { if (value.Length >= 60) _CEMAIL1 = value.Substring(0, 60); else _CEMAIL1 = value; } }

		System.String _CEMAIL2;
		public System.String CEMAIL2 { get { return _CEMAIL2; } set { if (value.Length >= 60) _CEMAIL2 = value.Substring(0, 60); else _CEMAIL2 = value; } }

		System.String _CEMAIL3;
		public System.String CEMAIL3 { get { return _CEMAIL3; } set { if (value.Length >= 60) _CEMAIL3 = value.Substring(0, 60); else _CEMAIL3 = value; } }

		System.Int32 _CTIPOENTRE;
		public System.Int32 CTIPOENTRE { get { return _CTIPOENTRE; } set { if (value >= 0) _CTIPOENTRE = value; } }

		System.Int32 _CCONCTEEMA;
		public System.Int32 CCONCTEEMA { get { return _CCONCTEEMA; } set { if (value >= 0) _CCONCTEEMA = value; } }

		System.Int32 _CFTOADDEND;
		public System.Int32 CFTOADDEND { get { return _CFTOADDEND; } set { if (value >= 0) _CFTOADDEND = value; } }

		System.Int32 _CIDCERTCTE;
		public System.Int32 CIDCERTCTE { get { return _CIDCERTCTE; } set { if (value >= 0) _CIDCERTCTE = value; } }

		System.Int32 _CENCRIPENT;
		public System.Int32 CENCRIPENT { get { return _CENCRIPENT; } set { if (value >= 0) _CENCRIPENT = value; } }

		System.Int32 _CBANCFD;
		public System.Int32 CBANCFD { get { return _CBANCFD; } set { if (value >= 0) _CBANCFD = value; } }

		System.String _CTEXTOEXTRA4;
		public System.String CTEXTOEXTRA4 { get { return _CTEXTOEXTRA4; } set { if (value.Length >= 50) _CTEXTOEXTRA4 = value.Substring(0, 50); else _CTEXTOEXTRA4 = value; } }

		System.String _CTEXTOEXTRA5;
		public System.String CTEXTOEXTRA5 { get { return _CTEXTOEXTRA5; } set { if (value.Length >= 50) _CTEXTOEXTRA5 = value.Substring(0, 50); else _CTEXTOEXTRA5 = value; } }

		System.Double _CIMPORTEEXTRA5;
		public System.Double CIMPORTEEXTRA5 { get { return _CIMPORTEEXTRA5; } set { if (value >= 0) _CIMPORTEEXTRA5 = value; } }

		System.Int32 _CIDADDENDA;
		public System.Int32 CIDADDENDA { get { return _CIDADDENDA; } set { if (value >= 0) _CIDADDENDA = value; } }

		System.Int32 _CCODPROVCO;
		public System.Int32 CCODPROVCO { get { return _CCODPROVCO; } set { if (value >= 0) _CCODPROVCO = value; } }

		System.Int32 _CENVACUSE;
		public System.Int32 CENVACUSE { get { return _CENVACUSE; } set { if (value >= 0) _CENVACUSE = value; } }

		System.String _CCON1NOM;
		public System.String CCON1NOM { get { return _CCON1NOM; } set { if (value.Length >= 60) _CCON1NOM = value.Substring(0, 60); else _CCON1NOM = value; } }

		System.String _CCON1TEL;
		public System.String CCON1TEL { get { return _CCON1TEL; } set { if (value.Length >= 15) _CCON1TEL = value.Substring(0, 15); else _CCON1TEL = value; } }

		System.Int32 _CQUITABLAN;
		public System.Int32 CQUITABLAN { get { return _CQUITABLAN; } set { if (value >= 0) _CQUITABLAN = value; } }

		System.Int32 _CFMTOENTRE;
		public System.Int32 CFMTOENTRE { get { return _CFMTOENTRE; } set { if (value >= 0) _CFMTOENTRE = value; } }

		System.Int32 _CIDCOMPLEM;
		public System.Int32 CIDCOMPLEM { get { return _CIDCOMPLEM; } set { if (value >= 0) _CIDCOMPLEM = value; } }

		System.Int32 _CDESGLOSAI2;
		public System.Int32 CDESGLOSAI2 { get { return _CDESGLOSAI2; } set { if (value >= 0) _CDESGLOSAI2 = value; } }

		System.Int32 _CLIMDOCTOS;
		public System.Int32 CLIMDOCTOS { get { return _CLIMDOCTOS; } set { if (value >= 0) _CLIMDOCTOS = value; } }

		System.String _CSITIOFTP;
		public System.String CSITIOFTP { get { return _CSITIOFTP; } set { if (value.Length >= 60) _CSITIOFTP = value.Substring(0, 60); else _CSITIOFTP = value; } }

		System.String _CUSRFTP;
		public System.String CUSRFTP { get { return _CUSRFTP; } set { if (value.Length >= 60) _CUSRFTP = value.Substring(0, 60); else _CUSRFTP = value; } }

		System.String _CMETODOPAG;
		public System.String CMETODOPAG { get { return _CMETODOPAG; } set { if (value.Length >= 100) _CMETODOPAG = value.Substring(0, 100); else _CMETODOPAG = value; } }

		System.String _CNUMCTAPAG;
		public System.String CNUMCTAPAG { get { return _CNUMCTAPAG; } set { if (value.Length >= 100) _CNUMCTAPAG = value.Substring(0, 100); else _CNUMCTAPAG = value; } }

		System.Int32 _CIDCUENTA;
		public System.Int32 CIDCUENTA { get { return _CIDCUENTA; } set { if (value >= 0) _CIDCUENTA = value; } }

		System.String _CUSOCFDI;
		public System.String CUSOCFDI { get { return _CUSOCFDI; } set { if (value.Length >= 30) _CUSOCFDI = value.Substring(0, 30); else _CUSOCFDI = value; } }

	}
}
