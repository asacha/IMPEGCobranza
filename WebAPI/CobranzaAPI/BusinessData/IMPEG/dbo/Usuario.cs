using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.IMPEG.dbo
{
    public class Usuario : BusinessData.Conexion.ConexionSQL
    {
        public Usuario()
        {
            NombreConexion = "cxnCobranza";
        }

        public BusinessEntity.DataHandler Consultar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.dbo.Usuario oBE)
        {
            BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

            try
            {
                DataSet Resultado = new DataSet();
                oComando.CommandText = "dbo.spUsuario_Consultar";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
                oParametro.Value = (short)Opcion;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@NumeroCliente", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.NumeroCliente;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Contrasena", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Contrasena;
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

        public BusinessEntity.DataHandler Insertar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.dbo.Usuario oBE)
        {
            BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

            try
            {
                DataSet Resultado = new DataSet();
                oComando.CommandText = "dbo.spUsuario_Insertar";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
                oParametro.Value = (short)Opcion;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Nombre;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Paterno", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Paterno;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Materno", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Materno;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Genero", System.Data.SqlDbType.Char);
                oParametro.Value = oBE.Genero;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@NumeroCliente", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.NumeroCliente;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Correo", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Correo;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Contrasena", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Contrasena;
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

        public BusinessEntity.DataHandler Actualizar(BusinessEntity.QueryOptions Opcion, BusinessEntity.IMPEG.dbo.Usuario oBE)
        {
            BusinessEntity.DataHandler oDataHandler = new BusinessEntity.DataHandler();

            try
            {
                DataSet Resultado = new DataSet();
                oComando.CommandText = "dbo.spUsuario_Actualizar";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@Opcion", System.Data.SqlDbType.SmallInt);
                oParametro.Value = (short)Opcion;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@UsuarioId", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.UsuarioId;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Nombre;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Paterno", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Paterno;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Materno", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Materno;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Genero", System.Data.SqlDbType.Char);
                oParametro.Value = oBE.Genero;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@NumeroCliente", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.NumeroCliente;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Correo", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Correo;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Contrasena", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Contrasena;
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
