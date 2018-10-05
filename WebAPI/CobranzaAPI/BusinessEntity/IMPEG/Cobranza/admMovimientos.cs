using System;
using System.Data;

namespace BusinessEntity.IMPEG.Cobranza
{
    public class admMovimientos : EntityBase
	{
        public admMovimientos()
		{
			_CREFERENCIA = string.Empty;
			_COBSERVAMOV = string.Empty;
			_CTEXTOEXTRA1 = string.Empty;
			_CTEXTOEXTRA2 = string.Empty;
			_CTEXTOEXTRA3 = string.Empty;
			_CTIMESTAMP = string.Empty;
			_CSCMOVTO = string.Empty;
		}

		System.Int32 _CIDMOVIMIENTO;
		public System.Int32 CIDMOVIMIENTO { get { return _CIDMOVIMIENTO; } set { if (value >= 0) _CIDMOVIMIENTO = value; } }

		System.Int32 _CIDDOCUMENTO;
		public System.Int32 CIDDOCUMENTO { get { return _CIDDOCUMENTO; } set { if (value >= 0) _CIDDOCUMENTO = value; } }

		System.Double _CNUMEROMOVIMIENTO;
		public System.Double CNUMEROMOVIMIENTO { get { return _CNUMEROMOVIMIENTO; } set { if (value >= 0) _CNUMEROMOVIMIENTO = value; } }

		System.Int32 _CIDDOCUMENTODE;
		public System.Int32 CIDDOCUMENTODE { get { return _CIDDOCUMENTODE; } set { if (value >= 0) _CIDDOCUMENTODE = value; } }

		System.Int32 _CIDPRODUCTO;
		public System.Int32 CIDPRODUCTO { get { return _CIDPRODUCTO; } set { if (value >= 0) _CIDPRODUCTO = value; } }

		System.Int32 _CIDALMACEN;
		public System.Int32 CIDALMACEN { get { return _CIDALMACEN; } set { if (value >= 0) _CIDALMACEN = value; } }

		System.Double _CUNIDADES;
		public System.Double CUNIDADES { get { return _CUNIDADES; } set { if (value >= 0) _CUNIDADES = value; } }

		System.Double _CUNIDADESNC;
		public System.Double CUNIDADESNC { get { return _CUNIDADESNC; } set { if (value >= 0) _CUNIDADESNC = value; } }

		System.Double _CUNIDADESCAPTURADAS;
		public System.Double CUNIDADESCAPTURADAS { get { return _CUNIDADESCAPTURADAS; } set { if (value >= 0) _CUNIDADESCAPTURADAS = value; } }

		System.Int32 _CIDUNIDAD;
		public System.Int32 CIDUNIDAD { get { return _CIDUNIDAD; } set { if (value >= 0) _CIDUNIDAD = value; } }

		System.Int32 _CIDUNIDADNC;
		public System.Int32 CIDUNIDADNC { get { return _CIDUNIDADNC; } set { if (value >= 0) _CIDUNIDADNC = value; } }

		System.Double _CPRECIO;
		public System.Double CPRECIO { get { return _CPRECIO; } set { if (value >= 0) _CPRECIO = value; } }

		System.Double _CPRECIOCAPTURADO;
		public System.Double CPRECIOCAPTURADO { get { return _CPRECIOCAPTURADO; } set { if (value >= 0) _CPRECIOCAPTURADO = value; } }

		System.Double _CCOSTOCAPTURADO;
		public System.Double CCOSTOCAPTURADO { get { return _CCOSTOCAPTURADO; } set { if (value >= 0) _CCOSTOCAPTURADO = value; } }

		System.Double _CCOSTOESPECIFICO;
		public System.Double CCOSTOESPECIFICO { get { return _CCOSTOESPECIFICO; } set { if (value >= 0) _CCOSTOESPECIFICO = value; } }

		System.Double _CNETO;
		public System.Double CNETO { get { return _CNETO; } set { if (value >= 0) _CNETO = value; } }

		System.Double _CIMPUESTO1;
		public System.Double CIMPUESTO1 { get { return _CIMPUESTO1; } set { if (value >= 0) _CIMPUESTO1 = value; } }

		System.Double _CPORCENTAJEIMPUESTO1;
		public System.Double CPORCENTAJEIMPUESTO1 { get { return _CPORCENTAJEIMPUESTO1; } set { if (value >= 0) _CPORCENTAJEIMPUESTO1 = value; } }

		System.Double _CIMPUESTO2;
		public System.Double CIMPUESTO2 { get { return _CIMPUESTO2; } set { if (value >= 0) _CIMPUESTO2 = value; } }

