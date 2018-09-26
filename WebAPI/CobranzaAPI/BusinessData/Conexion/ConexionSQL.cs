﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessData.Conexion
{
    public class ConexionSQL
    {
        public string NombreConexion = "cxn";
        public SqlConnection oConexion = new SqlConnection();
        public SqlCommand oComando;
        public SqlParameter oParametro;
        public SqlDataAdapter oAdaptador;

        public ConexionSQL()
        {
            oComando = new SqlCommand();
        }

        public bool Conectar()
        {
            oConexion.ConnectionString = ConfigurationManager.ConnectionStrings[NombreConexion].ConnectionString;

            if (oConexion.State == ConnectionState.Closed)
            {
                try
                {
                    oConexion.Open();
                    oComando.Connection = oConexion;
                    return true;
                }
                catch
                {

                }
            }

            return false;
        }

        public void Desconectar()
        {
            try
            {
                oConexion.Close();
            }
            catch
            {

            }
        }
    }
}
