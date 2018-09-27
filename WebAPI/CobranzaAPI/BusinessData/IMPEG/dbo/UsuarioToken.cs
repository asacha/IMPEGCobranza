using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.IMPEG.dbo
{
    public class UsuarioToken : BusinessData.Conexion.ConexionSQL
    {
        public UsuarioToken()
        {
            NombreConexion = "cxnCobranza";
        }

        public BusinessEntity.DataHandler Consultar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.dbo.UsuarioToken oBE)
        {
            BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

            try
            {
                DataSet Resultado = new DataSet();
                oComando.CommandText = "dbo.spUsuarioToken_Consultar";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
                oParametro.Value = (short)Opcion;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioTokenId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioTokenId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Token", System.Data.SqlDbType.NVarChar);
                oParametro.Value = oBE.Token;
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

        public BusinessEntity.DataHandler Insertar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.dbo.UsuarioToken oBE)
        {
            BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

            try
            {
                DataSet Resultado = new DataSet();
                oComando.CommandText = "dbo.spUsuarioToken_Insertar";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
                oParametro.Value = (short)Opcion;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Token", System.Data.SqlDbType.NVarChar);
                oParametro.Value = oBE.Token;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioCreacionId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioCreacionId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioModificacionId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioModificacionId;
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

        public BusinessEntity.DataHandler Actualizar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.dbo.UsuarioToken oBE)
        {
            BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

            try
            {
                DataSet Resultado = new DataSet();
                oComando.CommandText = "dbo.spUsuarioToken_Actualizar";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
                oParametro.Value = (short)Opcion;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioTokenId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioTokenId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Token", System.Data.SqlDbType.NVarChar);
                oParametro.Value = oBE.Token;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioModificacionId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioModificacionId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@FechaModificacion", System.Data.SqlDbType.DateTime);
                oParametro.Value = oBE.FechaModificacion;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioBajaId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioBajaId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@FechaBaja", System.Data.SqlDbType.DateTime);
                oParametro.Value = oBE.FechaBaja;
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
