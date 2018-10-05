using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessData.IMPEG.Cobranza
{
	public class admMovimientos : Conexion.ConexionSQL
	{
		public admMovimientos()
		{
			NombreConexion = "cxnCobranza";
		}

		public BusinessEntity.DataHandler Consultar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.Cobranza.admMovimientos oBE)
		{
			BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

			try
			{
				DataSet Resultado = new DataSet();
				oComando.CommandText = "Cobranza.spadmMovimientos_Consultar";
				oComando.CommandType = System.Data.CommandType.StoredProcedure;

				oComando.Parameters.Clear();
				oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
				oParametro.Value = (short)Opcion;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDMOVIMIENTO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDMOVIMIENTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDDOCUMENTO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDDOCUMENTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CNUMEROMOVIMIENTO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CNUMEROMOVIMIENTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDDOCUMENTODE", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDDOCUMENTODE;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDPRODUCTO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDPRODUCTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDALMACEN", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDALMACEN;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CUNIDADES", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CUNIDADES;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CUNIDADESNC", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CUNIDADESNC;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CUNIDADESCAPTURADAS", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CUNIDADESCAPTURADAS;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDUNIDAD", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDUNIDAD;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDUNIDADNC", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDUNIDADNC;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPRECIO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPRECIO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPRECIOCAPTURADO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPRECIOCAPTURADO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCOSTOCAPTURADO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CCOSTOCAPTURADO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCOSTOESPECIFICO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CCOSTOESPECIFICO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CNETO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CNETO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTO1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPUESTO1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEIMPUESTO1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJEIMPUESTO1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTO2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPUESTO2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEIMPUESTO2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJEIMPUESTO2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIMPUESTO3", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CIMPUESTO3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEIMPUESTO3", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJEIMPUESTO3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CRETENCION1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CRETENCION1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJERETENCION1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJERETENCION1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CRETENCION2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CRETENCION2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJERETENCION2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJERETENCION2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTO1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CDESCUENTO1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEDESCUENTO1", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJEDESCUENTO1;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTO2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CDESCUENTO2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEDESCUENTO2", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJEDESCUENTO2;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTO3", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CDESCUENTO3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEDESCUENTO3", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJEDESCUENTO3;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTO4", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CDESCUENTO4;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEDESCUENTO4", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJEDESCUENTO4;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CDESCUENTO5", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CDESCUENTO5;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJEDESCUENTO5", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJEDESCUENTO5;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTOTAL", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CTOTAL;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CPORCENTAJECOMISION", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CPORCENTAJECOMISION;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CREFERENCIA", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CREFERENCIA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CAFECTAEXISTENCIA", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CAFECTAEXISTENCIA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CAFECTADOSALDOS", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CAFECTADOSALDOS;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CAFECTADOINVENTARIO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CAFECTADOINVENTARIO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CFECHA", System.Data.SqlDbType.DateTime);
				oParametro.Value = oBE.CFECHA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CMOVTOOCULTO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CMOVTOOCULTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDMOVTOOWNER", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDMOVTOOWNER;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDMOVTOORIGEN", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDMOVTOORIGEN;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CUNIDADESPENDIENTES", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CUNIDADESPENDIENTES;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CUNIDADESNCPENDIENTES", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CUNIDADESNCPENDIENTES;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CUNIDADESORIGEN", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CUNIDADESORIGEN;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CUNIDADESNCORIGEN", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CUNIDADESNCORIGEN;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CTIPOTRASPASO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CTIPOTRASPASO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDVALORCLASIFICACION", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDVALORCLASIFICACION;
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

				oParametro = new System.Data.SqlClient.SqlParameter("@CTIMESTAMP", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CTIMESTAMP;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CGTOMOVTO", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CGTOMOVTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CSCMOVTO", System.Data.SqlDbType.VarChar);
				oParametro.Value = oBE.CSCMOVTO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CCOMVENTA", System.Data.SqlDbType.Float);
				oParametro.Value = oBE.CCOMVENTA;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CIDMOVTODESTINO", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CIDMOVTODESTINO;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@CNUMEROCONSOLIDACIONES", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.CNUMEROCONSOLIDACIONES;
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