		System.Double _CPORCENTAJEIMPUESTO2;
		public System.Double CPORCENTAJEIMPUESTO2 { get { return _CPORCENTAJEIMPUESTO2; } set { if (value >= 0) _CPORCENTAJEIMPUESTO2 = value; } }

		System.Double _CIMPUESTO3;
		public System.Double CIMPUESTO3 { get { return _CIMPUESTO3; } set { if (value >= 0) _CIMPUESTO3 = value; } }

		System.Double _CPORCENTAJEIMPUESTO3;
		public System.Double CPORCENTAJEIMPUESTO3 { get { return _CPORCENTAJEIMPUESTO3; } set { if (value >= 0) _CPORCENTAJEIMPUESTO3 = value; } }

		System.Double _CRETENCION1;
		public System.Double CRETENCION1 { get { return _CRETENCION1; } set { if (value >= 0) _CRETENCION1 = value; } }

		System.Double _CPORCENTAJERETENCION1;
		public System.Double CPORCENTAJERETENCION1 { get { return _CPORCENTAJERETENCION1; } set { if (value >= 0) _CPORCENTAJERETENCION1 = value; } }

		System.Double _CRETENCION2;
		public System.Double CRETENCION2 { get { return _CRETENCION2; } set { if (value >= 0) _CRETENCION2 = value; } }

		System.Double _CPORCENTAJERETENCION2;
		public System.Double CPORCENTAJERETENCION2 { get { return _CPORCENTAJERETENCION2; } set { if (value >= 0) _CPORCENTAJERETENCION2 = value; } }

		System.Double _CDESCUENTO1;
		public System.Double CDESCUENTO1 { get { return _CDESCUENTO1; } set { if (value >= 0) _CDESCUENTO1 = value; } }

		System.Double _CPORCENTAJEDESCUENTO1;
		public System.Double CPORCENTAJEDESCUENTO1 { get { return _CPORCENTAJEDESCUENTO1; } set { if (value >= 0) _CPORCENTAJEDESCUENTO1 = value; } }

		System.Double _CDESCUENTO2;
		public System.Double CDESCUENTO2 { get { return _CDESCUENTO2; } set { if (value >= 0) _CDESCUENTO2 = value; } }

		System.Double _CPORCENTAJEDESCUENTO2;
		public System.Double CPORCENTAJEDESCUENTO2 { get { return _CPORCENTAJEDESCUENTO2; } set { if (value >= 0) _CPORCENTAJEDESCUENTO2 = value; } }

		System.Double _CDESCUENTO3;
		public System.Double CDESCUENTO3 { get { return _CDESCUENTO3; } set { if (value >= 0) _CDESCUENTO3 = value; } }

		System.Double _CPORCENTAJEDESCUENTO3;
		public System.Double CPORCENTAJEDESCUENTO3 { get { return _CPORCENTAJEDESCUENTO3; } set { if (value >= 0) _CPORCENTAJEDESCUENTO3 = value; } }

		System.Double _CDESCUENTO4;
		public System.Double CDESCUENTO4 { get { return _CDESCUENTO4; } set { if (value >= 0) _CDESCUENTO4 = value; } }

		System.Double _CPORCENTAJEDESCUENTO4;
		public System.Double CPORCENTAJEDESCUENTO4 { get { return _CPORCENTAJEDESCUENTO4; } set { if (value >= 0) _CPORCENTAJEDESCUENTO4 = value; } }

		System.Double _CDESCUENTO5;
		public System.Double CDESCUENTO5 { get { return _CDESCUENTO5; } set { if (value >= 0) _CDESCUENTO5 = value; } }

		System.Double _CPORCENTAJEDESCUENTO5;
		public System.Double CPORCENTAJEDESCUENTO5 { get { return _CPORCENTAJEDESCUENTO5; } set { if (value >= 0) _CPORCENTAJEDESCUENTO5 = value; } }

		System.Double _CTOTAL;
		public System.Double CTOTAL { get { return _CTOTAL; } set { if (value >= 0) _CTOTAL = value; } }

		System.Double _CPORCENTAJECOMISION;
		public System.Double CPORCENTAJECOMISION { get { return _CPORCENTAJECOMISION; } set { if (value >= 0) _CPORCENTAJECOMISION = value; } }

		System.String _CREFERENCIA;
		public System.String CREFERENCIA { get { return _CREFERENCIA; } set { if (value.Length >= 20) _CREFERENCIA = value.Substring(0, 20); else _CREFERENCIA = value; } }

