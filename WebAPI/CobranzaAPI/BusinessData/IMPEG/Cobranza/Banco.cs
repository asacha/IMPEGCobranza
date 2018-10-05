using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessData.IMPEG.Cobranza
{
	public class Banco : Conexion.ConexionSQL
	{
		public Banco()
		{
			NombreConexion = "cxnCobranza";
		}

		public BusinessEntity.DataHandler Consultar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.Cobranza.Banco oBE)
		{
			BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

			try
			{
				DataSet Resultado = new DataSet();
				oComando.CommandText = "Cobranza.spBanco_Consultar";
				oComando.CommandType = System.Data.CommandType.StoredProcedure;

				oComando.Parameters.Clear();
				oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
				oParametro.Value = (short) Opcion;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@BancoId", System.Data.SqlDbType.Int);
				oParametro.Value = oBE.BancoId;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@BancoDescripcion", System.Data.SqlDbType.NVarChar);
				oParametro.Value = oBE.BancoDescripcion;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@Clave", System.Data.SqlDbType.NVarChar);
				oParametro.Value = oBE.Clave;
				oComando.Parameters.Add(oParametro);

				oParametro = new System.Data.SqlClient.SqlParameter("@Baja", System.Data.SqlDbType.Bit);
				oParametro.Value = oBE.Baja;
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
