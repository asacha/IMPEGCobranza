using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace CobranzaAPI.Areas.Catalogo.Controllers
{
    public class ListaController : ApiController
    {
        [HttpGet]
        public JsonResult<ListaSucursalResponse> obtenerSucursales(string Token)
        {
            ListaSucursalResponse respuesta = new ListaSucursalResponse(false, 0, string.Empty);

            #region Validar Token
            if (!BusinessLogic.Validacion.TokenValido(Token))
            {
                respuesta = new ListaSucursalResponse(true, 9010, "Token no válido");
                return Json(respuesta);
            }
            #endregion

            #region llamar a BD y obtener las Sucursales
            BusinessEntity.IMPEG.Cobranza.Sucursal oSucursalBE = new BusinessEntity.IMPEG.Cobranza.Sucursal();
            oSucursalBE.Baja = false;

            BusinessEntity.DataHandler oDH = BusinessLogic.Util.Consultar(BusinessEntity.QueryOptions.Consultar_ParaLista, oSucursalBE);
            #endregion

            #region Validaciones
            if (oDH.Error)
            {
                respuesta.Error = true;
                respuesta.ErrorId = 9011;
                respuesta.MensajeError = "Lo sentimos, ocurrió un problema.";
            }

            if (!oDH.ContieneInformacion)
            {
                respuesta.Error = true;
                respuesta.ErrorId = 9012;
                respuesta.MensajeError = "No pudimos obtener el listado de sucursales.";
            }
            #endregion

            #region Asignación de información
            foreach (System.Data.DataRow dr in oDH.Resultado.Tables[0].Rows)
            {
                respuesta.Sucursales.Add(new Sucursal(dr));
            }
            #endregion

            return Json(respuesta);
        }

        [HttpGet]
        public JsonResult<ListaBancoResponse> obtenerBancos(string Token)
        {
            ListaBancoResponse respuesta = new ListaBancoResponse(false, 0, string.Empty);

            #region Validar Token
            if (!BusinessLogic.Validacion.TokenValido(Token))
            {
                respuesta = new ListaBancoResponse(true, 9020, "Token no válido");
                return Json(respuesta);
            }
            #endregion

            #region llamar a BD y obtener las Sucursales
            BusinessEntity.IMPEG.Cobranza.Banco oBancoBE = new BusinessEntity.IMPEG.Cobranza.Banco();
            oBancoBE.Baja = false;

            BusinessEntity.DataHandler oDH = BusinessLogic.Util.Consultar(BusinessEntity.QueryOptions.Consultar_ParaLista, oBancoBE);
            #endregion

            #region Validaciones
            if (oDH.Error)
            {
                respuesta.Error = true;
                respuesta.ErrorId = 9021;
                respuesta.MensajeError = "Lo sentimos, ocurrió un problema.";
            }

            if (!oDH.ContieneInformacion)
            {
                respuesta.Error = true;
                respuesta.ErrorId = 9022;
                respuesta.MensajeError = "No pudimos obtener el listado de bancos.";
            }
            #endregion

            #region Asignación de información
            foreach (System.Data.DataRow dr in oDH.Resultado.Tables[0].Rows)
            {
                respuesta.Bancos.Add(new Banco(dr));
            }
            #endregion

            return Json(respuesta);
        }
    }

    public class ListaSucursalResponse
    {
        public ListaSucursalResponse(bool error, int errorId, string mensajeError)
        {
            Error = error;
            ErrorId = errorId;
            MensajeError = mensajeError;
            Sucursales = new List<Sucursal>();
        }

        public bool Error { get; set; }
        public int ErrorId { get; set; }
        public string MensajeError { get; set; }

        public List<Sucursal> Sucursales { get; set; }
    }

    public class ListaBancoResponse
    {
        public ListaBancoResponse(bool error, int errorId, string mensajeError)
        {
            Error = error;
            ErrorId = errorId;
            MensajeError = mensajeError;
            Bancos = new List<Banco>();
        }

        public bool Error { get; set; }
        public int ErrorId { get; set; }
        public string MensajeError { get; set; }

        public List<Banco> Bancos { get; set; }
    }

    public class Sucursal
    {
        public Sucursal(int sucursalId, string sucursalDescripcion)
        {
            SucursalId = sucursalId;
            SucursalDescripcion = sucursalDescripcion;
        }

        public Sucursal(System.Data.DataRow dr)
        {
            SucursalId = Convert.ToInt32(dr["SucursalId"]);
            SucursalDescripcion = dr["SucursalDescripcion"].ToString();
        }

        public int SucursalId { get; set; }
        public string SucursalDescripcion { get; set; }
    }

    public class Banco
    {
        public Banco(int bancoId, string bancoDescripcion, string clave)
        {
            BancoId = bancoId;
            BancoDescripcion = bancoDescripcion;
            Clave = clave;
        }

        public Banco(System.Data.DataRow dr)
        {
            BancoId = Convert.ToInt32(dr["BancoId"]);
            BancoDescripcion = dr["BancoDescripcion"].ToString();
            Clave = dr["Clave"].ToString();
        }

        public int BancoId { get; set; }
        public string BancoDescripcion { get; set; }
        public string Clave { get; set; }
    }
}