		System.String _COBSERVAMOV;
		public System.String COBSERVAMOV { get { return _COBSERVAMOV; } set { if (value.Length >= 2147483647) _COBSERVAMOV = value.Substring(0, 2147483647); else _COBSERVAMOV = value; } }

		System.Int32 _CAFECTAEXISTENCIA;
		public System.Int32 CAFECTAEXISTENCIA { get { return _CAFECTAEXISTENCIA; } set { if (value >= 0) _CAFECTAEXISTENCIA = value; } }

		System.Int32 _CAFECTADOSALDOS;
		public System.Int32 CAFECTADOSALDOS { get { return _CAFECTADOSALDOS; } set { if (value >= 0) _CAFECTADOSALDOS = value; } }

		System.Int32 _CAFECTADOINVENTARIO;
		public System.Int32 CAFECTADOINVENTARIO { get { return _CAFECTADOINVENTARIO; } set { if (value >= 0) _CAFECTADOINVENTARIO = value; } }

		System.DateTime? _CFECHA;
		public System.DateTime? CFECHA { get { return _CFECHA; } set { _CFECHA = value; } }

		System.Int32 _CMOVTOOCULTO;
		public System.Int32 CMOVTOOCULTO { get { return _CMOVTOOCULTO; } set { if (value >= 0) _CMOVTOOCULTO = value; } }

		System.Int32 _CIDMOVTOOWNER;
		public System.Int32 CIDMOVTOOWNER { get { return _CIDMOVTOOWNER; } set { if (value >= 0) _CIDMOVTOOWNER = value; } }

		System.Int32 _CIDMOVTOORIGEN;
		public System.Int32 CIDMOVTOORIGEN { get { return _CIDMOVTOORIGEN; } set { if (value >= 0) _CIDMOVTOORIGEN = value; } }

		System.Double _CUNIDADESPENDIENTES;
		public System.Double CUNIDADESPENDIENTES { get { return _CUNIDADESPENDIENTES; } set { if (value >= 0) _CUNIDADESPENDIENTES = value; } }

		System.Double _CUNIDADESNCPENDIENTES;
		public System.Double CUNIDADESNCPENDIENTES { get { return _CUNIDADESNCPENDIENTES; } set { if (value >= 0) _CUNIDADESNCPENDIENTES = value; } }

		System.Double _CUNIDADESORIGEN;
		public System.Double CUNIDADESORIGEN { get { return _CUNIDADESORIGEN; } set { if (value >= 0) _CUNIDADESORIGEN = value; } }

		System.Double _CUNIDADESNCORIGEN;
		public System.Double CUNIDADESNCORIGEN { get { return _CUNIDADESNCORIGEN; } set { if (value >= 0) _CUNIDADESNCORIGEN = value; } }

		System.Int32 _CTIPOTRASPASO;
		public System.Int32 CTIPOTRASPASO { get { return _CTIPOTRASPASO; } set { if (value >= 0) _CTIPOTRASPASO = value; } }

		System.Int32 _CIDVALORCLASIFICACION;
		public System.Int32 CIDVALORCLASIFICACION { get { return _CIDVALORCLASIFICACION; } set { if (value >= 0) _CIDVALORCLASIFICACION = value; } }

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

		System.String _CTIMESTAMP;
		public System.String CTIMESTAMP { get { return _CTIMESTAMP; } set { if (value.Length >= 23) _CTIMESTAMP = value.Substring(0, 23); else _CTIMESTAMP = value; } }

		System.Double _CGTOMOVTO;
		public System.Double CGTOMOVTO { get { return _CGTOMOVTO; } set { if (value >= 0) _CGTOMOVTO = value; } }

		System.String _CSCMOVTO;
		public System.String CSCMOVTO { get { return _CSCMOVTO; } set { if (value.Length >= 50) _CSCMOVTO = value.Substring(0, 50); else _CSCMOVTO = value; } }

		System.Double _CCOMVENTA;
		public System.Double CCOMVENTA { get { return _CCOMVENTA; } set { if (value >= 0) _CCOMVENTA = value; } }

		System.Int32 _CIDMOVTODESTINO;
		public System.Int32 CIDMOVTODESTINO { get { return _CIDMOVTODESTINO; } set { if (value >= 0) _CIDMOVTODESTINO = value; } }

		System.Int32 _CNUMEROCONSOLIDACIONES;
		public System.Int32 CNUMEROCONSOLIDACIONES { get { return _CNUMEROCONSOLIDACIONES; } set { if (value >= 0) _CNUMEROCONSOLIDACIONES = value; } }

	}
}
