using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CobranzaAPI.Areas.Usuario.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpGet]
        public string Autenticar(string NumeroCliente, string Contrasena)
        {
            string Resultado = string.Empty;
            string MensajeError = string.Empty;
            bool Error = false;
            int ErrorId = 0;

            #region Valida parámetros
            if (NumeroCliente == null || Contrasena == null)
            {
                Resultado = "[{\"Error\":true,\"ErrorId\":1010,\"MensajeError\":\"Parámetros no válidos.\"}]";
                return Resultado;
            }
            #endregion

            #region Obtener Parámetros
            BusinessEntity.IMPEG.dbo.Usuario oUsuarioBE = new BusinessEntity.IMPEG.dbo.Usuario();
            oUsuarioBE.NumeroCliente = NumeroCliente;
            oUsuarioBE.Contrasena = Contrasena;
            #endregion

            BusinessEntity.DataHandler oDH = BusinessLogic.Util.Consultar(BusinessEntity.QueryOptions.Consultar_IniciarSesion, oUsuarioBE);

            #region Validaciones
            if (oDH.Error)
            {
                Resultado = "[{\"Error\":true,\"ErrorId\":1020,\"MensajeError\":\"" + oDH.MensajeError + "\"}]"; ;
                return Resultado;
            }

            if (!oDH.ContieneInformacion)
            {
                Resultado = "[{\"Error\":true,\"ErrorId\":1030,\"MensajeError\":\"Lo sentimos, ocurrió un problema.\"}]";
                return Resultado;
            }

            DataRow drValidacion = oDH.Resultado.Tables[0].Rows[0];
            if (!Convert.ToBoolean(drValidacion["UsuarioExiste"]))
            {
                Error = true;
                ErrorId = 1040;
                MensajeError = "Cliente no registrado.";
            }
            else if (!Convert.ToBoolean(drValidacion["ContrasenaCorrecta"]))
            {
                Error = true;
                ErrorId = 1050;
                MensajeError = "Contraseña incorrecta.";
            }
            else if (Convert.ToBoolean(drValidacion["Baja"]))
            {
                Error = true;
                ErrorId = 1090;
                MensajeError = "Cuenta dada de baja.";
            }
            #endregion

            #region Obtener información
            if (oDH.ContieneInformacion)
            {
                Resultado = BusinessLogic.Util.ConvertDataTabletoString(oDH.Resultado.Tables[0]);
            }
            else
            {
                Resultado = "[{\"Error\":true,\"ErrorId\":1100,\"MensajeError\":\"" + MensajeError + "\"}]";
            }
            #endregion

            return Resultado;
        }
    }
}
