using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessData.IMPEG.Cobranza
{
	public class admClientes : Conexion.ConexionSQL
	{
		public admClientes()
		{
			NombreConexion = "cxnCobranza";
		}

		public BusinessEntity.DataHandler Consultar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.Cobranza.admClientes oBE)
		{
			BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

			try
			{
				DataSet Resultado = new DataSet();
				oComando.CommandText = "Cobranza.spadmClientes_Consultar";
				oComando.CommandType = System.Data.CommandType.StoredProcedure;

				oComando.Parameters.Clear();
				oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
				oParametro.Value = (short) Opcion;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDCLIENTEPROVEEDOR", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDCLIENTEPROVEEDOR;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCODIGOCLIENTE", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CCODIGOCLIENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CRAZONSOCIAL", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CRAZONSOCIAL;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CFECHAALTA", System.Data.SqlDbType.DateTime);
				oParametro.Value = oBE.CFECHAALTA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CRFC", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CRFC;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCURP", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CCURP;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDENCOMERCIAL", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CDENCOMERCIAL;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CREPLEGAL", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CREPLEGAL;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDMONEDA", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDMONEDA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CLISTAPRECIOCLIENTE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CLISTAPRECIOCLIENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTODOCTO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CDESCUENTODOCTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTOMOVTO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CDESCUENTOMOVTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANVENTACREDITO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANVENTACREDITO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFCLIENTE1", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFCLIENTE1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFCLIENTE2", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFCLIENTE2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFCLIENTE3", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFCLIENTE3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFCLIENTE4", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFCLIENTE4;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFCLIENTE5", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFCLIENTE5;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFCLIENTE6", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFCLIENTE6;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTIPOCLIENTE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CTIPOCLIENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CESTATUS", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CESTATUS;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CFECHABAJA", System.Data.SqlDbType.DateTime);
				oParametro.Value = oBE.CFECHABAJA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CFECHAULTIMAREVISION", System.Data.SqlDbType.DateTime);
				oParametro.Value = oBE.CFECHAULTIMAREVISION;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CLIMITECREDITOCLIENTE", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CLIMITECREDITOCLIENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDIASCREDITOCLIENTE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CDIASCREDITOCLIENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANEXCEDERCREDITO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANEXCEDERCREDITO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTOPRONTOPAGO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CDESCUENTOPRONTOPAGO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDIASPRONTOPAGO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CDIASPRONTOPAGO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CINTERESMORATORIO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CINTERESMORATORIO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDIAPAGO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CDIAPAGO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDIASREVISION", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CDIASREVISION;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CMENSAJERIA", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CMENSAJERIA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCUENTAMENSAJERIA", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CCUENTAMENSAJERIA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDIASEMBARQUECLIENTE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CDIASEMBARQUECLIENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDALMACEN", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDALMACEN;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDAGENTEVENTA", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDAGENTEVENTA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDAGENTECOBRO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDAGENTECOBRO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CRESTRICCIONAGENTE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CRESTRICCIONAGENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTO1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPUESTO1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTO2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPUESTO2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTO3", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPUESTO3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CRETENCIONCLIENTE1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CRETENCIONCLIENTE1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CRETENCIONCLIENTE2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CRETENCIONCLIENTE2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFPROVEEDOR1", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFPROVEEDOR1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFPROVEEDOR2", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFPROVEEDOR2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFPROVEEDOR3", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFPROVEEDOR3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFPROVEEDOR4", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFPROVEEDOR4;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFPROVEEDOR5", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFPROVEEDOR5;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFPROVEEDOR6", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFPROVEEDOR6;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CLIMITECREDITOPROVEEDOR", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CLIMITECREDITOPROVEEDOR;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDIASCREDITOPROVEEDOR", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CDIASCREDITOPROVEEDOR;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTIEMPOENTREGA", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CTIEMPOENTREGA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDIASEMBARQUEPROVEEDOR", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CDIASEMBARQUEPROVEEDOR;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTOPROVEEDOR1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPUESTOPROVEEDOR1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTOPROVEEDOR2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPUESTOPROVEEDOR2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTOPROVEEDOR3", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPUESTOPROVEEDOR3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CRETENCIONPROVEEDOR1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CRETENCIONPROVEEDOR1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CRETENCIONPROVEEDOR2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CRETENCIONPROVEEDOR2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANINTERESMORATORIO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANINTERESMORATORIO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCOMVENTAEXCEPCLIENTE", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CCOMVENTAEXCEPCLIENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCOMCOBROEXCEPCLIENTE", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CCOMCOBROEXCEPCLIENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANPRODUCTOCONSIGNACION", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANPRODUCTOCONSIGNACION;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTCLIENTE1", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTCLIENTE1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTCLIENTE2", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTCLIENTE2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTCLIENTE3", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTCLIENTE3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTCLIENTE4", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTCLIENTE4;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTCLIENTE5", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTCLIENTE5;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTCLIENTE6", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTCLIENTE6;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTCLIENTE7", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTCLIENTE7;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTPROVEEDOR1", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTPROVEEDOR1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTPROVEEDOR2", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTPROVEEDOR2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTPROVEEDOR3", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTPROVEEDOR3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTPROVEEDOR4", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTPROVEEDOR4;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTPROVEEDOR5", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTPROVEEDOR5;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTPROVEEDOR6", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTPROVEEDOR6;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSEGCONTPROVEEDOR7", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSEGCONTPROVEEDOR7;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTEXTOEXTRA1", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CTEXTOEXTRA1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTEXTOEXTRA2", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CTEXTOEXTRA2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTEXTOEXTRA3", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CTEXTOEXTRA3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CFECHAEXTRA", System.Data.SqlDbType.DateTime);
				oParametro.Value = oBE.CFECHAEXTRA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPORTEEXTRA1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPORTEEXTRA1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPORTEEXTRA2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPORTEEXTRA2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPORTEEXTRA3", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPORTEEXTRA3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPORTEEXTRA4", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPORTEEXTRA4;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANDOMICILIO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANDOMICILIO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANCREDITOYCOBRANZA", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANCREDITOYCOBRANZA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANENVIO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANENVIO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANAGENTE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANAGENTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANIMPUESTO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANIMPUESTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANPRECIO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANPRECIO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTIMESTAMP", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CTIMESTAMP;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CFACTERC01", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CFACTERC01;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCOMVENTA", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CCOMVENTA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCOMCOBRO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CCOMCOBRO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDMONEDA2", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDMONEDA2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CEMAIL1", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CEMAIL1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CEMAIL2", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CEMAIL2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CEMAIL3", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CEMAIL3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTIPOENTRE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CTIPOENTRE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCONCTEEMA", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CCONCTEEMA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CFTOADDEND", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CFTOADDEND;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDCERTCTE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDCERTCTE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CENCRIPENT", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CENCRIPENT;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CBANCFD", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CBANCFD;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTEXTOEXTRA4", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CTEXTOEXTRA4;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTEXTOEXTRA5", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CTEXTOEXTRA5;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPORTEEXTRA5", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPORTEEXTRA5;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDADDENDA", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDADDENDA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCODPROVCO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CCODPROVCO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CENVACUSE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CENVACUSE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCON1NOM", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CCON1NOM;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCON1TEL", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CCON1TEL;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CQUITABLAN", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CQUITABLAN;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CFMTOENTRE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CFMTOENTRE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDCOMPLEM", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDCOMPLEM;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDESGLOSAI2", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CDESGLOSAI2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CLIMDOCTOS", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CLIMDOCTOS;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSITIOFTP", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSITIOFTP;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CUSRFTP", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CUSRFTP;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CMETODOPAG", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CMETODOPAG;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CNUMCTAPAG", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CNUMCTAPAG;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDCUENTA", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDCUENTA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CUSOCFDI", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CUSOCFDI;
				oComando.Parameters.Add(oParametro);

				if (this.Conectar())
				{
					SqlDataAdapter daResultado = new SqlDataAdapter(oComando);
					daResultado.Fill(oDataHandler.Resultado);
					Desconectar();
				}
			}
			catch (Exception ex)
			{
				oDataHandler.Error = true;
				oDataHandler.MensajeError = ex.Message;
			}

			return oDataHandler;

		}
	}
}
